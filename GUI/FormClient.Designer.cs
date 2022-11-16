
namespace HiTechOrderSystem.GUI
{
    partial class FormClient
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
            this.label13 = new System.Windows.Forms.Label();
            this.buttonClientSearch = new System.Windows.Forms.Button();
            this.textBoxClientSearch = new System.Windows.Forms.TextBox();
            this.buttonClientListAll = new System.Windows.Forms.Button();
            this.buttonClientDelete = new System.Windows.Forms.Button();
            this.buttonClientUpdate = new System.Windows.Forms.Button();
            this.buttonClientSave = new System.Windows.Forms.Button();
            this.maskedTextBoxClientPostCode = new System.Windows.Forms.MaskedTextBox();
            this.textBoxClientCity = new System.Windows.Forms.TextBox();
            this.textBoxClientCreditLimit = new System.Windows.Forms.TextBox();
            this.textBoxClientFaxNumber = new System.Windows.Forms.TextBox();
            this.maskedTextBoxClientPhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.textBoxClientStreet = new System.Windows.Forms.TextBox();
            this.textBoxClientName = new System.Windows.Forms.TextBox();
            this.textBoxClientID = new System.Windows.Forms.TextBox();
            this.listViewClient = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxClienttype = new System.Windows.Forms.ComboBox();
            this.buttonWritetoXML = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(657, 58);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 13);
            this.label13.TabIndex = 52;
            this.label13.Text = "Search Client";
            // 
            // buttonClientSearch
            // 
            this.buttonClientSearch.Location = new System.Drawing.Point(660, 155);
            this.buttonClientSearch.Name = "buttonClientSearch";
            this.buttonClientSearch.Size = new System.Drawing.Size(94, 39);
            this.buttonClientSearch.TabIndex = 51;
            this.buttonClientSearch.Text = "Search";
            this.buttonClientSearch.UseVisualStyleBackColor = true;
            this.buttonClientSearch.Click += new System.EventHandler(this.buttonClientSearch_Click);
            // 
            // textBoxClientSearch
            // 
            this.textBoxClientSearch.Location = new System.Drawing.Point(641, 111);
            this.textBoxClientSearch.Name = "textBoxClientSearch";
            this.textBoxClientSearch.Size = new System.Drawing.Size(121, 20);
            this.textBoxClientSearch.TabIndex = 50;
            // 
            // buttonClientListAll
            // 
            this.buttonClientListAll.Location = new System.Drawing.Point(322, 188);
            this.buttonClientListAll.Name = "buttonClientListAll";
            this.buttonClientListAll.Size = new System.Drawing.Size(90, 37);
            this.buttonClientListAll.TabIndex = 47;
            this.buttonClientListAll.Text = "List All";
            this.buttonClientListAll.UseVisualStyleBackColor = true;
            this.buttonClientListAll.Click += new System.EventHandler(this.buttonClientListAll_Click);
            // 
            // buttonClientDelete
            // 
            this.buttonClientDelete.Enabled = false;
            this.buttonClientDelete.Location = new System.Drawing.Point(463, 144);
            this.buttonClientDelete.Name = "buttonClientDelete";
            this.buttonClientDelete.Size = new System.Drawing.Size(90, 37);
            this.buttonClientDelete.TabIndex = 46;
            this.buttonClientDelete.Text = "Delete";
            this.buttonClientDelete.UseVisualStyleBackColor = true;
            this.buttonClientDelete.Click += new System.EventHandler(this.buttonClientDelete_Click);
            // 
            // buttonClientUpdate
            // 
            this.buttonClientUpdate.Enabled = false;
            this.buttonClientUpdate.Location = new System.Drawing.Point(463, 93);
            this.buttonClientUpdate.Name = "buttonClientUpdate";
            this.buttonClientUpdate.Size = new System.Drawing.Size(90, 38);
            this.buttonClientUpdate.TabIndex = 45;
            this.buttonClientUpdate.Text = "Update";
            this.buttonClientUpdate.UseVisualStyleBackColor = true;
            this.buttonClientUpdate.Click += new System.EventHandler(this.buttonClientUpdate_Click);
            // 
            // buttonClientSave
            // 
            this.buttonClientSave.Location = new System.Drawing.Point(463, 46);
            this.buttonClientSave.Name = "buttonClientSave";
            this.buttonClientSave.Size = new System.Drawing.Size(90, 37);
            this.buttonClientSave.TabIndex = 44;
            this.buttonClientSave.Text = "Save";
            this.buttonClientSave.UseVisualStyleBackColor = true;
            this.buttonClientSave.Click += new System.EventHandler(this.buttonClientSave_Click);
            // 
            // maskedTextBoxClientPostCode
            // 
            this.maskedTextBoxClientPostCode.Location = new System.Drawing.Point(323, 127);
            this.maskedTextBoxClientPostCode.Mask = " >L0L\\ 0L0";
            this.maskedTextBoxClientPostCode.Name = "maskedTextBoxClientPostCode";
            this.maskedTextBoxClientPostCode.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxClientPostCode.TabIndex = 43;
            // 
            // textBoxClientCity
            // 
            this.textBoxClientCity.Location = new System.Drawing.Point(322, 90);
            this.textBoxClientCity.Name = "textBoxClientCity";
            this.textBoxClientCity.Size = new System.Drawing.Size(100, 20);
            this.textBoxClientCity.TabIndex = 42;
            // 
            // textBoxClientCreditLimit
            // 
            this.textBoxClientCreditLimit.Location = new System.Drawing.Point(136, 205);
            this.textBoxClientCreditLimit.Name = "textBoxClientCreditLimit";
            this.textBoxClientCreditLimit.Size = new System.Drawing.Size(100, 20);
            this.textBoxClientCreditLimit.TabIndex = 41;
            // 
            // textBoxClientFaxNumber
            // 
            this.textBoxClientFaxNumber.Location = new System.Drawing.Point(136, 168);
            this.textBoxClientFaxNumber.Name = "textBoxClientFaxNumber";
            this.textBoxClientFaxNumber.Size = new System.Drawing.Size(100, 20);
            this.textBoxClientFaxNumber.TabIndex = 40;
            // 
            // maskedTextBoxClientPhoneNumber
            // 
            this.maskedTextBoxClientPhoneNumber.Location = new System.Drawing.Point(136, 123);
            this.maskedTextBoxClientPhoneNumber.Mask = "(999) 000-0000";
            this.maskedTextBoxClientPhoneNumber.Name = "maskedTextBoxClientPhoneNumber";
            this.maskedTextBoxClientPhoneNumber.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxClientPhoneNumber.TabIndex = 39;
            // 
            // textBoxClientStreet
            // 
            this.textBoxClientStreet.Location = new System.Drawing.Point(322, 55);
            this.textBoxClientStreet.Name = "textBoxClientStreet";
            this.textBoxClientStreet.Size = new System.Drawing.Size(100, 20);
            this.textBoxClientStreet.TabIndex = 38;
            // 
            // textBoxClientName
            // 
            this.textBoxClientName.Location = new System.Drawing.Point(136, 86);
            this.textBoxClientName.Name = "textBoxClientName";
            this.textBoxClientName.Size = new System.Drawing.Size(100, 20);
            this.textBoxClientName.TabIndex = 37;
            // 
            // textBoxClientID
            // 
            this.textBoxClientID.Location = new System.Drawing.Point(136, 55);
            this.textBoxClientID.Name = "textBoxClientID";
            this.textBoxClientID.Size = new System.Drawing.Size(100, 20);
            this.textBoxClientID.TabIndex = 36;
            // 
            // listViewClient
            // 
            this.listViewClient.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.listViewClient.GridLines = true;
            this.listViewClient.HideSelection = false;
            this.listViewClient.Location = new System.Drawing.Point(49, 250);
            this.listViewClient.Name = "listViewClient";
            this.listViewClient.Size = new System.Drawing.Size(721, 167);
            this.listViewClient.TabIndex = 35;
            this.listViewClient.UseCompatibleStateImageBehavior = false;
            this.listViewClient.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Client ID";
            this.columnHeader1.Width = 64;
            // 
            // columnHeader9
            // 
            this.columnHeader9.DisplayIndex = 8;
            this.columnHeader9.Text = "Type";
            this.columnHeader9.Width = 70;
            // 
            // columnHeader2
            // 
            this.columnHeader2.DisplayIndex = 1;
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 68;
            // 
            // columnHeader3
            // 
            this.columnHeader3.DisplayIndex = 2;
            this.columnHeader3.Text = "Street";
            this.columnHeader3.Width = 71;
            // 
            // columnHeader4
            // 
            this.columnHeader4.DisplayIndex = 3;
            this.columnHeader4.Text = "City";
            this.columnHeader4.Width = 65;
            // 
            // columnHeader5
            // 
            this.columnHeader5.DisplayIndex = 4;
            this.columnHeader5.Text = "Post Code";
            this.columnHeader5.Width = 78;
            // 
            // columnHeader6
            // 
            this.columnHeader6.DisplayIndex = 5;
            this.columnHeader6.Text = "Phone Number";
            this.columnHeader6.Width = 102;
            // 
            // columnHeader7
            // 
            this.columnHeader7.DisplayIndex = 6;
            this.columnHeader7.Text = "Fax Number";
            this.columnHeader7.Width = 94;
            // 
            // columnHeader8
            // 
            this.columnHeader8.DisplayIndex = 7;
            this.columnHeader8.Text = "Credit Limit";
            this.columnHeader8.Width = 102;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(46, 205);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 13);
            this.label11.TabIndex = 34;
            this.label11.Text = "Credit Limit :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(46, 168);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 13);
            this.label10.TabIndex = 33;
            this.label10.Text = "Fax Number :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(46, 127);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 13);
            this.label9.TabIndex = 32;
            this.label9.Text = "Phone Number :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(255, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "Post Code :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(255, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "City :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(255, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Street :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Name :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Client ID :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 53;
            this.label1.Text = "Institution type :";
            // 
            // comboBoxClienttype
            // 
            this.comboBoxClienttype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxClienttype.FormattingEnabled = true;
            this.comboBoxClienttype.Items.AddRange(new object[] {
            "College",
            "University"});
            this.comboBoxClienttype.Location = new System.Drawing.Point(136, 19);
            this.comboBoxClienttype.Name = "comboBoxClienttype";
            this.comboBoxClienttype.Size = new System.Drawing.Size(100, 21);
            this.comboBoxClienttype.TabIndex = 54;
            // 
            // buttonWritetoXML
            // 
            this.buttonWritetoXML.Location = new System.Drawing.Point(463, 188);
            this.buttonWritetoXML.Name = "buttonWritetoXML";
            this.buttonWritetoXML.Size = new System.Drawing.Size(90, 37);
            this.buttonWritetoXML.TabIndex = 55;
            this.buttonWritetoXML.Text = "Write To XML";
            this.buttonWritetoXML.UseVisualStyleBackColor = true;
            this.buttonWritetoXML.Click += new System.EventHandler(this.buttonWritetoXML_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(638, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 56;
            this.label2.Text = "Please Enter Client ID :";
            // 
            // FormClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonWritetoXML);
            this.Controls.Add(this.comboBoxClienttype);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.buttonClientSearch);
            this.Controls.Add(this.textBoxClientSearch);
            this.Controls.Add(this.buttonClientListAll);
            this.Controls.Add(this.buttonClientDelete);
            this.Controls.Add(this.buttonClientUpdate);
            this.Controls.Add(this.buttonClientSave);
            this.Controls.Add(this.maskedTextBoxClientPostCode);
            this.Controls.Add(this.textBoxClientCity);
            this.Controls.Add(this.textBoxClientCreditLimit);
            this.Controls.Add(this.textBoxClientFaxNumber);
            this.Controls.Add(this.maskedTextBoxClientPhoneNumber);
            this.Controls.Add(this.textBoxClientStreet);
            this.Controls.Add(this.textBoxClientName);
            this.Controls.Add(this.textBoxClientID);
            this.Controls.Add(this.listViewClient);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Name = "FormClient";
            this.Text = "Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button buttonClientSearch;
        private System.Windows.Forms.TextBox textBoxClientSearch;
        private System.Windows.Forms.Button buttonClientListAll;
        private System.Windows.Forms.Button buttonClientDelete;
        private System.Windows.Forms.Button buttonClientUpdate;
        private System.Windows.Forms.Button buttonClientSave;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxClientPostCode;
        private System.Windows.Forms.TextBox textBoxClientCity;
        private System.Windows.Forms.TextBox textBoxClientCreditLimit;
        private System.Windows.Forms.TextBox textBoxClientFaxNumber;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxClientPhoneNumber;
        private System.Windows.Forms.TextBox textBoxClientStreet;
        private System.Windows.Forms.TextBox textBoxClientName;
        private System.Windows.Forms.TextBox textBoxClientID;
        private System.Windows.Forms.ListView listViewClient;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxClienttype;
        private System.Windows.Forms.Button buttonWritetoXML;
        private System.Windows.Forms.Label label2;
    }
}