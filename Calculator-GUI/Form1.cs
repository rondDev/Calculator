using System;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace Calculator_GUI
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void mnuMulti_Click(object sender, EventArgs e)
        {
            lblSign.Text = "x";
        }

        private void mnuDiv_Click(object sender, EventArgs e)
        {
            lblSign.Text = "/";
        }

        private void mnuAdd_Click(object sender, EventArgs e)
        {
            lblSign.Text = "+";
        }

        private void mnuSub_Click(object sender, EventArgs e)
        {
            lblSign.Text = "-";
        }

        private void txtNumOne_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNumOne.Text) || string.IsNullOrEmpty(txtNumTwo.Text)) return;
            int one = Convert.ToInt32(txtNumOne.Text);
            int two = Convert.ToInt32(txtNumTwo.Text);
            switch (lblSign.Text)
            {
                case "x":
                    txtRes.Text = (one * two).ToString();
                    break;
                case "/":
                    txtRes.Text = (one / two).ToString();
                    break;
                case "+":
                    txtRes.Text = (one + two).ToString();
                    break;
                case "-":
                    txtRes.Text = (one - two).ToString();
                    break;
                default:
                    break;
            }
        }

        private void txtNumTwo_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNumOne.Text) || string.IsNullOrEmpty(txtNumTwo.Text)) return;
            int one = Convert.ToInt32(txtNumOne.Text);
            int two = Convert.ToInt32(txtNumTwo.Text);
            switch (lblSign.Text)
            {
                case "x":
                    txtRes.Text = (one * two).ToString();
                    break;
                case "/":
                    txtRes.Text = (one / two).ToString();
                    break;
                case "+":
                    txtRes.Text = (one + two).ToString();
                    break;
                case "-":
                    txtRes.Text = (one - two).ToString();
                    break;
                default:
                    break;
            }
        }
    }
}