﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DAL
{
    public class DataProvider
    {
        private static DataProvider instance;
        public static DataProvider Instance 
        {
            get { if (instance == null) instance = new DataProvider(); return instance; } 
            private set => instance = value; 
        }

        private DataProvider() { }


        private string connectionSTR = "Data Source=.;Initial Catalog=QLCHBanLinhKien;Integrated Security=True;TrustServerCertificate=True";

        // Dùng cho select
        public DataTable ExecuteQuery(string query, object[]? parameter = null)
        {
            DataTable data = new();

            using (SqlConnection connection = new(connectionSTR))
            {
                connection.Open();

                SqlCommand command = new(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                SqlDataAdapter adapter = new(command);

                adapter.Fill(data);

                connection.Close();
            }

            return data;
        }

        // Dùng I U D
        public int ExecuteNonQuery(string query, object[]? parameter = null)
        {
            int data = 0;

            using (SqlConnection connection = new(connectionSTR))
            {
                connection.Open();

                SqlCommand command = new(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                data = command.ExecuteNonQuery();

                connection.Close();
            }

            return data;
        }

        public object ExecuteScalar(string query, object[]? parameter = null)
        {
            object data = 0;

            using (SqlConnection connection = new(connectionSTR))
            {
                connection.Open();

                SqlCommand command = new(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                data = command.ExecuteScalar();

                connection.Close();
            }

            return data;
        }
    }
}
