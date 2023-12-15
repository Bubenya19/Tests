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

namespace Tests.Pages
{
    /// <summary>
    /// Логика взаимодействия для HomePage.xaml
    /// </summary>
    public partial class HomePage : Page
    {
        Connection connection = new Connection();
        OrderController orderController = new OrderController();
        public HomePage()
        {
            InitializeComponent();
            
            // DataContext = connection.auth.Orders;
            
            

        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            var allOrders = orderController.GetOrders();

            LvOrders.ItemsSource = allOrders;
            
        }

        private void LvOrders_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            var order = orderController.CreateNewOrder(idOrder);


            try
            {
                Users users = new Users
                {
                    FirstName = firstname,
                    LastName = lastname,
                    Patronymic = patronymic,
                    DateBirth = datebirth,
                    UserName = username,
                    UserPassword = password,
                    GenderID = genderId,
                    RoleID = 1,
                };

                connection.auth.Users.Add(users);
                connection.auth.SaveChanges();
                return users;


            }
            catch (Exception ex)
            {

                throw new Exception($"{ex.Message}");
            }
        }
    }
}
