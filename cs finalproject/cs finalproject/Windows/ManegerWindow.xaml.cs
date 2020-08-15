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
    /// Interaction logic for ManegerWindow.xaml
    /// </summary>
    public partial class ManegerWindow : Window
    {
        private readonly LibraryContext _context;
        private Maneger _selectedManeger;
        public ManegerWindow()
        {
            InitializeComponent();
            _context = new LibraryContext();
            FillManeger();
            Reset();
        }

        private void FillManeger()
        {
            DgvManeger.ItemsSource = _context.Manegers.ToList();

        }
        private void Reset()
        {
            TxtManegerName.Clear();
            TxtManegerPassword.Clear();

            FillManeger();
        }

        private void BtnManegerAdd_Click(object sender, RoutedEventArgs e)
        {
            string ManegerName = TxtManegerName.Text;
            string Password = TxtManegerPassword.Password;

            if (string.IsNullOrEmpty(ManegerName) || string.IsNullOrEmpty(Password) || Password.Length<7){

                MessageBox.Show("Idareci adi ve ya sifre bos olmamalidir.");

            }
           
            else
            {
                Maneger maneger = new Maneger
                {
                    Name = TxtManegerName.Text,
                    Password = TxtManegerPassword.Password
              };
                _context.Manegers.Add(maneger);
                _context.SaveChanges();
                Reset();
                MessageBox.Show("Yeni idareci elave edildi.");
            }

        }

        private void BtnManegerDelete_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult r = MessageBox.Show("Silmeye eminsinizmi?", _selectedManeger.ToString(), MessageBoxButton.OKCancel);

            if (r == MessageBoxResult.OK)
            {
                _context.Manegers.Remove(_selectedManeger);
                _context.SaveChanges();
                Reset();

                MessageBox.Show("Idareci silindi.");

                BtnManegerAdd.Visibility = Visibility.Visible;

                BtnManegerDelete.Visibility = Visibility.Visible;
                BtnManegerUpdate.Visibility = Visibility.Visible;

            }
        }

        private void DgvManeger_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DgvManeger.SelectedItem == null) return;


            _selectedManeger = (Maneger)DgvManeger.SelectedItem;


            TxtManegerName.Text = _selectedManeger.Name;
            TxtManegerPassword.Password = _selectedManeger.Password;

       }

        private void BtnManegerUpdate_Click(object sender, RoutedEventArgs e)
        {
            _selectedManeger.Name = TxtManegerName.Text;
            _selectedManeger.Password = TxtManegerPassword.Password;
            _context.SaveChanges();
            Reset();
            MessageBox.Show("Deyisiklik qeyd olundu.");
      }
    }
}
