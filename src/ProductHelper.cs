using System;
using System.Collections.Generic;
using Npgsql;
using System.Data;

namespace TestPg.Products
{
public static class ProductHelper
{
static NpgsqlConnection GetConnection()
{
    return new NpgsqlConnection("Server=127.0.0.1;Port=5432;Database=Cli;User ID=postgres;Password=Pa$$W0rd");
}

public static string CreateProduct(string code, string name)
{
    int p_id = 0;
    DateTime p_created = DateTime.Now;
    NpgsqlParameter[] parameters = new NpgsqlParameter[4];
    parameters[0] = new NpgsqlParameter("p_code", code);
    parameters[1] = new NpgsqlParameter("p_name", name);
    parameters[2] = new NpgsqlParameter("p_id", p_id);
    parameters[2].Direction = ParameterDirection.Output;
    parameters[3] = new NpgsqlParameter("p_created",p_created);
    parameters[3].Direction = ParameterDirection.Output;
    NpgsqlConnection conn = GetConnection();
    try
    {
        conn.Open();
        string commandText = $"SELECT usp_insertproduct('{code}','{name}')";
        using (NpgsqlCommand cmd = new NpgsqlCommand(commandText, conn))
        {
            //cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddRange(parameters);
            cmd.ExecuteNonQuery();
            //Catch the output parameters values
            p_id = Convert.ToInt32(cmd.Parameters["p_id"].Value);
            p_created = Convert.ToDateTime(cmd.Parameters["p_created"].Value);
        }
    }
    finally
    {
        if (conn != null
            && conn.State == ConnectionState.Open)
            conn.Close();
    }
    return String.Format("Record {0} inserted at {1}",p_id,p_created);
}
}
}
