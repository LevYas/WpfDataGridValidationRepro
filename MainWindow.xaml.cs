using System.Windows;

namespace WpfDataGridValidationRepro
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            DataContext = new MainWindowVm();
        }
    }
}
