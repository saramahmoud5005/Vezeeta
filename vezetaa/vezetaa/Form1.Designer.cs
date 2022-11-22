
namespace vezetaa
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.home1 = new vezetaa.Home();
            this.displayPurchasesReport1 = new vezetaa.DisplayPurchasesReport();
            this.displayAppointmentsReport1 = new vezetaa.DisplayAppointmentsReport();
            this.deleteAppointementForm1 = new vezetaa.DeleteAppointementForm();
            this.buyProductForm1 = new vezetaa.BuyProductForm();
            this.bookAppointmentForm1 = new vezetaa.BookAppointmentForm();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(16, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(244, 524);
            this.panel1.TabIndex = 0;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Honeydew;
            this.button5.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold);
            this.button5.Location = new System.Drawing.Point(28, 432);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(153, 63);
            this.button5.TabIndex = 5;
            this.button5.Text = "Display Purchases Report";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Honeydew;
            this.button4.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold);
            this.button4.Location = new System.Drawing.Point(28, 327);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(153, 75);
            this.button4.TabIndex = 4;
            this.button4.Text = "Display Appointement Report";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Honeydew;
            this.button2.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(28, 135);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 63);
            this.button2.TabIndex = 2;
            this.button2.Text = "Buy Product";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Honeydew;
            this.button3.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold);
            this.button3.Location = new System.Drawing.Point(28, 235);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(153, 52);
            this.button3.TabIndex = 3;
            this.button3.Text = "Delete Appointement";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Honeydew;
            this.button1.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(28, 37);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 65);
            this.button1.TabIndex = 1;
            this.button1.Text = "Book Appointement";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // home1
            // 
            this.home1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.home1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.home1.Location = new System.Drawing.Point(269, 15);
            this.home1.Margin = new System.Windows.Forms.Padding(5);
            this.home1.Name = "home1";
            this.home1.Size = new System.Drawing.Size(1213, 577);
            this.home1.TabIndex = 6;
            this.home1.Load += new System.EventHandler(this.home1_Load);
            // 
            // displayPurchasesReport1
            // 
            this.displayPurchasesReport1.BackColor = System.Drawing.Color.MintCream;
            this.displayPurchasesReport1.Location = new System.Drawing.Point(269, 15);
            this.displayPurchasesReport1.Margin = new System.Windows.Forms.Padding(5);
            this.displayPurchasesReport1.Name = "displayPurchasesReport1";
            this.displayPurchasesReport1.Size = new System.Drawing.Size(1213, 577);
            this.displayPurchasesReport1.TabIndex = 5;
            // 
            // displayAppointmentsReport1
            // 
            this.displayAppointmentsReport1.BackColor = System.Drawing.Color.MintCream;
            this.displayAppointmentsReport1.Location = new System.Drawing.Point(269, 15);
            this.displayAppointmentsReport1.Margin = new System.Windows.Forms.Padding(5);
            this.displayAppointmentsReport1.Name = "displayAppointmentsReport1";
            this.displayAppointmentsReport1.Size = new System.Drawing.Size(1213, 577);
            this.displayAppointmentsReport1.TabIndex = 4;
            // 
            // deleteAppointementForm1
            // 
            this.deleteAppointementForm1.BackColor = System.Drawing.Color.MintCream;
            this.deleteAppointementForm1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.deleteAppointementForm1.Location = new System.Drawing.Point(269, 15);
            this.deleteAppointementForm1.Margin = new System.Windows.Forms.Padding(5);
            this.deleteAppointementForm1.Name = "deleteAppointementForm1";
            this.deleteAppointementForm1.Size = new System.Drawing.Size(1213, 577);
            this.deleteAppointementForm1.TabIndex = 3;
            // 
            // buyProductForm1
            // 
            this.buyProductForm1.BackColor = System.Drawing.Color.MintCream;
            this.buyProductForm1.Location = new System.Drawing.Point(269, 15);
            this.buyProductForm1.Margin = new System.Windows.Forms.Padding(5);
            this.buyProductForm1.Name = "buyProductForm1";
            this.buyProductForm1.Size = new System.Drawing.Size(1213, 577);
            this.buyProductForm1.TabIndex = 2;
            // 
            // bookAppointmentForm1
            // 
            this.bookAppointmentForm1.BackColor = System.Drawing.Color.MintCream;
            this.bookAppointmentForm1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.bookAppointmentForm1.Location = new System.Drawing.Point(269, 15);
            this.bookAppointmentForm1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.bookAppointmentForm1.Name = "bookAppointmentForm1";
            this.bookAppointmentForm1.Size = new System.Drawing.Size(1213, 577);
            this.bookAppointmentForm1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1500, 617);
            this.Controls.Add(this.home1);
            this.Controls.Add(this.displayPurchasesReport1);
            this.Controls.Add(this.displayAppointmentsReport1);
            this.Controls.Add(this.deleteAppointementForm1);
            this.Controls.Add(this.buyProductForm1);
            this.Controls.Add(this.bookAppointmentForm1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private BookAppointmentForm bookAppointmentForm1;
        private BuyProductForm buyProductForm1;
        private DeleteAppointementForm deleteAppointementForm1;
        private DisplayAppointmentsReport displayAppointmentsReport1;
        private DisplayPurchasesReport displayPurchasesReport1;
        private Home home1;
    }
}

