using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encrypt_decrypt
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            int minLength = 8; //minimum characters
            int maxLength = 12; //maximum characters
                                //these characters will be used in our random password
            string charAvailable = "abcdefghijkImopqnstuvwXyZABCOEFGHIJKLMNOPORSTUVWXYZe123456789";
            StringBuilder password = new StringBuilder();
            Random rdm = new Random();
            //random length for password is 8 - 12 characters
            int passwordLength = rdm.Next(minLength, maxLength + 1);
            //add a random character to your password until it reaches the randomized length
            while (passwordLength-- > 0)
            password.Append(charAvailable[rdm.Next(charAvailable.Length)]);
            Ib1Password.Text = password.ToString();
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }
    }
}
