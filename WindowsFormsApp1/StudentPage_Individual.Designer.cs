using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace StudentInfoApp
{
    partial class StudentPage_Individual
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblStudentInfo;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblStudentInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblStudentInfo
            // 
            this.lblStudentInfo.AutoSize = true;
            this.lblStudentInfo.Location = new System.Drawing.Point(50, 50);
            this.lblStudentInfo.Name = "lblStudentInfo";
            this.lblStudentInfo.Size = new System.Drawing.Size(0, 13);
            this.lblStudentInfo.TabIndex = 0;
            // 
            // StudentPage_Individual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblStudentInfo);
            this.Name = "StudentPage_Individual";
            this.Text = "StudentPage_Individual";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}