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
using CAsino.DBConnetion;
using CAsino.ADOApp;

namespace CAsino.Windows
{
    /// <summary>
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void RegistrationBtn_Click(object sender, RoutedEventArgs e)
        {
            var DataLogList = DBConnection.connection.Logins.Where(x => x.Login == LoginTB.Text).FirstOrDefault();
            if (NameTB.Text != null && LoginTB.Text != null && PasswordTB.Text != null)
            {
                try
                {
                    Users NewUser = new Users();
                    NewUser.Name = NameTB.Text;
                    Logins NewLogins = new Logins()
                    {
                        Login = LoginTB.Text,
                        Password = PasswordTB.Text
                    };
                    NewUser.Logins.Add(NewLogins);
                    DBConnection.connection.Users.Add(NewUser);
                    DBConnection.connection.SaveChanges();
                    MessageBox.Show("Регистрация прошла успешно!");
                }
                catch
                {
                    Exception ex;
                }
            }
        }
    }
}
