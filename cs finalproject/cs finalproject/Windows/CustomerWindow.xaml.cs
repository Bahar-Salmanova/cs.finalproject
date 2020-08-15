using cs_finalproject.Data;
using cs_finalproject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
    /// Interaction logic for CustomerWindow.xaml
    /// </summary>
    public partial class CustomerWindow : Window
    {
        private readonly LibraryContext _context;
        private Customer _selectedcustomer;
        public CustomerWindow()
        {
            InitializeComponent();
            _context = new LibraryContext();
            FillCustomer();
        }


        private void FillCustomer()
        {
            DgvCustomer.ItemsSource = _context.Customers.ToList();
        }
        private void Reset()
        {
            TxtCustomerName.Clear();
            TxtCustomerPhone.Clear();
            FillCustomer();
            
           
        }
        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(TxtCustomerName.Text))
            {
                MessageBox.Show("Musteri adi bosdur.");
                return;

            }else if (string.IsNullOrEmpty(TxtCustomerPhone.Text))
            {
                MessageBox.Show("Telefon nomresi yazilmamisdir");
            }
            else
            {
                Customer customer = new Customer
                {
                    Name = TxtCustomerName.Text,
                    Phone = TxtCustomerPhone.Text

                };
                _context.Customers.Add(customer);
                _context.SaveChanges();
                Reset();
                MessageBox.Show("Yeni musteri elave olundu");
            }

        }

        private void BtnUpdate_Click(object sender, RoutedEventArgs e)
        {
            _selectedcustomer.Name = TxtCustomerName.Text;
            _selectedcustomer.Phone = TxtCustomerPhone.Text;
            _context.SaveChanges();
            Reset();
            MessageBox.Show("Musteri yenilendi.");
            BtnCustomerAdd.Visibility = Visibility.Visible;

            BtnCustomerDelete.Visibility = Visibility.Visible;
            BtnCustomerUpdate.Visibility = Visibility.Visible;



        }

        private void DgvCustomer_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DgvCustomer.SelectedItem== null) return;
            _selectedcustomer = (Customer)DgvCustomer.SelectedItem;

            TxtCustomerName.Text = _selectedcustomer.Name;
            TxtCustomerPhone.Text = _selectedcustomer.Phone;


            BtnCustomerAdd.Visibility = Visibility.Hidden;

            BtnCustomerDelete.Visibility = Visibility.Visible;
            BtnCustomerUpdate.Visibility = Visibility.Visible;

        }

        private void BtnCustomerDelete_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult r = MessageBox.Show("Silmeye eminsinizmi?", _selectedcustomer.ToString(), MessageBoxButton.OKCancel);
            if (r == MessageBoxResult.OK)
            {
                _context.Customers.Remove(_selectedcustomer);
                _context.SaveChanges();
                Reset();
                MessageBox.Show("Musteri silindi");
                BtnCustomerAdd.Visibility = Visibility.Visible;

                BtnCustomerDelete.Visibility = Visibility.Visible;
                BtnCustomerUpdate.Visibility = Visibility.Visible;


            }
        }
    }
}
