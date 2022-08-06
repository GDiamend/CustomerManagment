namespace CustomerManagment.forms
{
    partial class Main
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
            this.btnCustomerManagment = new System.Windows.Forms.Button();
            this.btnBillManagment = new System.Windows.Forms.Button();
            this.lblFacturationSystem = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCustomerManagment
            // 
            this.btnCustomerManagment.Location = new System.Drawing.Point(61, 141);
            this.btnCustomerManagment.Name = "btnCustomerManagment";
            this.btnCustomerManagment.Size = new System.Drawing.Size(116, 63);
            this.btnCustomerManagment.TabIndex = 0;
            this.btnCustomerManagment.Text = "Customer Managment";
            this.btnCustomerManagment.UseVisualStyleBackColor = true;
            this.btnCustomerManagment.Click += new System.EventHandler(this.btnCustomerManagment_Click);
            // 
            // btnBillManagment
            // 
            this.btnBillManagment.Location = new System.Drawing.Point(223, 141);
            this.btnBillManagment.Name = "btnBillManagment";
            this.btnBillManagment.Size = new System.Drawing.Size(116, 63);
            this.btnBillManagment.TabIndex = 1;
            this.btnBillManagment.Text = "Bill Managment";
            this.btnBillManagment.UseVisualStyleBackColor = true;
            this.btnBillManagment.Click += new System.EventHandler(this.btnBillManagment_Click);
            // 
            // lblFacturationSystem
            // 
            this.lblFacturationSystem.AutoSize = true;
            this.lblFacturationSystem.Font = new System.Drawing.Font("Segoe UI Emoji", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFacturationSystem.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblFacturationSystem.Location = new System.Drawing.Point(110, 51);
            this.lblFacturationSystem.Name = "lblFacturationSystem";
            this.lblFacturationSystem.Size = new System.Drawing.Size(196, 28);
            this.lblFacturationSystem.TabIndex = 2;
            this.lblFacturationSystem.Text = "Facturation Sytem";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 259);
            this.Controls.Add(this.lblFacturationSystem);
            this.Controls.Add(this.btnBillManagment);
            this.Controls.Add(this.btnCustomerManagment);
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnCustomerManagment;
        private Button btnBillManagment;
        private Label lblFacturationSystem;
    }
}