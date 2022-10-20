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
using System.Windows.Shapes;

namespace Contacts_Desktop_Application
{
    /// <summary>
    /// Interaction logic for AddNewContactWindow.xaml
    /// </summary>
    public partial class AddNewContactWindow : Window
    {
        public AddNewContactWindow()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, RoutedEventArgs e)
        {
            Contact contact = new Contact()
            {
                FirstName = FirstnameTextBox.Text,
                LastName = LastnameTextBox.Text,
                Email = emailTextBox.Text,
                Phone = phoneTextBox.Text,
                DateCreated = DateTime.Now,
            };

            


            using (SQLiteConnection connection = new SQLiteConnection(App.databasePath)) {

                connection.CreateTable<Contact>();
                connection.Insert(contact);

            };
                
            

            Close();
        }
    }
}
