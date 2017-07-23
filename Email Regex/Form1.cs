using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Email_Regex
{
    public partial class Form1 : Form
    {
        readonly string emailRegex;
        StringBuilder emailAddresses = new StringBuilder();

        public Form1()
        {
            //Assigning the reg exp to the emailRegex variable
            emailRegex =
                @"[a-z0-9!#$%&'*+/=?^_`{|}~-]" +
                @"+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@" + 
                @"(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)" +
                @"+[a-z0-9](?:[a-z0-9-]*[a-z0- 9])?";

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var result = Regex.IsMatch(txtEmail.Text, emailRegex);
            if (result)
            {
                txtEmail.BackColor = Color.White;
                if (!emailAddresses.ToString().Contains(txtEmail.Text))
                    emailAddresses.Append(txtEmail.Text + "\n");
            }
            else
                txtEmail.BackColor = Color.LightPink;
            txtEmailList.Text = emailAddresses.ToString();
        }
    }
}
