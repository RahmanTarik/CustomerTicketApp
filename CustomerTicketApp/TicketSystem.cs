using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerTicketApp
{
    public partial class TicketSystem : Form
    {
        public TicketSystem()
        {
            InitializeComponent();
        }

        private int unitPrice = 10;
        private int totalPrice = 0;
        private string customerName = "";
        private int numberOfTicket = 0;
        private void showTotalPriceButton_Click(object sender, EventArgs e)
        {
            if (customerNameTextBox.Text != "" && numberOfTicketTextBox.Text != "")
            {
                customerName = customerNameTextBox.Text;
                numberOfTicket = Convert.ToInt32(numberOfTicketTextBox.Text);
                totalPrice = numberOfTicket * unitPrice;
                customerNameTextBox.Text = "";
                numberOfTicketTextBox.Text = "";
            }
            
            MessageBox.Show(customerName + ", You have to pay " + totalPrice + " Taka");
            
        }

        private void detailsButton_Click(object sender, EventArgs e)
        {
            if (customerNameTextBox.Text != "" && numberOfTicketTextBox.Text != "")
            {
                customerName = customerNameTextBox.Text;
                numberOfTicket = Convert.ToInt32(numberOfTicketTextBox.Text);
                totalPrice = numberOfTicket * unitPrice;
            }
            MessageBox.Show("Customer Name: " + customerName +  "\n Unit Price: " + unitPrice + " Taka" + "\n Total Price: " + totalPrice);
            
        }
    }
}
