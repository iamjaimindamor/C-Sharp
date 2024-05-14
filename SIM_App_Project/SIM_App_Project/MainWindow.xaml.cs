using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Controls;

namespace SIM_App_Project
{
    public partial class MainWindow : Window
    {
        private bool delFlag = false;
        private static string conString = ConfigurationManager.ConnectionStrings["SIM_App_Project.Properties.Settings.StoreManagementConnectionString"].ConnectionString;
        private SqlConnection sqlConnection1 = new SqlConnection(conString);

        public MainWindow()
        {
            InitializeComponent();
            DisplayStores();
            DisplayProducts();
        }

        private void DisplayStores()
        {
            string query = "select * from Stores";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, conString);
            DataTable storeTable = new DataTable();
            sqlDataAdapter.Fill(storeTable);
            storeList.DisplayMemberPath = "Store Name";
            storeList.SelectedValuePath = "Id";
            storeList.ItemsSource = storeTable.DefaultView;
        }

        private void DisplayStoreInventory()
        {
            SqlConnection sqlConnection = new SqlConnection(conString);
            string query = "select * from Product p inner join StoreInventory si on p.Id = si.Product_ID where si.Store_ID = @Id";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            sqlCommand.Parameters.AddWithValue("Id", storeList.SelectedValue);
            DataTable storeInventoryTable = new DataTable();
            sqlDataAdapter.Fill(storeInventoryTable);
            inventoryList.ItemsSource = storeInventoryTable.DefaultView;
            inventoryList.SelectedValuePath = "Id";
            inventoryList.DisplayMemberPath = "Product Brand";
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        { }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (delFlag == false)
            {
                DisplayStoreInventory();
                try
                {
                    StoreSelection.Text = storeList.SelectedValue.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            delFlag = false;
        }

        private void DisplayProducts()
        {
            string query = "select * from Product";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, conString);
            DataTable productTable = new DataTable();
            sqlDataAdapter.Fill(productTable);
            productList.DisplayMemberPath = "Product Name";
            productList.SelectedValuePath = "Id";
            productList.ItemsSource = productTable.DefaultView;
        }

        private void inventoryList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }

        private void AddStore_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(conString);
                sqlConnection.Open();

                string naam = storename.Text;
                Console.WriteLine(naam);
                string pata = storeStreet.Text;
                Console.WriteLine(pata);
                string sheher = storeCity.Text;
                Console.WriteLine(sheher);
                string stat = storeState.Text;
                Console.WriteLine(stat);
                string comcon = storeContact.Text;
                Console.WriteLine(comcon);

                string qr = "INSERT INTO Stores ([Store Name], [Store Address], City, State, Contact) VALUES (@storename, @storeStreet, @storeCity, @storeState, @storeContact)";

                SqlCommand sqlCommand = new SqlCommand(qr, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@storename", naam);
                sqlCommand.Parameters.AddWithValue("@storeStreet", pata);
                sqlCommand.Parameters.AddWithValue("@storeCity", sheher);
                sqlCommand.Parameters.AddWithValue("@storeState", stat);
                sqlCommand.Parameters.AddWithValue("@storeContact", comcon);
                sqlCommand.ExecuteNonQuery();

                MessageBox.Show("SUCCESSFUL ENTRY!!");

                DisplayStores();

                sqlConnection.Close(); // Close the connection after use
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void DeleteStore_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(conString);
            sqlConnection.Open();

            string deleteQRY = "delete from Stores where Id =@id;";

            SqlCommand command = new SqlCommand(deleteQRY, sqlConnection);
            command.Parameters.AddWithValue("id", storeList.SelectedValue);
            command.ExecuteScalar();

            MessageBox.Show("Entry Deleted");
            delFlag = true;
            DisplayStores();
        }

        private void InventoryAdd_Click(object sender, RoutedEventArgs e)
        {
            int store, prod;
            try
            {
                SqlConnection sqlConnection1 = new SqlConnection(conString);
                sqlConnection1.Open();
                store = int.Parse(StoreSelection.Text);
                prod = int.Parse(ProductSelection.Text);

                string query = "insert into StoreInventory values (@stores,@prods)";

                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection1);
                sqlCommand.Parameters.AddWithValue("stores", store);
                sqlCommand.Parameters.AddWithValue("prods", prod);
                sqlCommand.ExecuteNonQuery();

                MessageBox.Show("Inventory Replenished");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlConnection1.Close();
                DisplayStoreInventory();
            }
        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }

        private void StoreSelection_TextChanged(object sender, TextChangedEventArgs e)
        {
        }

        private void AddProd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(conString);
                sqlConnection.Open();
                string prodname1 = newprod.Text;
                Console.WriteLine(prodname1);
                string prodbrand1 = newbrand.Text;
                Console.WriteLine(prodbrand1);
                string str = "insert into Product ([Product Brand],[Product Name]) values (@brand,@name);";

                SqlCommand sqlCommand = new SqlCommand(str, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@name", prodname1);
                sqlCommand.Parameters.AddWithValue("@brand", prodbrand1);
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Product Added");
                delFlag = true;
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                DisplayProducts();
            }
        }

        private void DelProd_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(conString);
            sqlConnection.Open();

            string delqry = "delete from Product where Id = @id;";

            SqlCommand sqlCommand = new SqlCommand(delqry, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@id", productList.SelectedValue);
            sqlCommand.ExecuteNonQuery();

            MessageBox.Show("Product Deleted");
            sqlConnection.Close();
            delFlag = true;
            DisplayProducts();
        }

        private void productList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (delFlag == false)
            {
                ProductSelection.Text = productList.SelectedValue.ToString();
            }
            delFlag = false;
        }

        private void InventoryDelete_Click(object sender, RoutedEventArgs e)
        {
            try
            {   int val1 = int.Parse(inventoryList.SelectedValue.ToString());
                SqlConnection sqlConnection2 = new SqlConnection(conString);
                sqlConnection2.Open();

                string delquery2 = "delete from StoreInventory where Id =@id2;";

                SqlCommand sqlCommand = new SqlCommand(delquery2,sqlConnection2);
                sqlCommand.Parameters.AddWithValue("id2", val1);
                sqlCommand.ExecuteNonQuery();
                
                MessageBox.Show("Delete Successful");
                delFlag = true;
                sqlConnection2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                DisplayStoreInventory();

            }
        }
    }
}