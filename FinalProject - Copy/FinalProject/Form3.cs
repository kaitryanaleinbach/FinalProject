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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void informationBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.informationBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hRData);
            

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hRData.Information' table. You can move, or remove it, as needed.
            firstNameTextBox.Focus();
            this.hRData.Information.AddInformationRow(this.hRData.Information.NewInformationRow());
            informationBindingSource.MoveLast();

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            informationBindingSource.Filter = null;
            try
            {
                this.Validate();
                informationBindingSource.EndEdit();
                informationTableAdapter.Update(this.hRData.Information);
                MessageBox.Show("Thank you for your submission.");
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error! Could not save. Make sure you have filled out required fields, first and last name");
                informationBindingSource.ResetBindings(false);
            }
        }
    }
}
