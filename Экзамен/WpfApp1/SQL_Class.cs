using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp1
{
    static class SQL_Class
    {
        public static string connectionString = "server=localhost;user=root;database=mac_zakaz";
        public static MySqlConnection connection;
        public static bool OPENED = false;

        public static void SQL_Starter()
        {
            try
            {
                connection = new MySqlConnection(connectionString);
                connection.Open();
                connection.Close();
                OPENED = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Ошибка!");
            }
        }
        public static void SQL_OpenServer()
        {
            connection = new MySqlConnection(connectionString);
            connection.Open();
        }
        public static void SQL_CloseServer()
        {
            connection.Close();
        }
    }
}
