using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Equipment_Accounting
{

    class WorkBD
    {
        string connectionString = @"Data Source=(LocalDb)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True";

        public string selectItem(string text)
        {
            string res = "";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand sqlCom = new SqlCommand($"SELECT Name_Item FROM Equipment " +
                    $"WHERE Name >= N'{text}' OR IP >= N'{text}' OR MAC >= N'{text}' OR Device_Type >= N'{text}' OR Condition >= N'{text}'", connection);
                connection.Open();
                SqlDataReader read = sqlCom.ExecuteReader();
                while (read.Read()) res = read.GetString(0);
                connection.Close();
            }
            return res;
        }

        public bool testSearch(string name_colum, string search)
        {
            bool res = true;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand sqlCom = new SqlCommand($"SELECT COUNT(*) FROM Equipment WHERE {name_colum} = N'{search}'", connection);
                connection.Open();
                SqlDataReader read = sqlCom.ExecuteReader();
                while (read.Read()) if (Convert.ToInt32(read.GetValue(0)) > 0) res = false;
                connection.Close();
            }
            return res;
        }
        public int getIDin(TreeViewItem t, string id)
        {
            string n_note = t.Header.ToString();
            int res = 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand sqlCom = new SqlCommand($"SELECT {id} FROM Equipment WHERE Name_Item = N'{n_note}'", connection);
                connection.Open();
                SqlDataReader read = sqlCom.ExecuteReader();
                while (read.Read()) res = Convert.ToInt32(read.GetValue(0));
                connection.Close();
            }
            return res;
        }
        public void insertDB(string name, string ip, string mac, string type, string state, string adres, string note, string name_item, int id_in_item)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = $"INSERT INTO Equipment(Name, IP, MAC, Device_Type, Condition, Address, Note, Name_Item, ID_in_item)" +
                $" VALUES (N'{name}', N'{ip}', N'{mac}', N'{type}', N'{state}', N'{adres}', N'{note}', N'{name_item}', '{id_in_item}')";
            SqlCommand command = new SqlCommand(query, connection);
            // выполняем запрос
            command.ExecuteNonQuery();
            connection.Close();
        }
        public void updateDB(string name, string ip, string mac, string type, string state, string adres, string note, string name_item, string whereS)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = $"UPDATE Equipment SET Name = N'{name}', IP = N'{ip}', MAC = N'{mac}', " +
                $"Device_Type = N'{type}', Condition = N'{state}', Address = N'{adres}', Note = N'{note}', Name_Item = N'{name_item}'" +
                $"WHERE Name_Item = N'{whereS}'";
            SqlCommand command = new SqlCommand(query, connection);
            // выполняем запрос
            command.ExecuteNonQuery();
            connection.Close();
        }
        public void insertDB(string name_item, int id_in)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = $"INSERT INTO Equipment(Name_Item, ID_in_item)" +
                $" VALUES (N'{name_item}', '{id_in}')";
            SqlCommand command = new SqlCommand(query, connection);
            // выполняем запрос
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void delete(TreeViewItem t)
        {
            string n_note = t.Header.ToString();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand sqlCom = new SqlCommand($"DELETE FROM Equipment WHERE Name_Item = N'{n_note}'", connection);
                connection.Open();
                sqlCom.ExecuteReader();
                connection.Close();
            }

        }
    }
}
