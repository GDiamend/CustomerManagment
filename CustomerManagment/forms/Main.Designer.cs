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
            this.SuspendLayout();
            // 
            // btnCustomerManagment
            // 
            this.btnCustomerManagment.Location = new System.Drawing.Point(172, 257);
            this.btnCustomerManagment.Name = "btnCustomerManagment";
            this.btnCustomerManagment.Size = new System.Drawing.Size(116, 63);
            this.btnCustomerManagment.TabIndex = 0;
            this.btnCustomerManagment.Text = "Customer Managment";
            this.btnCustomerManagment.UseVisualStyleBackColor = true;
            this.btnCustomerManagment.Click += new System.EventHandler(this.btnCustomerManagment_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCustomerManagment);
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnCustomerManagment;
    }
}