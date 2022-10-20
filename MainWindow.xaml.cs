using Contacts_Desktop_Application.Models;
using SQLite;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Contacts_Desktop_Application
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ReadFromDatabase();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            AddNewContactWindow addContact = new AddNewContactWindow();
            addContact.ShowDialog();
            ReadFromDatabase();
        }

        void ReadFromDatabase()
        {
            using(SQLiteConnection conn = new SQLiteConnection(App.databasePath))
            {
                conn.CreateTable<Contact>();
                List<Contact> content = conn.Table<Contact>().ToList();
            }
        }
    }
}
