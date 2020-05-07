using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void informationBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.informationBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hRData);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hRData.Information' table. You can move, or remove it, as needed.
            this.informationTableAdapter.Fill(this.hRData.Information);
            groupBox1.Visible = false;
        }

        private void CreateNewButton_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            form.Show();
            form.Focus();
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            bool emp;
            //bool emp = ((usernameTextBox.Text == "ie2060") & (passwordTextBox.Text == "2060"));
            if (emp = (usernameTextBox.Text == "ie2060") & (passwordTextBox.Text == "2060"))
            {
                Form1 form = new Form1();
                form.Show();
                form.Focus();
            } else MessageBox.Show("Login is invalid. Please retry.");
                passwordTextBox.Clear();
            passwordTextBox.Focus();
        }
    }
}
