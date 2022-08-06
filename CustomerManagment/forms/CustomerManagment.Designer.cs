namespace CustomerManagment
{
    partial class CustomerManagment
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
            this.lstCustomer = new System.Windows.Forms.ListBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtCreditCard = new System.Windows.Forms.TextBox();
            this.lblTextName = new System.Windows.Forms.Label();
            this.lblTextSurname = new System.Windows.Forms.Label();
            this.lblTextPhone = new System.Windows.Forms.Label();
            this.lblTextDni = new System.Windows.Forms.Label();
            this.lblTextCreditCard = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.lblTextId = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblCustomerList = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstCustomer
            // 
            this.lstCustomer.FormattingEnabled = true;
            this.lstCustomer.ItemHeight = 15;
            this.lstCustomer.Location = new System.Drawing.Point(3, 30);
            this.lstCustomer.Name = "lstCustomer";
            this.lstCustomer.Size = new System.Drawing.Size(212, 394);
            this.lstCustomer.TabIndex = 0;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(381, 65);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(198, 23);
            this.txtName.TabIndex = 1;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(381, 113);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(198, 23);
            this.txtSurname.TabIndex = 2;
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(381, 166);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(198, 23);
            this.txtDni.TabIndex = 3;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(381, 216);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(198, 23);
            this.txtPhone.TabIndex = 4;
            // 
            // txtCreditCard
            // 
            this.txtCreditCard.Location = new System.Drawing.Point(381, 267);
            this.txtCreditCard.Name = "txtCreditCard";
            this.txtCreditCard.Size = new System.Drawing.Size(198, 23);
            this.txtCreditCard.TabIndex = 5;
            // 
            // lblTextName
            // 
            this.lblTextName.AutoSize = true;
            this.lblTextName.Location = new System.Drawing.Point(245, 65);
            this.lblTextName.Name = "lblTextName";
            this.lblTextName.Size = new System.Drawing.Size(39, 15);
            this.lblTextName.TabIndex = 6;
            this.lblTextName.Text = "Name";
            // 
            // lblTextSurname
            // 
            this.lblTextSurname.AutoSize = true;
            this.lblTextSurname.Location = new System.Drawing.Point(245, 113);
            this.lblTextSurname.Name = "lblTextSurname";
            this.lblTextSurname.Size = new System.Drawing.Size(54, 15);
            this.lblTextSurname.TabIndex = 7;
            this.lblTextSurname.Text = "Surname";
            // 
            // lblTextPhone
            // 
            this.lblTextPhone.AutoSize = true;
            this.lblTextPhone.Location = new System.Drawing.Point(245, 216);
            this.lblTextPhone.Name = "lblTextPhone";
            this.lblTextPhone.Size = new System.Drawing.Size(41, 15);
            this.lblTextPhone.TabIndex = 8;
            this.lblTextPhone.Text = "Phone";
            // 
            // lblTextDni
            // 
            this.lblTextDni.AutoSize = true;
            this.lblTextDni.Location = new System.Drawing.Point(245, 166);
            this.lblTextDni.Name = "lblTextDni";
            this.lblTextDni.Size = new System.Drawing.Size(25, 15);
            this.lblTextDni.TabIndex = 9;
            this.lblTextDni.Text = "Dni";
            // 
            // lblTextCreditCard
            // 
            this.lblTextCreditCard.AutoSize = true;
            this.lblTextCreditCard.Location = new System.Drawing.Point(245, 267);
            this.lblTextCreditCard.Name = "lblTextCreditCard";
            this.lblTextCreditCard.Size = new System.Drawing.Size(67, 15);
            this.lblTextCreditCard.TabIndex = 10;
            this.lblTextCreditCard.Text = "Credit Card";
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(381, 321);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 11;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(245, 321);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear fields";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(504, 321);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(245, 366);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 14;
            this.btnEdit.Text = "Edit fields";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // lblTextId
            // 
            this.lblTextId.AutoSize = true;
            this.lblTextId.Location = new System.Drawing.Point(245, 30);
            this.lblTextId.Name = "lblTextId";
            this.lblTextId.Size = new System.Drawing.Size(24, 15);
            this.lblTextId.TabIndex = 15;
            this.lblTextId.Text = "ID: ";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(381, 30);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(0, 15);
            this.lblId.TabIndex = 15;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(381, 366);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblCustomerList
            // 
            this.lblCustomerList.AutoSize = true;
            this.lblCustomerList.Location = new System.Drawing.Point(3, 7);
            this.lblCustomerList.Name = "lblCustomerList";
            this.lblCustomerList.Size = new System.Drawing.Size(80, 15);
            this.lblCustomerList.TabIndex = 17;
            this.lblCustomerList.Text = "Customer List";
            // 
            // CustomerManagment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 431);
            this.Controls.Add(this.lblCustomerList);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblTextId);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.lblTextCreditCard);
            this.Controls.Add(this.lblTextDni);
            this.Controls.Add(this.lblTextPhone);
            this.Controls.Add(this.lblTextSurname);
            this.Controls.Add(this.lblTextName);
            this.Controls.Add(this.txtCreditCard);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lstCustomer);
            this.Name = "CustomerManagment";
            this.Text = "UserManagment";
            this.Load += new System.EventHandler(this.CustomerManagment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox lstCustomer;
        private TextBox txtName;
        private TextBox txtSurname;
        private TextBox txtDni;
        private TextBox txtPhone;
        private TextBox txtCreditCard;
        private Label lblTextName;
        private Label lblTextSurname;
        private Label lblTextPhone;
        private Label lblTextDni;
        private Label lblTextCreditCard;
        private Button btnInsert;
        private Button btnClear;
        private Button btnDelete;
        private Button btnEdit;
        private Label lblTextId;
        private Label lblId;
        private Button btnUpdate;
        private Label lblCustomerList;
    }
}