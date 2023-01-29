using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using HtmlAgilityPack;

namespace Encrypt_decrypt
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {

            // Get the URL from the textbox
            string url = urlTextBox.Text;

            // Create an HtmlWeb object
            HtmlWeb web = new HtmlWeb();

            // Load the page from the website
            HtmlAgilityPack.HtmlDocument doc = web.Load(url);

            // Select the desired element from the page
            HtmlNode element = doc.DocumentNode.SelectSingleNode("//div[@class='some-class']");

            // Extract the text from the selected element
            //string text = element.InnerText;
            if (element != null)
            {
                string text = element.InnerText;
                MessageBox.Show(text);
            }
            else
            {
                MessageBox.Show("Element not found!");
            }

            // Display the text in a message box
           // MessageBox.Show(text);

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form
            this.Close();
        }
    }
}
           
