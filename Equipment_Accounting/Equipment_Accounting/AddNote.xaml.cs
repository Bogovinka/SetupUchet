using System;
using System.Collections.Generic;
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
    /// Логика взаимодействия для AddNote.xaml
    /// </summary>
    public partial class AddNote : Window
    {
        WorkBD workBD = new WorkBD();
        public AddNote()
        {
            InitializeComponent();
        }

        private void createB_Click(object sender, RoutedEventArgs e)
        {
            if (nameT.Text.Length > 0 && IPT.Text.Length > 0 && MACT.Text.Length > 0 && workBD.testSearch("IP", IPT.Text))
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
