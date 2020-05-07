namespace FinalProject
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.Label lastNameLabel;
            System.Windows.Forms.Label dOBLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label cellPhoneLabel;
            System.Windows.Forms.Label emailLabel;
            this.hRData = new FinalProject.HRData();
            this.informationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.informationTableAdapter = new FinalProject.HRDataTableAdapters.InformationTableAdapter();
            this.tableAdapterManager = new FinalProject.HRDataTableAdapters.TableAdapterManager();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox3 = new System.Windows.Forms.MaskedTextBox();
            firstNameLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            dOBLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            cellPhoneLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hRData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.informationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new System.Drawing.Point(94, 113);
            firstNameLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(122, 25);
            firstNameLabel.TabIndex = 3;
            firstNameLabel.Text = "First Name:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new System.Drawing.Point(94, 163);
            lastNameLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(121, 25);
            lastNameLabel.TabIndex = 5;
            lastNameLabel.Text = "Last Name:";
            // 
            // dOBLabel
            // 
            dOBLabel.AutoSize = true;
            dOBLabel.Location = new System.Drawing.Point(94, 213);
            dOBLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            dOBLabel.Name = "dOBLabel";
            dOBLabel.Size = new System.Drawing.Size(63, 25);
            dOBLabel.TabIndex = 7;
            dOBLabel.Text = "DOB:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(94, 263);
            addressLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(97, 25);
            addressLabel.TabIndex = 9;
            addressLabel.Text = "Address:";
            // 
            // cellPhoneLabel
            // 
            cellPhoneLabel.AutoSize = true;
            cellPhoneLabel.Location = new System.Drawing.Point(94, 377);
            cellPhoneLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            cellPhoneLabel.Name = "cellPhoneLabel";
            cellPhoneLabel.Size = new System.Drawing.Size(123, 25);
            cellPhoneLabel.TabIndex = 11;
            cellPhoneLabel.Text = "Cell Phone:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(94, 427);
            emailLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(71, 25);
            emailLabel.TabIndex = 13;
            emailLabel.Text = "Email:";
            // 
            // hRData
            // 
            this.hRData.DataSetName = "HRData";
            this.hRData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // informationBindingSource
            // 
            this.informationBindingSource.DataMember = "Information";
            this.informationBindingSource.DataSource = this.hRData;
            // 
            // informationTableAdapter
            // 
            this.informationTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.InformationTableAdapter = this.informationTableAdapter;
            this.tableAdapterManager.UpdateOrder = FinalProject.HRDataTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.informationBindingSource, "firstName", true));
            this.firstNameTextBox.Location = new System.Drawing.Point(273, 110);
            this.firstNameTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(253, 31);
            this.firstNameTextBox.TabIndex = 4;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.informationBindingSource, "lastName", true));
            this.lastNameTextBox.Location = new System.Drawing.Point(273, 160);
            this.lastNameTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(253, 31);
            this.lastNameTextBox.TabIndex = 6;
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.informationBindingSource, "Address", true));
            this.addressTextBox.Location = new System.Drawing.Point(273, 260);
            this.addressTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.addressTextBox.Multiline = true;
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(253, 86);
            this.addressTextBox.TabIndex = 10;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.informationBindingSource, "email", true));
            this.emailTextBox.Location = new System.Drawing.Point(273, 424);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(253, 31);
            this.emailTextBox.TabIndex = 14;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(494, 502);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(154, 45);
            this.submitButton.TabIndex = 15;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Please Enter Your Information.";
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.informationBindingSource, "DOB", true));
            this.maskedTextBox2.Location = new System.Drawing.Point(273, 207);
            this.maskedTextBox2.Mask = "00/00/0000";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(253, 31);
            this.maskedTextBox2.TabIndex = 18;
            this.maskedTextBox2.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBox3
            // 
            this.maskedTextBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.informationBindingSource, "cellPhone", true));
            this.maskedTextBox3.Location = new System.Drawing.Point(273, 371);
            this.maskedTextBox3.Mask = "000-000-0000";
            this.maskedTextBox3.Name = "maskedTextBox3";
            this.maskedTextBox3.Size = new System.Drawing.Size(253, 31);
            this.maskedTextBox3.TabIndex = 19;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 604);
            this.Controls.Add(this.maskedTextBox3);
            this.Controls.Add(this.maskedTextBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(firstNameLabel);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(lastNameLabel);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(dOBLabel);
            this.Controls.Add(addressLabel);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(cellPhoneLabel);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form3";
            this.Text = "Applicant Form";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hRData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.informationBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HRData hRData;
        private System.Windows.Forms.BindingSource informationBindingSource;
        private HRDataTableAdapters.InformationTableAdapter informationTableAdapter;
        private HRDataTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox3;
    }
}