using ComputerShop13B.Services;
using System.Windows.Controls;

namespace ComputerShop13B
{
    /// <summary>
    /// Interaction logic for UsersDataGrid.xaml
    /// </summary>
    public partial class UsersDataGrid : Page
    {
        IDatabase database = new Users();
        public UsersDataGrid()
        {
            InitializeComponent();
            usersDataGrid.ItemsSource = database.GetAllData();

        }
    }
}
