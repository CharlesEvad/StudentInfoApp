namespace StudentInfoApp
{
    partial class Student_Page
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView StudentDataGridView;

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
            this.StudentDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.StudentDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // StudentDataGridView
            // 
            this.StudentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentDataGridView.Location = new System.Drawing.Point(50, 50);
            this.StudentDataGridView.Name = "StudentDataGridView";
            this.StudentDataGridView.Size = new System.Drawing.Size(600, 250);
            this.StudentDataGridView.TabIndex = 0;
            this.StudentDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentDataGridView_CellContentClick);
            // 
            // Student_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.StudentDataGridView);
            this.Name = "Student_Page";
            this.Text = "Student_Page";
            ((System.ComponentModel.ISupportInitialize)(this.StudentDataGridView)).EndInit();
            this.ResumeLayout(false);

        }
    }
}