using ComputerShop13B.Services;
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
    }
}
