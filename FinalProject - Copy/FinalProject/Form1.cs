using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.OleDb;

namespace FinalProject
{
    public partial class Form1 : Form
    {
       // OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\HRdata.mdb");
        public Form1()
        {
            InitializeComponent();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hRData.Information' table. You can move, or remove it, as needed.
            this.informationTableAdapter.Fill(this.hRData.Information);
            informationBindingSource.DataSource = this.hRData.Information;


           /* startDateTextBox.Enabled = false;
            jobComboBox.Enabled = false;
            depComboBox.Enabled = false;
            backGroundCheckBox.Enabled = false;
            healthScreenCheckBox.Enabled = false;
            IDCardCheckBox.Enabled = false;
            OrientationCheckBox.Enabled = false;
            taxInfoCheckBox.Enabled = false;
            technologyCheckBox.Enabled = false;
            label13.Visible = false; */
            panel.Visible = false;
            groupBox1.Visible = false;

        }

        private void newButton_Click(object sender, EventArgs e)
        {
            statusComboBox.ResetText();
            informationBindingSource.Filter = null;
            try
            {
                panel.Visible = true;
                panel.Enabled = true;
                depComboBox.Text = null;
                jobComboBox.Text = null;

                firstNameTextBox.Focus();
                this.hRData.Information.AddInformationRow(this.hRData.Information.NewInformationRow());
                informationBindingSource.MoveLast();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                informationBindingSource.ResetBindings(false);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                informationBindingSource.EndEdit();
                informationTableAdapter.Update(this.hRData.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error! Could not save. Make sure you have filled out required fields, first and last name");
                informationBindingSource.ResetBindings(false);
            }
           
            panel.Enabled = false;
            /*jobComboBox.Enabled = false;
            depComboBox.Enabled = false;
            backGroundCheckBox.Enabled = false;
            healthScreenCheckBox.Enabled = false;
            IDCardCheckBox.Enabled = false;
            OrientationCheckBox.Enabled = false;
            taxInfoCheckBox.Enabled = false;
            technologyCheckBox.Enabled = false;
            statusComboBox.SelectedItem = null;
            depComboBox.SelectedItem = null;
            jobComboBox.SelectedItem = null; */
        }

        private void cancelButton_Click(object sender, EventArgs e) //actually the close form tab
        {
            informationBindingSource.EndEdit();
            MessageBox.Show("Successfully Logged Out. All Records Have Been Updated.");
            this.Close();
        }

        private void statusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (statusComboBox.Text == "Job Offer, Accepted")
            {
                groupBox2.Visible = true;
                jobComboBox.Enabled = true;
                depComboBox.Enabled = true;
                backGroundCheckBox.Enabled = true;
                healthScreenCheckBox.Enabled = true;
                IDCardCheckBox.Enabled = true;
                OrientationCheckBox.Enabled = true;
                taxInfoCheckBox.Enabled = true;
                technologyCheckBox.Enabled = true;
                startDateTextBox.Enabled = true;
                label13.Text = "Not Started";
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            panel.Visible = true;
            panel.Enabled = true;
            firstNameTextBox.Focus();
            informationBindingSource.Filter = null;

            if (statusComboBox.Text == "Job Offer, Accepted")
            {
                groupBox2.Visible = true;
                jobComboBox.Enabled = true;
                depComboBox.Enabled = true;
                backGroundCheckBox.Enabled = true;
                healthScreenCheckBox.Enabled = true;
                IDCardCheckBox.Enabled = true;
                OrientationCheckBox.Enabled = true;
                taxInfoCheckBox.Enabled = true;
                technologyCheckBox.Enabled = true;
                startDateTextBox.Enabled = true;
            }
            else groupBox2.Visible = false;
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            informationBindingSource.Filter = "lastName like '" + searchTextBox.Text + "%'";
        }

        private void backGroundCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            label13.Visible = true;
            bool test1 = ((backGroundCheckBox.Checked == true) && (healthScreenCheckBox.Checked == true) && (IDCardCheckBox.Checked == true) && (OrientationCheckBox.Checked == true) && (taxInfoCheckBox.Checked == true) && (technologyCheckBox.Checked == true));
            bool test2 = ((backGroundCheckBox.Checked == true) || (healthScreenCheckBox.Checked == true) || (IDCardCheckBox.Checked == true) || (OrientationCheckBox.Checked == true) || (taxInfoCheckBox.Checked == true) || (technologyCheckBox.Checked == true));
            if ((test1 == false) && (test2 == false))
            {
                label13.Text = "Not Started";
            }
            else if (test1 == true)
            {
                label13.Text = "Complete";
            }
            else if (test2 == true)
            {
                label13.Text = "In Progress";
            }
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e) //department filter
        {
            informationBindingSource.Filter = "department='" + DepFilterComboBox.Text + "'";
        }

        private void cnclButton_Click(object sender, EventArgs e)
        {
            //if (MessageBox.Show("Would You Like To Undo Recent Changes?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
          //      informationBindingSource.ResetBindings(true);
           // panel.Enabled = false;

           // informationBindingSource.EndEdit();
           // informationTableAdapter.(this.hRData.Information);
            //informationBindingSource.ResetBindings(true);
            //this.hRData.Information.A(this.hRData.Information.NewInformationRow());
            //MessageBox.Show("Changes are cancelled and will be evident when you close and re-enter this form.");
        }

        private void button6_Click(object sender, EventArgs e) //reset filter button
        {
            informationBindingSource.Filter = null;
            groupBox1.Enabled = false;
            DepFilterComboBox.SelectedItem = null;
            applicantFilterComboBox.SelectedItem = null;
        }

        private void exitSearchButton_Click(object sender, EventArgs e)
        {
            informationBindingSource.Filter = null;
            //searchTextBox.Text = String.Empty;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
        }

        private void searchTextBox_Click(object sender, EventArgs e)
        {
            searchTextBox.Text = String.Empty;
        }

        private void button1_Click(object sender, EventArgs e) //applicant status filter
        {
            if (applicantFilterComboBox.Text == "Application Currently Under Review")
            {
                informationBindingSource.Filter = "applicationStatus='Under Review'";
            }
            else if (applicantFilterComboBox.Text == "Hired")
            {
                informationBindingSource.Filter = "applicationStatus='Job Offer, Accepted'";
            }
          //  else if //HOW TO ASSIGN ALL OTHER VALUES TO "NOT HIRED"
          //  {
               // informationBindingSource.Filter =
           // }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox1.Enabled = true;
            button1.Enabled = false;
            button1.Visible = false;
            button4.Enabled = false;
            button4.Visible = false;
            DepFilterComboBox.Enabled = false;
            DepFilterComboBox.Visible = false;
            applicantFilterComboBox.Enabled = false;
            applicantFilterComboBox.Visible = false;

            if (comboBox1.Text == "Filter All By Application Status")
            {
                button1.Visible = true;
                applicantFilterComboBox.Visible = true;
                button1.Enabled = true;
                applicantFilterComboBox.Enabled = true;
            }
            else if (comboBox1.Text == "Filter New Hires By Department")
            {
                button4.Visible = true;
                button4.Enabled = true;
                DepFilterComboBox.Visible = true;
                DepFilterComboBox.Enabled = true;
            }
            /*else if (comboBox1.Text== "Filter New Hires By Onboarding Status")
            {
                onboardComboBox.Visible = true;
                onboardingFilter.Enabled = true;
                onboardingFilter.Visible = true;
                onboardComboBox.Enabled = true;
            } */
        }

        private void FilterButton_Click(object sender, EventArgs e) //"Create a Filter" Button
        {
            /*groupBox1.Enabled = true;
            button1.Enabled = false;
            button4.Enabled = false;
            onboardingFilter.Enabled = false;
            onboardComboBox.Enabled = false;
            DepFilterComboBox.Enabled = false;
            applicantFilterComboBox.Enabled = false; */
        }

        private void panel_EnabledChanged(object sender, EventArgs e)
        {

        }

        private void panel_Enter(object sender, EventArgs e)
        {
            if (statusComboBox.Text == "Job Offer, Accepted")
            {
                groupBox2.Visible = true;
                /* jobComboBox.Enabled = true;
                 depComboBox.Enabled = true;
                 backGroundCheckBox.Enabled = true;
                 healthScreenCheckBox.Enabled = true;
                 IDCardCheckBox.Enabled = true;
                 OrientationCheckBox.Enabled = true;
                 taxInfoCheckBox.Enabled = true;
                 technologyCheckBox.Enabled = true;
                 startDateTextBox.Enabled = true; */
            }
            else groupBox2.Visible = false;
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            panel.Enabled = false;
            if (statusComboBox.Text == "Job Offer, Accepted")
            {
                groupBox2.Visible = true;
                /* jobComboBox.Enabled = true;
                 depComboBox.Enabled = true;
                 backGroundCheckBox.Enabled = true;
                 healthScreenCheckBox.Enabled = true;
                 IDCardCheckBox.Enabled = true;
                 OrientationCheckBox.Enabled = true;
                 taxInfoCheckBox.Enabled = true;
                 technologyCheckBox.Enabled = true;
                 startDateTextBox.Enabled = true; */
            }
            else groupBox2.Visible = false;
        }

        private void statusComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
        }

        private void statusComboBox_DropDownClosed(object sender, EventArgs e)
        {
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure You Want To Delete This Record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                informationBindingSource.RemoveCurrent();
            informationBindingSource.EndEdit();
        }

        private void onboardingFilter_Click(object sender, EventArgs e)
        {
          /*  if (onboardComboBox.Text == "Not Started")
            {
                informationBindingSource.Filter = "applicationStatus='true'";
            }
            else if (applicantFilterComboBox.Text == "Complete")
            {
                informationBindingSource.Filter = "applicationStatus='Compl'";
            } */
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
