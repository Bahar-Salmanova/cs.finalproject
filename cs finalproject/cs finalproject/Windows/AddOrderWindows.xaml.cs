using cs_finalproject.Data;
using cs_finalproject.Model;
using Microsoft.EntityFrameworkCore;
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
    /// Interaction logic for AddOrderWindows.xaml
    /// </summary>
    public partial class AddOrderWindows : Window
    {
        private readonly LibraryContext _context;
        private Report _selectedreport;
        public AddOrderWindows()
        {
            InitializeComponent();
            _context = new LibraryContext();
            FillOrder();
        }

        private void FillOrder()
        {
            DgvOrder.ItemsSource = _context.Report.Include(r=>r.Customer).ToList();
        }
        private void Reset()
        {
            TxtCustomerName.Clear();
            TxtBookName.Clear();
            TxtManegerName.Clear();
            FillOrder();

        }
   private void TxtCustomerName_TextChanged(object sender, TextChangedEventArgs e)
        {
           
        }

        private void BtnNewOrder_Click(object sender, RoutedEventArgs e)
        { 
            Customer customer = _context.Customers
                .Where(c => TxtCustomerName.Text == c.Name).FirstOrDefault();
            Books book = _context.Books
                .Where(b => TxtBookName.Text == b.Name).FirstOrDefault();
            Maneger maneger = _context.Manegers
                .Where(m => TxtManegerName.Text == m.Name).FirstOrDefault();
            if (customer == null)
            {
                MessageBox.Show("Istifadeci adi tapilmadi");
            }
            else if (book == null)
            {
                MessageBox.Show("Kitab tapilmadi.");
            }
            else if (maneger == null)
            {
                MessageBox.Show("Yazdiginiz adli idareci movcud deyil");
            }
            else
            {
                
                Report report = new Report
                {
                    BookId = book.Id,
                   CustomerId = customer.Id,
                    ManegerId = maneger.Id,
                    endDay = (DateTime)DtpEndDay.SelectedDate,
                    startDay=(DateTime)DtpStartDay.SelectedDate,
                    //startDay = DateTime.Now
                };
                
                _context.Report.Add(report);
                _context.SaveChanges();
               
                Reset();
                MessageBox.Show("Sifaris qeyd olundu");

            }
        }

        

        private void DgvOrder_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {if (DgvOrder.SelectedItem == null) return;
            _selectedreport = (Report)DgvOrder.SelectedItem;
            TxtCustomerName.Text = _selectedreport.Customer.Name;
            TxtBookName.Text = _selectedreport.BookId.ToString();
            TxtManegerName.Text = _selectedreport.ManegerId.ToString();
            DtpStartDay.SelectedDate = _selectedreport.startDay;
            DtpEndDay.SelectedDate = _selectedreport.endDay;
        }

        private void BtnOrderUpdates_Click(object sender, RoutedEventArgs e)
        {
            FillOrder();
        }
    }
}
