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
    /// Interaction logic for DashboardWindow.xaml
    /// </summary>
    public partial class DashboardWindow : Window
    {
        private readonly LibraryContext _context;
        public DashboardWindow()
        {
            InitializeComponent();
            _context = new LibraryContext();

            FillReport();

        }

        private void BookWindowOpen_Click(object sender, RoutedEventArgs e)
        {
            BooksWindow bw = new BooksWindow();
            bw.ShowDialog();
        }

        private void BtnCustomer_Click(object sender, RoutedEventArgs e)
        {
            CustomerWindow cw = new CustomerWindow();
            cw.ShowDialog();
        }

        private void BtnManegerWindowsOpen_Click(object sender, RoutedEventArgs e)
        {
            ManegerWindow mw = new ManegerWindow();
            mw.ShowDialog();
        }

        private void BtnCreateOrder_Click(object sender, RoutedEventArgs e)
        {
            AddOrderWindows ow = new AddOrderWindows();
            ow.ShowDialog();
        }

        private void BtbBookBack_Click(object sender, RoutedEventArgs e)
        {
            ReturnBookWindow rb = new ReturnBookWindow();
            rb.ShowDialog();
        }

        private void FillReport()
        {
            DgvToday.ItemsSource = _context.Report.Include(r => r.Customer)
                     .Where(r => r.endDay.Month == DateTime.Now.Month && r.endDay.Day == DateTime.Now.Day && r.endDay.Year == DateTime.Now.Year).ToList();
           
            DgvTomorrow.ItemsSource = _context.Report.Include(r => r.Customer)
                 .Where(r => r.endDay.Month == DateTime.Now.AddDays(1).Month && r.endDay.Day == DateTime.Now.AddDays(1).Day && r.endDay.Year == DateTime.Now.AddDays(1).Year).ToList();
           
            DgvLate.ItemsSource = _context.Report.Include(r => r.Customer)
               .Where(r => r.endDay < DateTime.Now.AddDays(-1)).ToList();

        }

        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {


            FillReport();
        }
    }
}
