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
using System.Windows.Shapes;

namespace Group_2_Final_Project
{
    /// <summary>
    /// Interaction logic for Administration.xaml
    /// </summary>
    public partial class Administration : Window
    {
        public Administration()
        {
            InitializeComponent();
        }
        private void btnReturn_Click(object sender, RoutedEventArgs e)
        {
            Homepage homepage = new Homepage();
            homepage.Show();
            this.Close();
        }

        public static string MugP = "";
        public static string ShirtP = "";
        public static string SingleP = "";
        public static string DoubleP = "";
        public static string CappP = "";
        public static string LatteP = "";


        private void BtnSubmit_Click(object sender, RoutedEventArgs e)
        {
            //fields
            double NewPrice;
            int AddQuantity;




            //validate price
            if (!double.TryParse(txtNewPrice.Text, out NewPrice))
            {
                lblPriceConfirmation.Content = Brushes.Red;
                lblPriceConfirmation.Content = "Input must be a positive price.";
                return;
            }
            else if (NewPrice <= 0)
            {
                lblPriceConfirmation.Content = Brushes.Red;
                lblPriceConfirmation.Content = "Input must be a positive price.";
                return;
            }

            lblPriceConfirmation.Content = "";

            //validate restock amount
            if (!int.TryParse(txtAddQuantity.Text, out AddQuantity))
            {
                lblRestockConfirmation.Content = Brushes.Red;
                lblRestockConfirmation.Content = "Amount input must be a positive number 1 and 200.";
                return;
            }
            else if (AddQuantity < 1 || AddQuantity > 200)
            {
                lblRestockConfirmation.Content = Brushes.Red;
                lblRestockConfirmation.Content = "Amount input must be a positive number 1 and 200.";
                return;
            }

            lblRestockConfirmation.Content = "";


            //create instance?
            //restock
            ComboBoxItem cbiSelectedItem = (ComboBoxItem)cboProductRestock.SelectedItem;
            string listitem = cbiSelectedItem.Content.ToString();

            if (listitem == "Dunkin Beans")
            {
                AddQuantity = Convert.ToInt32(txtAddQuantity.Text);
                lblRestockConfirmation.Content = "yyyy";
                Product.Espresso prod1 = new Product.Espresso();
               


            }
            else if (listitem == "Mug")
            {
                AddQuantity = Convert.ToInt32(txtAddQuantity.Text);
                lblRestockConfirmation.Content = "yyyy";
                Product.Merchandise prod1 = new Product.Merchandise();
                


            }
            else if (listitem == "Shirt")
            {
                AddQuantity = Convert.ToInt32(txtAddQuantity.Text);
                lblRestockConfirmation.Content = "yyyy";
                Product.Merchandise prod1 = new Product.Merchandise();
                

            }
            else if (listitem == "Milk")
            {
                AddQuantity = Convert.ToInt32(txtAddQuantity.Text);
                lblRestockConfirmation.Content = "yyyy";
                Product.MilkBase prod1 = new Product.MilkBase();
                
            }
            else if (listitem == "Syrup")
            {
                AddQuantity = Convert.ToInt32(txtAddQuantity.Text);
                lblRestockConfirmation.Content = "yyyy";
                Product.MilkBase prod1 = new Product.MilkBase();
               
            }
            else if (listitem == "Colombian")
            {
                AddQuantity = Convert.ToInt32(txtAddQuantity.Text);
                lblRestockConfirmation.Content = "yyyy";
                Product.MilkBase prod1 = new Product.MilkBase();
                
            }
            else
            {
                lblRestockConfirmation.Content = "xxxxxx";
            }

            //change price

            ComboBoxItem cbiSelectedPriceItem = (ComboBoxItem)cboProductPrice.SelectedItem;
            string priceitem = cbiSelectedPriceItem.Content.ToString();

            if (priceitem == "Mug")
            {
                NewPrice = Convert.ToDouble(txtNewPrice.Text);
                lblPriceConfirmation.Content = "yyyy";
                Product.Merchandise prod1 = new Product.Merchandise();
                MainWindow mainWindow = new MainWindow();
                MugP = prod1.ChangePrice(NewPrice).ToString();
                mainWindow.lblMugPrice.Content = prod1.ChangePrice(NewPrice).ToString("0.00");
                mainWindow.Show();
                

            }
            else if (priceitem == "Shirt")
            {
                NewPrice = Convert.ToDouble(txtNewPrice.Text);
                lblPriceConfirmation.Content = "yyyy";
                Product.Merchandise prod1 = new Product.Merchandise();
                MainWindow mainWindow = new MainWindow();
                ShirtP = prod1.ChangePrice(NewPrice).ToString();
                mainWindow.lblShirtPrice.Content = prod1.ChangePrice(NewPrice).ToString("0.00");
                mainWindow.Show();

            }

            else if (priceitem == "Single Espresso")
            {
                NewPrice = Convert.ToDouble(txtNewPrice.Text);
                lblPriceConfirmation.Content = "yyyy";
                Product.Espresso prod1 = new Product.Espresso();
                MainWindow mainWindow = new MainWindow();
                SingleP = prod1.ChangePrice(NewPrice).ToString();
                mainWindow.lblSinglePrice.Content = prod1.ChangePrice(NewPrice).ToString("0.00");
                mainWindow.Show();
            }
            else if (priceitem == "Double Espresso")
            {
                NewPrice = Convert.ToDouble(txtNewPrice.Text);
                lblPriceConfirmation.Content = "yyyy";
                Product.Espresso prod1 = new Product.Espresso();
                MainWindow mainWindow = new MainWindow();
                DoubleP = prod1.ChangePrice(NewPrice).ToString();
                mainWindow.lblDoublePrice.Content = prod1.ChangePrice(NewPrice).ToString("0.00");
                mainWindow.Show();
            }
            else if (priceitem == "Latte")
            {
                NewPrice = Convert.ToDouble(txtNewPrice.Text);
                lblPriceConfirmation.Content = "yyyy";
                Product.MilkBase prod1 = new Product.MilkBase();
                MainWindow mainWindow = new MainWindow();
                LatteP = prod1.ChangePrice(NewPrice).ToString();
                mainWindow.lblLattePrice.Content = prod1.ChangePrice(NewPrice).ToString("0.00");
                mainWindow.Show();

            }
            else if (priceitem == "Cappucino")
            {
                NewPrice = Convert.ToDouble(txtNewPrice.Text);
                lblPriceConfirmation.Content = "yyyy";
                Product.MilkBase prod1 = new Product.MilkBase();
                MainWindow mainWindow = new MainWindow();
                CappP = prod1.ChangePrice(NewPrice).ToString();
                mainWindow.lblCappPrice.Content = prod1.ChangePrice(NewPrice).ToString("0.00");
                mainWindow.Show();
            }
            else
            {
                lblPriceConfirmation.Content = "xxxxxx";
            }
        }
           
 
        
                   
    }

       
    
}
