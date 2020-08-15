using cs_finalproject.Data;
using cs_finalproject.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
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
    /// Interaction logic for ReturnBookWindow.xaml
    /// </summary>
    public partial class ReturnBookWindow : Window
    {
        private readonly LibraryContext _context;
        private Report _selectedreport;
        
        public ReturnBookWindow()
        {
            InitializeComponent();
            _context = new LibraryContext();
        }
        

        private void BtnSearchReturnCustomer_Click(object sender, RoutedEventArgs e)
        {
            //Books book = _context.Books
            //       .Where(b => b.Id == book.Id).Include(b => book.Name).FirstOrDefault();
            Customer customer = _context.Customers
                .Where(c => TxtReturnCustomerName.Text == c.Name).FirstOrDefault();
            
            if (customer == null)
            {
                MessageBox.Show("Yazdiginiz adda musteri movcud deyil. ");
            }
            else
            {
                Report report = _context.Report.Where(r => r.CustomerId == customer.Id)
                    .Include(report => report.Customer).FirstOrDefault();
                
                _selectedreport = report;

                LblCustomerName.Content = customer.Name;

                //LblBookName.Content = report.Books.Name;
                //LblManegerName.Content = _selectedreport.Maneger.Name;
                LblEndDay.Content = _selectedreport.endDay.ToShortDateString();
               
                LblStartDay.Content = _selectedreport.startDay.ToShortDateString();
 
                if (report.endDay.DayOfYear >= DateTime.Now.DayOfYear)
                {
                  LblFind.Content= "Hec bir cerimesi yoxdur";
                }
                else
                {
                    var day =  DateTime.Now.DayOfYear- report.endDay.DayOfYear;
                    var fine = day * 0.5;
                    LblFind.Content = fine+"C";
                }
              

                
            //   _context.Report.Remove(report);
            //_context.SaveChanges();
            //MessageBox.Show("qaytarildi");

            }
                
        }

        private void Reset()
        {
            TxtReturnCustomerName.Clear();
            LblCustomerName.Content = null;
            LblEndDay.Content = null;
            LblStartDay.Content = null;
            LblManegerName.Content = null;
            LblFind.Content = null;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            MessageBoxResult r = MessageBox.Show("silmeye eminsinizmi?", _selectedreport.ToString(), MessageBoxButton.OKCancel);
            if (r == MessageBoxResult.OK)
            {
                _context.Report.Remove(_selectedreport);
                _context.SaveChanges();
                MessageBox.Show("silindi");
                Reset();
            }
                



        }
    }
}
