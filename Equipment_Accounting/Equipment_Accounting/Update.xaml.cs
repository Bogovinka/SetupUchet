using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Equipment_Accounting
{
    /// <summary>
    /// Логика взаимодействия для Update.xaml
    /// </summary>
    public partial class Update : Window
    {
        public string name_i = "";
        MainWindow w = new MainWindow();
        string connectionString = @"Data Source=(LocalDb)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True";
        public void editSelect(string note)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand sqlCom = new SqlCommand($"SELECT Name, IP, MAC, Device_Type, Condition, Address, Note FROM Equipment WHERE Name_Item = N'{note}'", connection);
            connection.Open();
            SqlDataReader read = sqlCom.ExecuteReader();
            while (read.Read())
            {
                nameT.Text = read.GetString(0);
                IPT.Text = read.GetString(1);
                MACT.Text = read.GetString(2);
                TypeT.Text = read.GetString(3);
                StateT.Text = read.GetString(4);
                AdresT.Text = read.GetString(5);
                NoteT.Text = read.GetString(6);
            }
            connection.Close();
        }
        WorkBD workBD = new WorkBD();
        public Update(string name_note)
        {
            InitializeComponent();
            editSelect(name_note);
        }
        private void createB_Click(object sender, RoutedEventArgs e)
        {
            if (nameT.Text.Length > 0 && IPT.Text.Length > 0 && MACT.Text.Length > 0)
            {
                DialogResult = true;
            }
            else { }
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            this.Close();
        }
    }
}
