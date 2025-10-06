using ComputerShop13B.Services;
using System.Data;
using System.Windows;
using System.Windows.Controls;

namespace ComputerShop13B
{
    /// <summary>
    /// Interaction logic for UsersDataGrid.xaml
    /// </summary>
    public partial class UsersDataGrid : Page
    {
        MainWindow _mainWindow;
        IDatabase database = new Users();
        public UsersDataGrid(MainWindow mainWindow)
        {
            InitializeComponent();
            usersDataGrid.ItemsSource = database.GetAllData();
            _mainWindow = mainWindow;
        }

        private void deleteUserButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            if (usersDataGrid.SelectedItem is DataRowView item)
            {
                MessageBox.Show(database.DeleteUser(item["Id"]).ToString());
                usersDataGrid.ItemsSource = database.GetAllData();
            }
        }

        private void updateUserButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {

        }
    }
}
