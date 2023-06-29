
namespace regal_spice
{
    partial class mainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainMenu));
            this.orderprocess = new System.Windows.Forms.Button();
            this.revenue = new System.Windows.Forms.Button();
            this.settings = new System.Windows.Forms.Button();
            this.Logout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // orderprocess
            // 
            this.orderprocess.BackColor = System.Drawing.Color.DarkSalmon;
            this.orderprocess.DialogResult = System.Windows.Forms.DialogResult.No;
            this.orderprocess.Location = new System.Drawing.Point(100, 240);
            this.orderprocess.Name = "orderprocess";
            this.orderprocess.Size = new System.Drawing.Size(165, 110);
            this.orderprocess.TabIndex = 0;
            this.orderprocess.Text = "Order Processing";
            this.orderprocess.UseVisualStyleBackColor = false;
            this.orderprocess.Click += new System.EventHandler(this.orderprocess_Click);
            // 
            // revenue
            // 
            this.revenue.BackColor = System.Drawing.Color.DarkSalmon;
            this.revenue.Location = new System.Drawing.Point(316, 240);
            this.revenue.Name = "revenue";
            this.revenue.Size = new System.Drawing.Size(182, 110);
            this.revenue.TabIndex = 1;
            this.revenue.Text = "Revenue";
            this.revenue.UseVisualStyleBackColor = false;
            this.revenue.Click += new System.EventHandler(this.revenue_Click);
            // 
            // settings
            // 
            this.settings.BackColor = System.Drawing.Color.DarkSalmon;
            this.settings.Location = new System.Drawing.Point(544, 240);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(182, 110);
            this.settings.TabIndex = 3;
            this.settings.Text = "Settings";
            this.settings.UseVisualStyleBackColor = false;
            this.settings.Click += new System.EventHandler(this.settings_Click);
            // 
            // Logout
            // 
            this.Logout.BackColor = System.Drawing.Color.DarkSalmon;
            this.Logout.Location = new System.Drawing.Point(381, 399);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(75, 32);
            this.Logout.TabIndex = 4;
            this.Logout.Text = "Logout";
            this.Logout.UseVisualStyleBackColor = false;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // mainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(826, 606);
            this.Controls.Add(this.Logout);
            this.Controls.Add(this.settings);
            this.Controls.Add(this.revenue);
            this.Controls.Add(this.orderprocess);
            this.DoubleBuffered = true;
            this.Name = "mainMenu";
            this.Text = "Form3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button orderprocess;
        private System.Windows.Forms.Button revenue;
        private System.Windows.Forms.Button settings;
        private System.Windows.Forms.Button Logout;
    }
}