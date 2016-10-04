/*
 * Name : Anju Chawla
 * Date: October 4, 2016
 * Purpose:This application allows the user to select multiple coffee type
 * in various quantities. The amount due is displayed.
 * New orders can be placed
 * */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coffee_Sales
{
    public partial class frmCoffeeShop : Form
    {
        //module level variables
        //objects are initialised to null and numbers to 0
        private decimal subTotalAmount, totalAmount;
        private RadioButton selectedRadioButton;

        //constants
        const decimal TaxRate = 0.13m;
        const decimal CappuccinoPrice = 2m;
        const decimal EspressoPrice = 2.25m;
        const decimal LattePrice = 1.75m;
        const decimal IcedPrice = 2.50m;





        public frmCoffeeShop()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //calculates the amount for the selected coffee/quantity
            //accumulates subtotal for an order-a customer can order 
            //multiple coffee types in various quantities

            //local variables - do not have a default initial value
            int quantity = 0;
            decimal price = 0, tax, itemAmount;

            chkTakeout.Enabled = false;
            //quantity provided
            if(txtQuantity.Text != String.Empty)
            {
                //convert text to integer
                quantity =  int.Parse(txtQuantity.Text); //could use Convert.toInt32(...)
                //quantity is > 0
                if(quantity > 0)
                {
                    //coffee type is selected
                    if(selectedRadioButton != null)
                    {
                        //calculate the item amount due

                    switch(selectedRadioButton.Name)
                        {
                            case "rdoCappuccino":
                                price = CappuccinoPrice;
                                break;
                            case "rdoEspresso":
                                price = EspressoPrice;
                                break;

                            case "rdoLatte":
                                price = LattePrice;
                                break;
                            case "rdoIcedCappuccino":
                            case "rdoIcedLatte" :
                                price = IcedPrice;
                                break;

                        //    default:
                          //      price = 0;
                         //       break;
                        }

                        //calculations




                    //add to subtotal

                    }//coffee selected
                    else
                    {
                        MessageBox.Show("The coffee type needs to be selected", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    }

                }//quantity > 0
                else
                {
                    MessageBox.Show("The number of coffees to be ordered should be greater than 0", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //txtQuantity.SelectAll();
                    txtQuantity.Clear();
                    txtQuantity.Focus();
                }



            }//quantity provided
            else
            {
                MessageBox.Show("Please provide the number of coffees to be ordered", "Input Missing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtQuantity.Focus();
            }


        }//calculate click
    }
}
