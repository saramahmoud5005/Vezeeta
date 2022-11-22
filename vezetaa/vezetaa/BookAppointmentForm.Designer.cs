
namespace vezetaa
{
    partial class BookAppointmentForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_showDoctors = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_specialities = new System.Windows.Forms.ComboBox();
            this.Doctors = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.list_Appointements = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_book = new System.Windows.Forms.Button();
            this.btn_appointement = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_showDoctors
            // 
            this.btn_showDoctors.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_showDoctors.Location = new System.Drawing.Point(429, 44);
            this.btn_showDoctors.Margin = new System.Windows.Forms.Padding(4);
            this.btn_showDoctors.Name = "btn_showDoctors";
            this.btn_showDoctors.Size = new System.Drawing.Size(135, 40);
            this.btn_showDoctors.TabIndex = 0;
            this.btn_showDoctors.Text = "show Doctors";
            this.btn_showDoctors.UseVisualStyleBackColor = false;
            this.btn_showDoctors.Click += new System.EventHandler(this.btn_showDoctors_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.Location = new System.Drawing.Point(20, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Specialities";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmb_specialities
            // 
            this.cmb_specialities.FormattingEnabled = true;
            this.cmb_specialities.Location = new System.Drawing.Point(151, 44);
            this.cmb_specialities.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_specialities.Name = "cmb_specialities";
            this.cmb_specialities.Size = new System.Drawing.Size(201, 36);
            this.cmb_specialities.TabIndex = 2;
            // 
            // Doctors
            // 
            this.Doctors.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.Doctors.FullRowSelect = true;
            this.Doctors.GridLines = true;
            this.Doctors.HideSelection = false;
            this.Doctors.Location = new System.Drawing.Point(25, 164);
            this.Doctors.Margin = new System.Windows.Forms.Padding(4);
            this.Doctors.Name = "Doctors";
            this.Doctors.Size = new System.Drawing.Size(407, 213);
            this.Doctors.TabIndex = 3;
            this.Doctors.UseCompatibleStateImageBehavior = false;
            this.Doctors.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Hospital";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Location";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Phone_Number";
            this.columnHeader4.Width = 100;
            // 
            // list_Appointements
            // 
            this.list_Appointements.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6});
            this.list_Appointements.FullRowSelect = true;
            this.list_Appointements.GridLines = true;
            this.list_Appointements.HideSelection = false;
            this.list_Appointements.Location = new System.Drawing.Point(667, 164);
            this.list_Appointements.Margin = new System.Windows.Forms.Padding(4);
            this.list_Appointements.Name = "list_Appointements";
            this.list_Appointements.Size = new System.Drawing.Size(205, 213);
            this.list_Appointements.TabIndex = 4;
            this.list_Appointements.UseCompatibleStateImageBehavior = false;
            this.list_Appointements.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Date";
            this.columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Time";
            this.columnHeader6.Width = 100;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.Location = new System.Drawing.Point(663, 129);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 28);
            this.label2.TabIndex = 5;
            this.label2.Text = "Avaliable appointements";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.Location = new System.Drawing.Point(21, 129);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 28);
            this.label3.TabIndex = 6;
            this.label3.Text = "Doctors";
            // 
            // btn_book
            // 
            this.btn_book.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_book.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_book.Location = new System.Drawing.Point(466, 403);
            this.btn_book.Margin = new System.Windows.Forms.Padding(4);
            this.btn_book.Name = "btn_book";
            this.btn_book.Size = new System.Drawing.Size(156, 42);
            this.btn_book.TabIndex = 7;
            this.btn_book.Text = "Book";
            this.btn_book.UseVisualStyleBackColor = false;
            this.btn_book.Click += new System.EventHandler(this.btn_book_Click);
            // 
            // btn_appointement
            // 
            this.btn_appointement.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_appointement.Location = new System.Drawing.Point(466, 200);
            this.btn_appointement.Margin = new System.Windows.Forms.Padding(4);
            this.btn_appointement.Name = "btn_appointement";
            this.btn_appointement.Size = new System.Drawing.Size(156, 37);
            this.btn_appointement.TabIndex = 8;
            this.btn_appointement.Text = "Appointements >>";
            this.btn_appointement.UseVisualStyleBackColor = false;
            this.btn_appointement.Click += new System.EventHandler(this.btn_appointement_Click);
            // 
            // BookAppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.Controls.Add(this.btn_appointement);
            this.Controls.Add(this.btn_book);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.list_Appointements);
            this.Controls.Add(this.Doctors);
            this.Controls.Add(this.cmb_specialities);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_showDoctors);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "BookAppointmentForm";
            this.Size = new System.Drawing.Size(910, 469);
            this.Load += new System.EventHandler(this.BookAppointmentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_showDoctors;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_specialities;
        private System.Windows.Forms.ListView Doctors;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ListView list_Appointements;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_book;
        private System.Windows.Forms.Button btn_appointement;
    }

}
