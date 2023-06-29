
namespace regal_spice
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.orderNumber = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.dateandtime = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.totalPaid = new System.Windows.Forms.Label();
            this.sumTotal = new System.Windows.Forms.Label();
            this.changeDue = new System.Windows.Forms.Label();
            this.commentReceipt = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.listView1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.orderNumber, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.changeDue, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.totalPaid, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.sumTotal, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.dateandtime, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.commentReceipt, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(28, 45);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.16049F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 72.83951F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(309, 434);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // orderNumber
            // 
            this.orderNumber.AutoSize = true;
            this.orderNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderNumber.Location = new System.Drawing.Point(3, 0);
            this.orderNumber.Name = "orderNumber";
            this.orderNumber.Padding = new System.Windows.Forms.Padding(70, 45, 0, 0);
            this.orderNumber.Size = new System.Drawing.Size(239, 71);
            this.orderNumber.TabIndex = 2;
            this.orderNumber.Text = "Order Number";
            this.orderNumber.Click += new System.EventHandler(this.label1_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 74);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(303, 182);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // dateandtime
            // 
            this.dateandtime.AutoSize = true;
            this.dateandtime.Location = new System.Drawing.Point(3, 305);
            this.dateandtime.Name = "dateandtime";
            this.dateandtime.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.dateandtime.Size = new System.Drawing.Size(157, 30);
            this.dateandtime.TabIndex = 4;
            this.dateandtime.Text = "Exact Date and Time";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(364, 33);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(34, 28);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(101, 28);
            this.toolStripLabel1.Text = "Main Menu";
            this.toolStripLabel1.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // totalPaid
            // 
            this.totalPaid.AutoSize = true;
            this.totalPaid.Location = new System.Drawing.Point(3, 373);
            this.totalPaid.Name = "totalPaid";
            this.totalPaid.Size = new System.Drawing.Size(100, 20);
            this.totalPaid.TabIndex = 5;
            this.totalPaid.Text = "Paid Amount";
            this.totalPaid.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // sumTotal
            // 
            this.sumTotal.AutoSize = true;
            this.sumTotal.Location = new System.Drawing.Point(3, 340);
            this.sumTotal.Name = "sumTotal";
            this.sumTotal.Size = new System.Drawing.Size(96, 20);
            this.sumTotal.TabIndex = 6;
            this.sumTotal.Text = "Amount due";
            // 
            // changeDue
            // 
            this.changeDue.AutoSize = true;
            this.changeDue.Location = new System.Drawing.Point(3, 403);
            this.changeDue.Name = "changeDue";
            this.changeDue.Size = new System.Drawing.Size(96, 20);
            this.changeDue.TabIndex = 7;
            this.changeDue.Text = "Change due";
            // 
            // commentReceipt
            // 
            this.commentReceipt.AutoSize = true;
            this.commentReceipt.Location = new System.Drawing.Point(3, 263);
            this.commentReceipt.Name = "commentReceipt";
            this.commentReceipt.Size = new System.Drawing.Size(82, 20);
            this.commentReceipt.TabIndex = 8;
            this.commentReceipt.Text = "Comment:";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 502);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label orderNumber;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label dateandtime;
        private System.Windows.Forms.Label totalPaid;
        private System.Windows.Forms.Label sumTotal;
        private System.Windows.Forms.Label changeDue;
        private System.Windows.Forms.Label commentReceipt;
    }
}