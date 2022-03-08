using System;
using System.Collections.Generic;
using System.Data;
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
    /// Логика взаимодействия для Table.xaml
    /// </summary>
    public partial class Table : Window
    {
        public void relDT(string selectText)
        {
            string connectionString = @"Data Source=(LocalDb)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True";

            string sql = $"SELECT Name, IP, MAC, Device_Type, Condition, Address, Note FROM Equipment WHERE (Name LIKE N'%{selectText}%' OR IP LIKE N'%{selectText}%' OR MAC LIKE N'%{selectText}%' OR " +
                $"Device_Type LIKE N'%{selectText}%' OR Condition LIKE N'%{selectText}%' OR Address LIKE N'%{selectText}%' OR Note LIKE N'%{selectText}%') AND ID_in_item > 0";

            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand cmdSel = new SqlCommand(sql, connection);
            DataTable dataTab = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmdSel);
            da.Fill(dataTab);
            dataGrid.ItemsSource = dataTab.DefaultView;
        }
        public Table()
        {
            InitializeComponent();
            relDT("");
        }

        private void search_Click(object sender, RoutedEventArgs e)
        {
            relDT(searchText.Text.ToString());
        }

        private void sizeT_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            relDT(searchText.Text.ToString());
        }

        private void dataGrid_TextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = true;
        }
    }
}
