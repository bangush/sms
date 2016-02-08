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

namespace SMSapplication
{
    public partial class AddNumberForm : Form
    {
        public AddNumberForm()
        {
            InitializeComponent();
        }

        private void btnAddNumber_Click(object sender, EventArgs e)
        {
            string numberString = rtbNumberAdd.Text.ToString().Trim();
            if (numberString != "")
            {
                //SMSapplication mainForm = new SMSapplication();
                //mainForm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Hãy nhập chuỗi số muốn thêm");
            }
        }

        private bool isPhoneNumber(string number)
        {
            return Regex.Match(number, @"^(\+[0-9]{9})$").Success;
        }
    }
}
