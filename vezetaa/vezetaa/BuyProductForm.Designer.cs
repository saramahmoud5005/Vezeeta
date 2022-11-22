
namespace vezetaa
{
    partial class BuyProductForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.productTxt = new System.Windows.Forms.TextBox();
            this.view = new System.Windows.Forms.Button();
            this.viewTxt = new System.Windows.Forms.TextBox();
            this.incCount = new System.Windows.Forms.Button();
            this.decCount = new System.Windows.Forms.Button();
            this.countTxt = new System.Windows.Forms.TextBox();
            this.buy = new System.Windows.Forms.Button();
            this.countt = new System.Windows.Forms.Label();
            this.Productinfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.Location = new System.Drawing.Point(39, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Search for products";
            // 
            // productTxt
            // 
            this.productTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.productTxt.Location = new System.Drawing.Point(273, 76);
            this.productTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.productTxt.Name = "productTxt";
            this.productTxt.Size = new System.Drawing.Size(324, 26);
            this.productTxt.TabIndex = 3;
            this.productTxt.TextChanged += new System.EventHandler(this.productTxt_TextChanged);
            // 
            // view
            // 
            this.view.BackColor = System.Drawing.Color.WhiteSmoke;
            this.view.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.view.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.view.ForeColor = System.Drawing.SystemColors.ControlText;
            this.view.Location = new System.Drawing.Point(409, 264);
            this.view.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.view.Name = "view";
            this.view.Size = new System.Drawing.Size(147, 52);
            this.view.TabIndex = 4;
            this.view.Text = "View";
            this.view.UseVisualStyleBackColor = false;
            this.view.Click += new System.EventHandler(this.view_Click);
            // 
            // viewTxt
            // 
            this.viewTxt.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.viewTxt.Location = new System.Drawing.Point(651, 249);
            this.viewTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.viewTxt.Multiline = true;
            this.viewTxt.Name = "viewTxt";
            this.viewTxt.Size = new System.Drawing.Size(408, 149);
            this.viewTxt.TabIndex = 5;
            this.viewTxt.TextChanged += new System.EventHandler(this.viewTxt_TextChanged);
            // 
            // incCount
            // 
            this.incCount.BackColor = System.Drawing.Color.WhiteSmoke;
            this.incCount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.incCount.Location = new System.Drawing.Point(663, 454);
            this.incCount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.incCount.Name = "incCount";
            this.incCount.Size = new System.Drawing.Size(43, 36);
            this.incCount.TabIndex = 6;
            this.incCount.Text = "+";
            this.incCount.UseVisualStyleBackColor = false;
            this.incCount.Click += new System.EventHandler(this.button2_Click);
            // 
            // decCount
            // 
            this.decCount.BackColor = System.Drawing.Color.WhiteSmoke;
            this.decCount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.decCount.Location = new System.Drawing.Point(483, 454);
            this.decCount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.decCount.Name = "decCount";
            this.decCount.Size = new System.Drawing.Size(43, 36);
            this.decCount.TabIndex = 7;
            this.decCount.Text = "-";
            this.decCount.UseVisualStyleBackColor = false;
            this.decCount.Click += new System.EventHandler(this.decCount_Click);
            // 
            // countTxt
            // 
            this.countTxt.Location = new System.Drawing.Point(551, 463);
            this.countTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.countTxt.Name = "countTxt";
            this.countTxt.Size = new System.Drawing.Size(84, 22);
            this.countTxt.TabIndex = 8;
            this.countTxt.TextChanged += new System.EventHandler(this.countTxt_TextChanged);
            // 
            // buy
            // 
            this.buy.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buy.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.buy.Location = new System.Drawing.Point(189, 522);
            this.buy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buy.Name = "buy";
            this.buy.Size = new System.Drawing.Size(140, 52);
            this.buy.TabIndex = 9;
            this.buy.Text = "Buy";
            this.buy.UseVisualStyleBackColor = false;
            this.buy.Click += new System.EventHandler(this.buy_Click);
            // 
            // countt
            // 
            this.countt.AutoSize = true;
            this.countt.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.countt.Location = new System.Drawing.Point(372, 455);
            this.countt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.countt.Name = "countt";
            this.countt.Size = new System.Drawing.Size(76, 32);
            this.countt.TabIndex = 10;
            this.countt.Text = "count";
            this.countt.Click += new System.EventHandler(this.label1_Click);
            // 
            // Productinfo
            // 
            this.Productinfo.AutoSize = true;
            this.Productinfo.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.Productinfo.Location = new System.Drawing.Point(644, 214);
            this.Productinfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Productinfo.Name = "Productinfo";
            this.Productinfo.Size = new System.Drawing.Size(252, 32);
            this.Productinfo.TabIndex = 11;
            this.Productinfo.Text = "Product\'s  information";
            // 
            // BuyProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.Controls.Add(this.Productinfo);
            this.Controls.Add(this.countt);
            this.Controls.Add(this.buy);
            this.Controls.Add(this.countTxt);
            this.Controls.Add(this.decCount);
            this.Controls.Add(this.incCount);
            this.Controls.Add(this.viewTxt);
            this.Controls.Add(this.view);
            this.Controls.Add(this.productTxt);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "BuyProductForm";
            this.Size = new System.Drawing.Size(1213, 577);
            this.Load += new System.EventHandler(this.BuyProductForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox productTxt;
        private System.Windows.Forms.Button view;
        private System.Windows.Forms.TextBox viewTxt;
        private System.Windows.Forms.Button incCount;
        private System.Windows.Forms.Button decCount;
        private System.Windows.Forms.TextBox countTxt;
        private System.Windows.Forms.Button buy;
        private System.Windows.Forms.Label countt;
        private System.Windows.Forms.Label Productinfo;
    }
}
