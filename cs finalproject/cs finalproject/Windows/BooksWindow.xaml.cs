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
    /// Interaction logic for BooksWindow.xaml
    /// </summary>
    public partial class BooksWindow : Window

    {
        private readonly LibraryContext _context;
        private Books _selectedbook;
        public BooksWindow()
        {
            InitializeComponent();
            _context = new LibraryContext();
            FillBooks();
            Reset();
           

        }

        private void FillBooks()
        {
            DgvBooks.ItemsSource = _context.Books.ToList();
        }

        private void Reset()
        {
            TxtBookName.Clear();
            TxtBookPrice.Clear();
            FillBooks();
        }
        

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(TxtBookName.Text))
            {
                MessageBox.Show("Kitab adi bosdur.");
                return;

            }else if (string.IsNullOrEmpty(TxtBookPrice.Text))
            {
                MessageBox.Show("Qiymet yazilmayib.");
                return;
            }
            else
            { Books book = new Books
            {
                Name = TxtBookName.Text,
                Price = TxtBookPrice.Text
            };
            _context.Books.Add(book);
            _context.SaveChanges();
            Reset();
            MessageBox.Show("Kitab əlavə olundu");
        }}

        private void BtnUpdate_Click(object sender, RoutedEventArgs e)
        {
            _selectedbook.Name = TxtBookName.Text;
            _selectedbook.Price = TxtBookPrice.Text;
            _context.SaveChanges();
            Reset();
            MessageBox.Show("Kitab yenilendi.");
            BtnAdd.Visibility = Visibility.Visible;
            BtnSearch.Visibility = Visibility.Visible;
            BtnDelete.Visibility = Visibility.Visible;
            BtnUpdate.Visibility = Visibility.Visible;


        }

        private void DgvBooks_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DgvBooks.SelectedItem == null) return;


            _selectedbook = (Books)DgvBooks.SelectedItem;

            TxtBookName.Text = _selectedbook.Name;
            TxtBookPrice.Text = _selectedbook.Price;

            BtnAdd.Visibility = Visibility.Hidden;
            BtnSearch.Visibility = Visibility.Hidden;
            BtnDelete.Visibility = Visibility.Visible;
            BtnUpdate.Visibility = Visibility.Visible;


        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult r = MessageBox.Show("Silmeye eminsinizmi?", _selectedbook.ToString(), MessageBoxButton.OKCancel);
            if (r == MessageBoxResult.OK)
            {
                _context.Books.Remove(_selectedbook);
                _context.SaveChanges();
                Reset();
                MessageBox.Show("Kitab silindi.");
            }


        }

        private void BtnSearch_Click(object sender, RoutedEventArgs e)
        {
            Books book = _context.Books
                        .Where(b => b.Name.ToLower().Contains(TxtBookName.Text.ToLower()))
                        .FirstOrDefault();
            if (book == null)
            {
                book = _context.Books
                           .Where(b => b.Price.ToString().Contains(TxtBookPrice.Text))
                           .FirstOrDefault();
                if(book == null)
                {
                    MessageBox.Show(" Qeyd etdiyiniz kitab tapilmadi");
                    Reset();
                }
            }
            else
            {
                MessageBox.Show("Istediyiniz kitab tapildi.");
                FillBooks();
                Reset();
            }
        }
    }

}
