﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Xml;

namespace DAL
{
    public class SqlHelper
    {
        static string ConnectionString { get; set; } = "server=124.222.114.100;database=ShanHu;uid=sa;pwd=jhkd5960795.";

        public static DataTable ExecuteTable(string cmdText, params SqlParameter[] sqlParameters)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(cmdText, conn);
                cmd.Parameters.AddRange(sqlParameters);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                return ds.Tables[0];
            }
        }

        public static int ExecuteNonQuery(string cmdText, params SqlParameter[] sqlParameters)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(cmdText, conn);
                cmd.Parameters.AddRange(sqlParameters);
                return cmd.ExecuteNonQuery();
            }
        }

        public static object ExecuteScalar(string sql,SqlParameter para)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add(para);
                return cmd.ExecuteScalar();
            }
        }
    }
}
