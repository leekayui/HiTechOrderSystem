
namespace HiTechOrderSystem.GUI
{
    partial class FormOrders
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxOrderBy = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxOrderClientID = new System.Windows.Forms.TextBox();
            this.textBoxOrderProductID = new System.Windows.Forms.TextBox();
            this.labelPayment = new System.Windows.Forms.Label();
            this.maskedTextBoxRequireDate = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxShippingDate = new System.Windows.Forms.MaskedTextBox();
            this.listViewOrder = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxOrderNumber = new System.Windows.Forms.TextBox();
            this.textBoxOrderQuantity = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonOrderDelete = new System.Windows.Forms.Button();
            this.buttonOrderUpdate = new System.Windows.Forms.Button();
            this.buttonOrderSave = new System.Windows.Forms.Button();
            this.buttonOrderList = new System.Windows.Forms.Button();
            this.buttonOrderSearch = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Order By";
            // 
            // comboBoxOrderBy
            // 
            this.comboBoxOrderBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOrderBy.FormattingEnabled = true;
            this.comboBoxOrderBy.Items.AddRange(new object[] {
            "Phone",
            "Fax",
            "Email"});
            this.comboBoxOrderBy.Location = new System.Drawing.Point(130, 136);
            this.comboBoxOrderBy.Name = "comboBoxOrderBy";
            this.comboBoxOrderBy.Size = new System.Drawing.Size(121, 21);
            this.comboBoxOrderBy.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Client\'s Require Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Shipping Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Payment ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Client ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Product ID";
            // 
            // textBoxOrderClientID
            // 
            this.textBoxOrderClientID.Location = new System.Drawing.Point(130, 44);
            this.textBoxOrderClientID.Name = "textBoxOrderClientID";
            this.textBoxOrderClientID.Size = new System.Drawing.Size(100, 20);
            this.textBoxOrderClientID.TabIndex = 7;
            // 
            // textBoxOrderProductID
            // 
            this.textBoxOrderProductID.Location = new System.Drawing.Point(130, 76);
            this.textBoxOrderProductID.Name = "textBoxOrderProductID";
            this.textBoxOrderProductID.Size = new System.Drawing.Size(100, 20);
            this.textBoxOrderProductID.TabIndex = 8;
            // 
            // labelPayment
            // 
            this.labelPayment.AutoSize = true;
            this.labelPayment.Location = new System.Drawing.Point(127, 168);
            this.labelPayment.Name = "labelPayment";
            this.labelPayment.Size = new System.Drawing.Size(78, 13);
            this.labelPayment.TabIndex = 9;
            this.labelPayment.Text = "Bank_Account";
            // 
            // maskedTextBoxRequireDate
            // 
            this.maskedTextBoxRequireDate.Location = new System.Drawing.Point(130, 190);
            this.maskedTextBoxRequireDate.Mask = "00/00/0000";
            this.maskedTextBoxRequireDate.Name = "maskedTextBoxRequireDate";
            this.maskedTextBoxRequireDate.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxRequireDate.TabIndex = 10;
            this.maskedTextBoxRequireDate.ValidatingType = typeof(System.DateTime);
            this.maskedTextBoxRequireDate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maskedTextBoxRequireDate_KeyPress);
            // 
            // maskedTextBoxShippingDate
            // 
            this.maskedTextBoxShippingDate.Enabled = false;
            this.maskedTextBoxShippingDate.Location = new System.Drawing.Point(130, 223);
            this.maskedTextBoxShippingDate.Mask = "00/00/0000";
            this.maskedTextBoxShippingDate.Name = "maskedTextBoxShippingDate";
            this.maskedTextBoxShippingDate.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxShippingDate.TabIndex = 11;
            this.maskedTextBoxShippingDate.ValidatingType = typeof(System.DateTime);
            // 
            // listViewOrder
            // 
            this.listViewOrder.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.listViewOrder.GridLines = true;
            this.listViewOrder.HideSelection = false;
            this.listViewOrder.Location = new System.Drawing.Point(15, 255);
            this.listViewOrder.Name = "listViewOrder";
            this.listViewOrder.Size = new System.Drawing.Size(773, 183);
            this.listViewOrder.TabIndex = 12;
            this.listViewOrder.UseCompatibleStateImageBehavior = false;
            this.listViewOrder.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Order Number";
            this.columnHeader1.Width = 93;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Client ID";
            this.columnHeader2.Width = 88;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Product ID";
            this.columnHeader3.Width = 98;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Quantity";
            this.columnHeader4.Width = 77;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Order By";
            this.columnHeader5.Width = 92;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Payment";
            this.columnHeader6.Width = 77;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Client\'s Require Date";
            this.columnHeader7.Width = 111;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Shipping Date";
            this.columnHeader8.Width = 129;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Order Number";
            // 
            // textBoxOrderNumber
            // 
            this.textBoxOrderNumber.Location = new System.Drawing.Point(130, 10);
            this.textBoxOrderNumber.Name = "textBoxOrderNumber";
            this.textBoxOrderNumber.Size = new System.Drawing.Size(100, 20);
            this.textBoxOrderNumber.TabIndex = 14;
            // 
            // textBoxOrderQuantity
            // 
            this.textBoxOrderQuantity.Location = new System.Drawing.Point(130, 107);
            this.textBoxOrderQuantity.Name = "textBoxOrderQuantity";
            this.textBoxOrderQuantity.Size = new System.Drawing.Size(100, 20);
            this.textBoxOrderQuantity.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Quantity";
            // 
            // buttonOrderDelete
            // 
            this.buttonOrderDelete.Enabled = false;
            this.buttonOrderDelete.Location = new System.Drawing.Point(310, 139);
            this.buttonOrderDelete.Name = "buttonOrderDelete";
            this.buttonOrderDelete.Size = new System.Drawing.Size(85, 42);
            this.buttonOrderDelete.TabIndex = 49;
            this.buttonOrderDelete.Text = "Delete";
            this.buttonOrderDelete.UseVisualStyleBackColor = true;
            this.buttonOrderDelete.Click += new System.EventHandler(this.buttonOrderDelete_Click);
            // 
            // buttonOrderUpdate
            // 
            this.buttonOrderUpdate.Enabled = false;
            this.buttonOrderUpdate.Location = new System.Drawing.Point(310, 77);
            this.buttonOrderUpdate.Name = "buttonOrderUpdate";
            this.buttonOrderUpdate.Size = new System.Drawing.Size(85, 43);
            this.buttonOrderUpdate.TabIndex = 48;
            this.buttonOrderUpdate.Text = "Update";
            this.buttonOrderUpdate.UseVisualStyleBackColor = true;
            this.buttonOrderUpdate.Click += new System.EventHandler(this.buttonOrderUpdate_Click);
            // 
            // buttonOrderSave
            // 
            this.buttonOrderSave.Location = new System.Drawing.Point(310, 18);
            this.buttonOrderSave.Name = "buttonOrderSave";
            this.buttonOrderSave.Size = new System.Drawing.Size(85, 42);
            this.buttonOrderSave.TabIndex = 47;
            this.buttonOrderSave.Text = "Save";
            this.buttonOrderSave.UseVisualStyleBackColor = true;
            this.buttonOrderSave.Click += new System.EventHandler(this.buttonOrderSave_Click);
            // 
            // buttonOrderList
            // 
            this.buttonOrderList.Location = new System.Drawing.Point(310, 201);
            this.buttonOrderList.Name = "buttonOrderList";
            this.buttonOrderList.Size = new System.Drawing.Size(85, 42);
            this.buttonOrderList.TabIndex = 50;
            this.buttonOrderList.Text = "List All";
            this.buttonOrderList.UseVisualStyleBackColor = true;
            this.buttonOrderList.Click += new System.EventHandler(this.buttonOrderList_Click);
            // 
            // buttonOrderSearch
            // 
            this.buttonOrderSearch.Location = new System.Drawing.Point(579, 139);
            this.buttonOrderSearch.Name = "buttonOrderSearch";
            this.buttonOrderSearch.Size = new System.Drawing.Size(85, 42);
            this.buttonOrderSearch.TabIndex = 51;
            this.buttonOrderSearch.Text = "Search";
            this.buttonOrderSearch.UseVisualStyleBackColor = true;
            this.buttonOrderSearch.Click += new System.EventHandler(this.buttonOrderSearch_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(553, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(136, 13);
            this.label9.TabIndex = 52;
            this.label9.Text = "Please Enter Order Number";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(556, 107);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(133, 20);
            this.textBoxSearch.TabIndex = 53;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            this.textBoxSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSearch_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(33, 206);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 13);
            this.label10.TabIndex = 54;
            this.label10.Text = "(MM/DD/YYYY)";
            // 
            // FormOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.buttonOrderSearch);
            this.Controls.Add(this.buttonOrderList);
            this.Controls.Add(this.buttonOrderDelete);
            this.Controls.Add(this.buttonOrderUpdate);
            this.Controls.Add(this.buttonOrderSave);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxOrderQuantity);
            this.Controls.Add(this.textBoxOrderNumber);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.listViewOrder);
            this.Controls.Add(this.maskedTextBoxShippingDate);
            this.Controls.Add(this.maskedTextBoxRequireDate);
            this.Controls.Add(this.labelPayment);
            this.Controls.Add(this.textBoxOrderProductID);
            this.Controls.Add(this.textBoxOrderClientID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxOrderBy);
            this.Controls.Add(this.label1);
            this.Name = "FormOrders";
            this.Text = "FormOrders";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxOrderBy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxOrderClientID;
        private System.Windows.Forms.TextBox textBoxOrderProductID;
        private System.Windows.Forms.Label labelPayment;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxRequireDate;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxShippingDate;
        private System.Windows.Forms.ListView listViewOrder;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxOrderNumber;
        private System.Windows.Forms.TextBox textBoxOrderQuantity;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonOrderDelete;
        private System.Windows.Forms.Button buttonOrderUpdate;
        private System.Windows.Forms.Button buttonOrderSave;
        private System.Windows.Forms.Button buttonOrderList;
        private System.Windows.Forms.Button buttonOrderSearch;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label label10;
    }
}