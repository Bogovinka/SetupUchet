using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Equipment_Accounting
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        string connectionString = @"Data Source=(LocalDb)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True";
        WorkBD workBD = new WorkBD();

        void addItems(TreeViewItem selectT)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand sqlCom = new SqlCommand($"SELECT Name_Item FROM Equipment WHERE ID_in_item = N'{workBD.getIDin(selectT, "ID")}'", connection);
            connection.Open();
            SqlDataReader read = sqlCom.ExecuteReader();
            TreeViewItem aTV;
            while (read.Read())
            {
                aTV = new TreeViewItem();
                aTV.Header = read.GetString(0);
                selectT.Items.Add(aTV);
                addItems(aTV);
            }
            connection.Close();
        }
        void updateTree()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand sqlCom = new SqlCommand($"SELECT Name_Item FROM Equipment WHERE ID_in_item = '0'", connection);
            connection.Open();
            SqlDataReader read = sqlCom.ExecuteReader();
            TreeViewItem aTV;
            while (read.Read()) {
                aTV = new TreeViewItem();
                aTV.Header = read.GetString(0);
                addItems(aTV);
                treeView.Items.Add(aTV);
            }
            connection.Close();
        }

        public MainWindow()
        {
            InitializeComponent();
            updateTree();
        }

        private void create_Click(object sender, RoutedEventArgs e)
        {
            Create c = new Create();
            if (c.ShowDialog() == true) {
                TreeViewItem newT = new TreeViewItem();
                string name = c.createText.Text;
                newT.Header = name;
                treeView.Items.Add(newT);
                c.Close();
                workBD.insertDB(name, 0);
            }
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            if (treeView.SelectedItem != null)
            {
                AddNote c = new AddNote();
                if (c.ShowDialog() == true)
                {
                    TreeViewItem newT = new TreeViewItem();
                    TreeViewItem t = (TreeViewItem)treeView.SelectedItem;
                    string name_note = $"{c.nameT.Text} | {c.IPT.Text} | {c.MACT.Text} | {c.TypeT.Text}";
                    int id_in = workBD.getIDin(t, "ID");
                    newT.Header = name_note;
                    t.Items.Add(newT);
                    c.Close();
                    workBD.insertDB(c.nameT.Text, c.IPT.Text, c.MACT.Text, c.TypeT.Text, c.StateT.Text, c.AdresT.Text, c.NoteT.Text, name_note, id_in);
                }
            }
        }

        private void edit_Click(object sender, RoutedEventArgs e)
        {
            if (treeView.SelectedItem != null)
            {
                TreeViewItem t = (TreeViewItem)treeView.SelectedItem;
                if (workBD.getIDin(t, "ID_in_item") != 0)
                {
                    Update c = new Update(t.Header.ToString());
                    if (c.ShowDialog() == true)
                    {
                        string name_note = $"{c.nameT.Text} | {c.IPT.Text} | {c.MACT.Text} | {c.TypeT.Text}";
                        workBD.updateDB(c.nameT.Text, c.IPT.Text, c.MACT.Text, c.TypeT.Text, c.StateT.Text, c.AdresT.Text, c.NoteT.Text, name_note, t.Header.ToString());
                        c.Close();
                        t.Header = name_note;
                    }
                }
                else { }
            }
        }

        private void table_Click(object sender, RoutedEventArgs e)
        {
            Table w = new Table();
            w.Show();
        }

        private void delete_Click(object sender, RoutedEventArgs e)
        {
            if (treeView.SelectedItem != null)
            {
                TreeViewItem t = (TreeViewItem)treeView.SelectedItem;
                if (t.HasItems) MessageBox.Show("Этот элемент не пустой", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
                else
                {
                    workBD.delete(t);
                    treeView.Items.Clear();
                    updateTree();
                }
            }
        }

        void serchItem(string text, TreeViewItem serch)
        {
            foreach (TreeViewItem item in serch.Items)
            {
                if (item.Header.ToString().Contains(searchText.Text))
                {
                    item.IsSelected = true;
                }
                serchItem(text, item);
            }
        }
        void serchItem2(string text)
        {
            foreach (TreeViewItem item in treeView.Items)
            {
                if (item.Header.ToString().Contains(searchText.Text))
                {
                    item.IsSelected = true;
                }
                else
                {
                    serchItem(text, item);
                }
            }
        }
        private void search_Click(object sender, RoutedEventArgs e)
        {
            serchItem2(searchText.Text);
        }
    }
}
