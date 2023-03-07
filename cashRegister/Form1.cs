using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cashRegister
{
   

    public partial class Form1 : Form

    {
        double gumPrice = 1.50;
        double chocolatePrice = 2.99;
        double icecreamPrice = 4.20;
        int gumQuantity;
        int chocolateQuantity;
        int icecreamQuantity;
        int tenderQuantity;
        double total;
        double change;
        double gumTotal;
        double chocolateTotal;
        double icecreamTotal;  
        public Form1()
        {
            InitializeComponent();
           

        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {             // Get the input values from the textboxes
                gumQuantity = Convert.ToInt32(gumInput.Text);
                chocolateQuantity = Convert.ToInt32(chocolateInput.Text);
                icecreamQuantity = Convert.ToInt32(icecreamInput.Text);

                // Calculate the subtotal
                double subtotal = (gumQuantity * gumPrice) + (chocolateQuantity * chocolatePrice) + (icecreamQuantity * icecreamPrice);

                // Display the subtotal in the output textbox
                subtotalOutput.Text = subtotal.ToString("$0.00");

                // Calculate the tax rate
                double taxRate = subtotal * 0.13;

                // Display the subtotal and tax rate in the output textboxes
                subtotalOutput.Text = subtotal.ToString("$0.00");
                taxOutput.Text = taxRate.ToString("$0.00");

                // Calculate the total
                total = subtotal + taxRate;

                // Display the total in the output textbox
                totalOutput.Text = total.ToString("$0.00");
            }
            catch
            {

            }
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            tenderQuantity = Convert.ToInt32(tenderedInput.Text);

            if(tenderQuantity < total)
            {
                changeOutput.Text = $"Error";
            }
           else
            {
                change = tenderQuantity - total;
                changeOutput.Text = change.ToString("C");
            }
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            gumTotal = gumPrice * gumQuantity;
            chocolateTotal = chocolatePrice * chocolateQuantity;
            icecreamTotal = icecreamPrice * icecreamQuantity;

            receiptOutput.Text = $"             Gabe's Candy Store";
            receiptOutput.Text += $"\n             2:12 PM, 3/6/2023";
            receiptOutput.Text += $"\n\n  Gum x{gumQuantity} ";
            receiptOutput.Text += gumTotal.ToString("C");
            receiptOutput.Text += $"\n  Chocolate x{chocolateQuantity} ";
            receiptOutput.Text += chocolateTotal.ToString("C");
            receiptOutput.Text += $"\n  Ice cream x{icecreamQuantity} ";
            receiptOutput.Text += icecreamTotal.ToString("C");
            receiptOutput.Text += $"\n\n                Have a nice day";
        }

        private void neworderButton_Click(object sender, EventArgs e)
        {
            receiptOutput.Text = "";
            gumInput.Text = "";
            chocolateInput.Text = "";
            subtotalOutput.Text = "";
            taxOutput.Text = "";
            totalOutput.Text = "";
            tenderedInput.Text = "";
            label2.Text = "";
            gumQuantity = 0;
            chocolateQuantity = 0;
            icecreamQuantity= 0;    

        }
    }
}
