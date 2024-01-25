using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;



namespace WinFormsApp1
{
    partial class SignUp
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtEmpleeID = new TextBox();
            txtFirstName = new TextBox();
            label3 = new Label();
            txtLastName = new TextBox();
            label4 = new Label();
            txtPrimaryOffering = new TextBox();
            label5 = new Label();
            label6 = new Label();
            txtSecondaryOffering = new TextBox();
            btnSignUp = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Emoji", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(395, 53);
            label1.Name = "label1";
            label1.Size = new Size(151, 48);
            label1.TabIndex = 0;
            label1.Text = "Sign UP";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(47, 132);
            label2.Name = "label2";
            label2.Size = new Size(183, 38);
            label2.TabIndex = 1;
            label2.Text = "EmployeeID:";
            label2.Click += label2_Click;
            // 
            // txtEmpleeID
            // 
            txtEmpleeID.AllowDrop = true;
            txtEmpleeID.Location = new Point(323, 140);
            txtEmpleeID.Name = "txtEmpleeID";
            txtEmpleeID.Size = new Size(360, 31);
            txtEmpleeID.TabIndex = 2;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(323, 213);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(360, 31);
            txtFirstName.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(47, 205);
            label3.Name = "label3";
            label3.Size = new Size(152, 38);
            label3.TabIndex = 3;
            label3.Text = "FirstName";
            label3.Click += label3_Click;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(323, 272);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(360, 31);
            txtLastName.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(47, 265);
            label4.Name = "label4";
            label4.Size = new Size(147, 38);
            label4.TabIndex = 5;
            label4.Text = "LastName";
            label4.Click += label4_Click;
            // 
            // txtPrimaryOffering
            // 
            txtPrimaryOffering.Location = new Point(323, 345);
            txtPrimaryOffering.Name = "txtPrimaryOffering";
            txtPrimaryOffering.Size = new Size(360, 31);
            txtPrimaryOffering.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(47, 337);
            label5.Name = "label5";
            label5.Size = new Size(232, 38);
            label5.TabIndex = 7;
            label5.Text = "PrimaryOffering";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(47, 391);
            label6.Name = "label6";
            label6.Size = new Size(265, 38);
            label6.TabIndex = 9;
            label6.Text = "SecondaryOffering";
            label6.Click += label1_Click;
            // 
            // txtSecondaryOffering
            // 
            txtSecondaryOffering.Location = new Point(323, 399);
            txtSecondaryOffering.Name = "txtSecondaryOffering";
            txtSecondaryOffering.Size = new Size(360, 31);
            txtSecondaryOffering.TabIndex = 10;
            // 
            // btnSignUp
            // 
            btnSignUp.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSignUp.Location = new Point(562, 505);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(121, 35);
            btnSignUp.TabIndex = 11;
            btnSignUp.Text = "SignUp";
            btnSignUp.UseVisualStyleBackColor = true;
            btnSignUp.Click += btnSignUp_Click_1;
            // 
            // SignUp
            // 
            AccessibleRole = AccessibleRole.TitleBar;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(812, 576);
            Controls.Add(btnSignUp);
            Controls.Add(txtSecondaryOffering);
            Controls.Add(label6);
            Controls.Add(txtPrimaryOffering);
            Controls.Add(label5);
            Controls.Add(txtLastName);
            Controls.Add(label4);
            Controls.Add(txtFirstName);
            Controls.Add(label3);
            Controls.Add(txtEmpleeID);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "SignUp";
            Text = "SignUp";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtEmpleeID;
        private TextBox txtFirstName;
        private Label label3;
        private TextBox txtLastName;
        private Label label4;
        private TextBox txtPrimaryOffering;
        private Label label5;
        private Label label6;
        private TextBox txtSecondaryOffering;
        private Button btnSignUp;
    }
}
