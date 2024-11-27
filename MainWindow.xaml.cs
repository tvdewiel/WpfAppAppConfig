using System.Configuration;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfAppAppConfig
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string connectionString;
        public string host;
        public MainWindow()
        {
            InitializeComponent();
            host = ConfigurationManager.AppSettings["host"];
            connectionString = ConfigurationManager.ConnectionStrings[host].ConnectionString;         
            UserTextBox.Text = host;
            ConnTextBox.Text = connectionString;
        }
    }
}