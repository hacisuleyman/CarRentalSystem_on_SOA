namespace CarRental.WinFormUI
{
    partial class MainForm
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
            this.txtList = new System.Windows.Forms.TextBox();
            this.txtcarID = new System.Windows.Forms.TextBox();
            this.btnBook = new System.Windows.Forms.Button();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtCustomerLastname = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtList
            // 
            this.txtList.Location = new System.Drawing.Point(33, 25);
            this.txtList.Multiline = true;
            this.txtList.Name = "txtList";
            this.txtList.Size = new System.Drawing.Size(667, 197);
            this.txtList.TabIndex = 0;
            // 
            // txtcarID
            // 
            this.txtcarID.Location = new System.Drawing.Point(33, 299);
            this.txtcarID.Name = "txtcarID";
            this.txtcarID.Size = new System.Drawing.Size(69, 20);
            this.txtcarID.TabIndex = 2;
            // 
            // btnBook
            // 
            this.btnBook.Location = new System.Drawing.Point(118, 273);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(75, 23);
            this.btnBook.TabIndex = 3;
            this.btnBook.Text = "BOOK";
            this.btnBook.UseVisualStyleBackColor = true;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(33, 244);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(69, 20);
            this.txtCustomerName.TabIndex = 2;
            // 
            // txtCustomerLastname
            // 
            this.txtCustomerLastname.Location = new System.Drawing.Point(33, 273);
            this.txtCustomerLastname.Name = "txtCustomerLastname";
            this.txtCustomerLastname.Size = new System.Drawing.Size(69, 20);
            this.txtCustomerLastname.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 352);
            this.Controls.Add(this.btnBook);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.txtCustomerLastname);
            this.Controls.Add(this.txtcarID);
            this.Controls.Add(this.txtList);
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtList;
        private System.Windows.Forms.TextBox txtcarID;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtCustomerLastname;
    }
}

