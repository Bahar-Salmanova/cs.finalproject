using cs_finalproject.Data;
using cs_finalproject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace cs_finalproject.Windows
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        private readonly LibraryContext _context;
        public LoginWindow()
        {
            InitializeComponent();
            _context = new LibraryContext();
           
        }

       

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            if (PasswordBox.Password == "admin" && TxtName.Text == "admin")
            {
                DashboardWindow dw = new DashboardWindow();
                dw.ShowDialog();
                return;
            }
            Maneger maneger = _context.Manegers
                .Where(m => m.Name == TxtName.Text && m.Password == PasswordBox.Password).FirstOrDefault();
            if (maneger == null)
            {
                MessageBox.Show("Istifadeci adi ve ya sifre yalnisdir.");
            }
            else
            {
                DashboardWindow dw = new DashboardWindow();
                    dw.ShowDialog();
            }
        }
        
    }
}
