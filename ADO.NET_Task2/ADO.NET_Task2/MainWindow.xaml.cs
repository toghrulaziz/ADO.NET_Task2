using ADO.NET_Task2.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ADO.NET_Task2.Models.Concretes;

namespace ADO.NET_Task2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            LibraryContext context = new();

            var authors = context.Authors.ToList();

            foreach (var item in authors)
            {
                AuthorComboBox.Items.Add(item.FirstName);
            }


            var categories = context.Categories.ToList();

            foreach (var item in categories)
            {
                CategoriesComboBox.Items.Add(item.Name);
            }
        }

        private void AuthorComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string? selectedAuthor = AuthorComboBox.SelectedItem.ToString();

            using (var context = new LibraryContext())
            {
                var query = from book in context.Books
                            join author in context.Authors on book.Id_Author equals author.Id
                            where author.FirstName == selectedAuthor
                            select book.Name;

                BooksListBox.Items.Clear();
                foreach (var bookName in query)
                {
                    BooksListBox.Items.Add(bookName);
                }
            }
        }

        private void CategoriesComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string? selectedCategory = CategoriesComboBox.SelectedItem.ToString();

            using (var context = new LibraryContext())
            {
                var query = from book in context.Books
                            join category in context.Categories on book.Id_Category equals category.Id
                            where category.Name == selectedCategory
                            select book.Name;

                BooksListBox_Categories.Items.Clear();
                foreach (var bookName in query)
                {
                    BooksListBox_Categories.Items.Add(bookName);
                }
            }
        }



    }
}
