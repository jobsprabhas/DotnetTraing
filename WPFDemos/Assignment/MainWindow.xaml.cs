using ConceptArchitect.BooksApi;
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

        private void handleNew(object sender, RoutedEventArgs e)
        {

            if (titleText.Text != "" && authorText.Text != "" && priceText.Text != "")
            {
                cmd = new SqlCommand("insert into tbl_Record(Name,State) values(@name,@state)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@name", titleText.Text);
                cmd.Parameters.AddWithValue("@state", authorText.Text);
                cmd.Parameters.AddWithValue("@state", priceText.Text
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Inserted Successfully");
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please Provide Details!");
            }

        }

        private void hadnleEdit(object sender, RoutedEvent e)
        {
            if (titleText.Text != "" && authorText.Text != "" && priceText.Text != "")
            {
                cmd = new SqlCommand("update tbl_Record set Name=@name,State=@state where ID=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", ID);
                cmd.Parameters.AddWithValue("@name", titleText.Text);
                cmd.Parameters.AddWithValue("@state", authorText.Text);
                cmd.Parameters.AddWithValue("@state", priceText.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Updated Successfully");
                con.Close();
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please Select Record to Update");
            }

        }
        private void handlenext(object sender ,RoutedEvent e)
        {


        }
        private void handlPerivoious(object sender, RoutedEvent e)
        {


        }

        private void HandleDelete(object sender, RoutedEvent e)
        {
            if (ID != 0)
            {
                cmd = new SqlCommand("delete tbl_Record where ID=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", ID);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Deleted Successfully!");
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please Select Record to Delete");
            }
        }

    }
       

      

        private void handleShowBookDetail(object sender, RoutedEventArgs e)
        {
            var book = bookList.SelectedItem as Book;
            //if(book!=null)
            //    MessageBox.Show(book.ToString(), "Selected Book", MessageBoxButton.OK, MessageBoxImage.Information);

            //if (book == null)
            //    MessageBox.Show("Please Select a Book First", "No Book Selected", MessageBoxButton.OK, MessageBoxImage.Warning);
            titleText.Text = book.Title;
            authorText.Text = book.Author;
            priceText.Text = "₹ " + book.Price;
        }
}
