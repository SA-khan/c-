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
            
    public partial class Form1 : Form
    {
        public string TypeOfArray;
        public string SizeOfArray;
        public string Dimensionflag;
        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedItem = " Int";
            this.AcceptButton = button9;
            
            
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.create_an_array;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.digital_home_thumb800;
        }

        private void button8_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.Exit_sign;
        }

        private void button8_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.digital_home_thumb800;
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.insert_table_256px_539879_easyicon_net;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.digital_home_thumb800;
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.Point_of_View;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.digital_home_thumb800;
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.search_volume;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.digital_home_thumb800;
        }

        private void button5_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources._440226_how_to_delete_accounts_from_any_website;
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.digital_home_thumb800;
        }

        private void button6_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.Sorting;
        }

        private void button6_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.digital_home_thumb800;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            panel7.Visible = true;
        }

        private void button7_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources._9;
        }

        private void button7_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.digital_home_thumb800;
        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
            pictureBox2.Image = Properties.Resources.insert_table_256px_539879_easyicon_net;
        }

        private void button2_KeyDown(object sender, KeyEventArgs e)
        {
            pictureBox2.Image = Properties.Resources.Point_of_View;
        }

        private void button3_KeyDown(object sender, KeyEventArgs e)
        {
            pictureBox2.Image = Properties.Resources.search_volume;
        }

        private void button4_KeyDown(object sender, KeyEventArgs e)
        {
            pictureBox2.Image = Properties.Resources._440226_how_to_delete_accounts_from_any_website;
        }

        private void button5_KeyDown(object sender, KeyEventArgs e)
        {
            pictureBox2.Image = Properties.Resources.Sorting;
        }

        private void button6_KeyDown(object sender, KeyEventArgs e)
        {
            pictureBox2.Image = Properties.Resources._9;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button9.Visible = true;
            panel1.Visible = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            
            if ((comboBox1.Text != "" && comboBox2.Text != "")&&(radioButton1.Checked || radioButton2.Checked || radioButton3.Checked || radioButton4.Checked))
            {
                 TypeOfArray = comboBox1.Text;
                 SizeOfArray = comboBox2.Text;
                 //string flag;
                 if (radioButton1.Checked) { Dimensionflag = "1D is on"; }
                 else if (radioButton2.Checked) { Dimensionflag = "2D is on"; }
                 else if (radioButton3.Checked) { Dimensionflag = "3D is on"; }
                 else if (radioButton4.Checked) { Dimensionflag = "4D is on"; }
                
                Form2 myform2 = new Form2(TypeOfArray,SizeOfArray,Dimensionflag);
                myform2.Show();
                this.Hide();
            }
            else {
                MessageBox.Show("Please Enter Type,Size and dimention of the array!! ","Warning",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            panel7.Visible = false;
            button9.Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            panel7.Visible = false;
            button9.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            panel7.Visible = false;
            button9.Visible = false;
        }
        public string DisplayMessage() {
            string as1 = TypeOfArray;
            string as2 = SizeOfArray;
            return as1;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            button11.Visible = true;
            panel3.Visible = true;
          

            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel4.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel5.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel6.Visible = true;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int[] myarray = new int[12];
            Array.Resize(ref myarray,15);
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text != "")
            {
                Form2 myform2 = new Form2(TypeOfArray, SizeOfArray,Dimensionflag);
                myform2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Enter Array's Name!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
