using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrayProject
{
    public partial class Form2 : Form
    {
        public Form2(string TypeOfArray,string SizeOfArray,string Dimensionflag)
        {
            InitializeComponent();
            label2.Text = SizeOfArray;
            label1.Text = TypeOfArray;
            label3.Text = Dimensionflag;
            
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
