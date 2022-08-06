namespace CustomerManagment.forms
{
    partial class BillManagment
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
            this.lblBillList = new System.Windows.Forms.Label();
            this.lstBill = new System.Windows.Forms.ListBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBillList
            // 
            this.lblBillList.AutoSize = true;
            this.lblBillList.Location = new System.Drawing.Point(2, 7);
            this.lblBillList.Name = "lblBillList";
            this.lblBillList.Size = new System.Drawing.Size(44, 15);
            this.lblBillList.TabIndex = 19;
            this.lblBillList.Text = "Bill List";
            // 
            // lstBill
            // 
            this.lstBill.FormattingEnabled = true;
            this.lstBill.ItemHeight = 15;
            this.lstBill.Location = new System.Drawing.Point(2, 28);
            this.lstBill.Name = "lstBill";
            this.lstBill.Size = new System.Drawing.Size(212, 394);
            this.lstBill.TabIndex = 18;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(252, 28);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 20;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(252, 87);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 21;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(252, 143);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 22;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // BillManagment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 436);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.lblBillList);
            this.Controls.Add(this.lstBill);
            this.Name = "BillManagment";
            this.Text = "BillManagment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblBillList;
        private ListBox lstBill;
        private Button btnInsert;
        private Button btnDelete;
        private Button btnPrint;
    }
}