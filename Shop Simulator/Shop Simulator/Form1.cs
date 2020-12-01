﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop_Simulator
{
    public partial class Form1 : Form
    {
        int day = 0;
        int payDay = 30;
        float productsCost;
        float wallet = 100;
        float ad;
        float advertisementConverter;//If user enters an int number, this will change it to float
        int countDown = 14;
        int customer;
        int ExtraCustomer;
        int income = 0;
        int inventory;


        public Form1()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
        
            dayTimer.Enabled = true;

            wallet = wallet - productsCost - ad;
            balance.Text = "£" + wallet;
            inventory = int.Parse(products.Text);
        }

        private void dayTimer_Tick(object sender, EventArgs e)
        {
            day++;
            dayNumber.Text = "Day: " + day;

            startButton.Enabled = false;
            startButton.Text = countDown.ToString();
            countDown--;

            customerCalculation();
            wallet += income;

            payDay--;
            billsDue.Text = "Pay Bills In: " + payDay + " Days";

            if (countDown < 0)
            {
                limit();
            }
        }

        private void products_TextChanged(object sender, EventArgs e)
        {
            if (products.TextLength > 0)
            {
                productsCost = float.Parse(products.Text) * 1.5f;
                productsCostOutput.Text = "= £" + productsCost.ToString();
            }
            else
            {
                productsCostOutput.Text = "= £0";
            }
        }

        private void advertisement_TextChanged(object sender, EventArgs e)
        {
            if (advertisement.TextLength > 0)
            {
                advertisementConverter = float.Parse(advertisement.Text);
                advertisement.Text = advertisementConverter.ToString();
                ad = float.Parse(advertisement.Text);
            }
        }

        private void limit()
        {
            dayTimer.Enabled = false;
            startButton.Enabled = true;
            startButton.Text = "Open";
            countDown = 14;
            

            if (wallet <= 0)
            {
                MessageBox.Show("       Gameover");
                Application.Restart();
            }


            if (payDay == 0)
            {
                MessageBox.Show("£50 will be subtracted from you balance to pay the bills" + "\n Before: £" + wallet + "\n After: £" + (wallet - 50));
                wallet -= 50;
                payDay = 30;
            }

            balance.Text = "£" + wallet;
        }

        private void customerCalculation()
        {
            Random n = new Random();
            ExtraCustomer = n.Next(1, 3) * int.Parse((double.Parse(advertisement.Text)/ 0.5).ToString());
            customer = n.Next(1, 10) + ExtraCustomer;
            if (inventory > 0)
            {

                income = customer * n.Next(1, 3);

                feed.Items.Add("Day " + day + ": " + customer + " customers came today and " + "you earned £" + income);
                feed.SelectedIndex = feed.Items.Count - 1;
                feed.SelectedIndex = -1;

                inventory -= income;
            }

            
            else
            {
                income = 0;
                feed.Items.Add("Day " + day + ": " + customer + " customers came today and " + "you earned £" + income);
            }
            
        }
    }
}
