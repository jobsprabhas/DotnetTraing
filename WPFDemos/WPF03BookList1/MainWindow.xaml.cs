﻿using ConceptArchitect.BooksApi;
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

namespace WPF03BookList
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

       

        private void handleShowBookDetail(object sender, RoutedEventArgs e)
        {
            
            var book = booklist.selecteditem as book;
            if (book != null)
                messagebox.show(book.tostring(), "selected book", messageboxbutton.ok, messageboximage.information);

            if (book == null)
               // messagebox.show("please select a book first", "no book selected", messageboxbutton.ok, messageboximage.warning);
            titletext.text = book.title;
            authortext.text = book.author;
            pricetext.text = "₹ " + book.price;
        }
    }
}