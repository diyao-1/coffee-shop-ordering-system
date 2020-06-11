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

namespace Group_2_Final_Project
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

        private void btnReturn_Click(object sender, RoutedEventArgs e)
        {
            Homepage homepage = new Homepage();
            homepage.Show();
            this.Close();
        }



        //create instance
        Product.Espresso singleespresso = new Product.Espresso();
        Product.Espresso doubleespresso = new Product.Espresso();
        Product.MilkBase cappuccino = new Product.MilkBase();
        Product.MilkBase latte = new Product.MilkBase();
        Product.Merchandise mug = new Product.Merchandise();
        Product.Merchandise shirt = new Product.Merchandise();
       
        List<string> ProductList = new List<string>();
        List<double> PriceList = new List<double>();

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            //Calculate Button
            int quantity;
            //add items to order
            if (ckbSingle.IsChecked.Value)
            {
                if (int.TryParse(txtSingQuan.Text, out quantity))
                {

                    if ((singleespresso.DunkinInventory - Convert.ToInt32(txtSingQuan.Text)) <= 0)
                    {
                        MessageBox.Show("Espresso low in stock.");

                    }
                    else
                    {
                        ProductList.Add("Single Espresso");
                    }
                    
                }
                else
                {
                    MessageBox.Show("Please Enter a Positive Integer.");
                }


            }

            if (ckbDouble.IsChecked.Value)
                {
                    if (int.TryParse(txtDoubQuan.Text, out quantity))
                    {

                        if ((doubleespresso.DunkinInventory - Convert.ToInt32(txtDoubQuan.Text)) <= 0)
                        {
                            MessageBox.Show("Espresso low in stock.");

                        }
                        else
                        {
                            ProductList.Add("Double Espresso");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Please Enter a Positive Integer.");
                    }


                }

                if (ckbCappuccino.IsChecked.Value)
                {
                        if (int.TryParse(txtCapQuan.Text, out quantity))
                        {

                            if ((cappuccino.ColombianInventory - Convert.ToInt32(txtCapQuan.Text)) <= 0)
                            {
                                MessageBox.Show("Colombian Beans low in stock.");

                            }
                            else
                            {
                                ProductList.Add("Cappuccino");
                            }

                        }
                        else
                        {
                            MessageBox.Show("Please Enter a Positive Integer.");
                        }


                    }

                    if (ckbLatte.IsChecked.Value)
            
                        {
                            if (int.TryParse(txtLatteQuan.Text, out quantity))
                            {

                                if ((latte.ColombianInventory - Convert.ToInt32(txtLatteQuan.Text)) <= 0)
                                {
                                    MessageBox.Show("Latte Ingredient low in stock.");

                                }
                                else
                                {
                                    ProductList.Add("Latte");
                                }

                            }
                            else
                            {
                                MessageBox.Show("Please Enter a Positive Integer.");
                            }


                        }
                    

            if (ckbMug.IsChecked.Value)
                    {
                        if (int.TryParse(txtMugQuan.Text, out quantity))
                        {

                            if ((mug.MugInventory - Convert.ToInt32(txtMugQuan.Text)) <= 0)
                            {
                                MessageBox.Show("Mugs low in stock.");

                            }
                            else
                            {
                                ProductList.Add("Mug");
                            }

                        }
                        else
                        {
                            MessageBox.Show("Please Enter a Positive Integer.");
                        }


                    }

                    if (ckbShirt.IsChecked.Value)
                    {
                        if (int.TryParse(txtShirtQuan.Text, out quantity))
                        {

                            if ((shirt.ShirtInventory - Convert.ToInt32(txtShirtQuan.Text)) <= 0)
                            {
                                MessageBox.Show("Shirts low in stock.");

                            }
                            else
                            {
                                ProductList.Add("Shirt");
                            }

                        }
                        else
                        {
                            MessageBox.Show("Please Enter a Positive Integer.");
                        }


                    }

                    //add prices to order
                    if (ckbSingle.IsChecked.Value)
            {
                if (int.TryParse(txtSingQuan.Text, out quantity))
                {
                    if ((singleespresso.DunkinInventory - Convert.ToInt32(txtSingQuan.Text)) <= 0)
                    {
                        txtSingQuan.Background = Brushes.LightPink;


                    }
                    else
                    {
                        PriceList.Add(Convert.ToDouble(2 * Convert.ToInt32(txtSingQuan.Text)));
                    }
                }
                else
                {
                    MessageBox.Show("Please Enter a Positive Integer.");
                }
                              
               
                
            }

            if (ckbDouble.IsChecked.Value)
                    {
                        if (int.TryParse(txtDoubQuan.Text, out quantity))
                        {
                            if ((doubleespresso.DunkinInventory - Convert.ToInt32(txtDoubQuan.Text)) <= 0)
                            {
                                txtDoubQuan.Background = Brushes.LightPink;


                            }
                            else
                            {
                                PriceList.Add(Convert.ToDouble(3 * Convert.ToInt32(txtDoubQuan.Text)));
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please Enter a Positive Integer.");
                        }



                    }

                    if (ckbCappuccino.IsChecked.Value)
                    {
                        if (int.TryParse(txtCapQuan.Text, out quantity))
                        {
                            if ((cappuccino.ColombianInventory - Convert.ToInt32(txtCapQuan.Text)) <= 0)
                            {
                                txtCapQuan.Background = Brushes.LightPink;


                            }
                            else
                            {
                                PriceList.Add(Convert.ToDouble(3.5 * Convert.ToInt32(txtCapQuan.Text)));
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please Enter a Positive Integer.");
                        }



                    }

                    if (ckbLatte.IsChecked.Value)
                    {
                        if (int.TryParse(txtLatteQuan.Text, out quantity))
                        {
                            if ((latte.ColombianInventory - Convert.ToInt32(txtLatteQuan.Text)) <= 0)
                            {
                                txtLatteQuan.Background = Brushes.LightPink;


                            }
                            else
                            {
                                PriceList.Add(Convert.ToDouble(4 * Convert.ToInt32(txtLatteQuan.Text)));
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please Enter a Positive Integer.");
                        }



                    }
                    if (ckbMug.IsChecked.Value)
                    {
                        if (int.TryParse(txtMugQuan.Text, out quantity))
                        {
                            if ((mug.MugInventory - Convert.ToInt32(txtMugQuan.Text)) <= 0)
                            {
                                txtMugQuan.Background = Brushes.LightPink;


                            }
                            else
                            {
                                PriceList.Add(Convert.ToDouble(5 * Convert.ToInt32(txtMugQuan.Text)));
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please Enter a Positive Integer.");
                        }



                    }
                    if (ckbShirt.IsChecked.Value)
                    {
                        if (int.TryParse(txtShirtQuan.Text, out quantity))
                        {
                            if ((shirt.ShirtInventory - Convert.ToInt32(txtShirtQuan.Text)) <= 0)
                            {
                                txtShirtQuan.Background = Brushes.LightPink;


                            }
                            else
                            {
                                PriceList.Add(Convert.ToDouble(10 * Convert.ToInt32(txtShirtQuan.Text)));
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please Enter a Positive Integer.");
                        }



                    }

                    //display order to user
                    for (int i = 0; i < ProductList.Count; i++)
            {
                lstOrderProd.Items.Add(ProductList.ElementAt(i));
            }
            for (int j = 0; j < PriceList.Count; j++)
            {
                lstOrderPrice.Items.Add(PriceList.ElementAt(j).ToString("C0"));
            }

            //display subtotal and total to user
            Order order = new Order(ckbTogo.IsChecked.Value);

            lblSubtotal.Content = order.GetSubtotal(PriceList).ToString("C0");
            lblTotal.Content = order.GetTotal().ToString("C0");

        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            ckbCappuccino.IsChecked = false;
            ckbDouble.IsChecked = false;
            ckbLatte.IsChecked = false;
            ckbMug.IsChecked = false;
            ckbShirt.IsChecked = false;
            ckbSingle.IsChecked = false;
            lstOrderProd.Items.Clear();
            lstOrderPrice.Items.Clear();
            lblSubtotal.Content = "";
            lblTotal.Content = "";
            txtSingQuan.Text = "";
            txtSingQuan.Background = Brushes.White;
            txtDoubQuan.Text = "";
            txtDoubQuan.Background = Brushes.White;
            txtCapQuan.Text = "";
            txtCapQuan.Background = Brushes.White;
            txtLatteQuan.Text = "";
            txtLatteQuan.Background = Brushes.White;
            txtMugQuan.Text = "";
            txtMugQuan.Background = Brushes.White;
            txtShirtQuan.Text = "";
            txtShirtQuan.Background = Brushes.White;
            lstCheck.Items.Clear();
        }
        
        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            if (ckbTogo.IsChecked == true)
            {
                MessageBox.Show("Your ToGo Order is being prepared.");
            }
            else
            { MessageBox.Show("Your Order is being prepared."); }

            if (ckbSingle.IsChecked.Value)
            {
                
                singleespresso.DunkinInventory = singleespresso.DunkinInventory - 1 * Convert.ToInt32(txtSingQuan.Text);

            }

            if (ckbDouble.IsChecked.Value)
            {
                
                doubleespresso.DunkinInventory = doubleespresso.DunkinInventory - 2 * Convert.ToInt32(txtDoubQuan.Text);

            }

            if (ckbCappuccino.IsChecked.Value)
            {
                
                cappuccino.ColombianInventory = cappuccino.ColombianInventory - 1 * Convert.ToInt32(txtCapQuan.Text);
                cappuccino.MilkInventory = cappuccino.MilkInventory - 1 * Convert.ToInt32(txtCapQuan.Text);
                cappuccino.SyrupInventory = cappuccino.SyrupInventory - 1 * Convert.ToInt32(txtCapQuan.Text);

            }

            if (ckbLatte.IsChecked.Value)
            {
                
                latte.ColombianInventory = latte.ColombianInventory - 1 * Convert.ToInt32(txtLatteQuan.Text);
                latte.MilkInventory = latte.MilkInventory - 1 * Convert.ToInt32(txtLatteQuan.Text);
            }

            if (ckbMug.IsChecked.Value)
            {
                
                mug.MugInventory = mug.MugInventory - 1 * Convert.ToInt32(txtMugQuan.Text);
            }

            if (ckbShirt.IsChecked.Value)
            {
                
                shirt.MugInventory = shirt.MugInventory - 1 * Convert.ToInt32(txtShirtQuan.Text);
            }


        }

        private void btnCheck_Click(object sender, RoutedEventArgs e)
        {
            lstCheck.Items.Add("Dunkin" + " " + "Inventory:" + " "+ singleespresso.DunkinInventory);
            lstCheck.Items.Add("Colombian" + " " + "Inventory:" + " " + cappuccino.ColombianInventory);
            lstCheck.Items.Add("Milk" + " " + "Inventory:" + " "+ cappuccino.MilkInventory);
            lstCheck.Items.Add("Syrup" + " " + "Inventory:" + " "+ cappuccino.SyrupInventory);
            lstCheck.Items.Add("Mug" + " " + "Inventory:" + mug.MugInventory);
            lstCheck.Items.Add("Shirt" + " " + "Inventory:" + shirt.ShirtInventory);


        }
    }
}