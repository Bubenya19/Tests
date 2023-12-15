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
using Tests.model;
using Tests.Pages;

namespace Tests.Pages
{
    /// <summary>
    /// Логика взаимодействия для Auth.xaml
    /// </summary>
    public partial class Auth : Page
    {
        
        UserConroller conroller = new UserConroller();  
        public Auth()
        {
            InitializeComponent();
        }

        private void BtAuth_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(TBoxUserName.Text) && !String.IsNullOrEmpty(PBoxPassword.Password))
                {
                    var user = conroller.SignIn(TBoxUserName.Text.Trim(), PBoxPassword.Password.Trim());
                    App.currentUser = user;
                    this.NavigationService.Navigate(new HomePage());
                }
                else
                {
                    MessageBox.Show("Не все поля заполнены", "Поля не заполнены", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("User not found", "System error", MessageBoxButton.OK, MessageBoxImage.Error);

            }
        }
    }
}
