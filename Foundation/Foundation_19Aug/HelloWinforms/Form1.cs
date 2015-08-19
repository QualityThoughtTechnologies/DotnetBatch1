using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWinforms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPressMe_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtMessage.Text))
            {
                MessageBox.Show(this,"Please enter text","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                DialogResult result=MessageBox.Show(this,txtMessage.Text,this.Text,MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
                MessageBox.Show(result.ToString());
            }
            
        }
    }
}
