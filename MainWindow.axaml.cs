using Avalonia.Controls;
using Avalonia.Interactivity;

namespace AvaloniaApplication3
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_reg(object sender, RoutedEventArgs e)
        {
            Window1 anya = new Window1();
            anya.Login1.Text = Login.Text;
            anya.first_name1.Text = first_name.Text;
            anya.last_name1.Text = last_name.Text;
            anya.email1.Text = email.Text;
            anya.Show();
        }
    }
}