namespace GUI
{
    partial class SPViewer
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
            pbImage = new PictureBox();
            lbID = new Label();
            lbName = new Label();
            lbPrice = new Label();
            lbQuantity = new Label();
            panel1 = new Panel();
            lbInfomation = new Label();
            ((System.ComponentModel.ISupportInitialize)pbImage).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pbImage
            // 
            pbImage.BorderStyle = BorderStyle.FixedSingle;
            pbImage.Dock = DockStyle.Fill;
            pbImage.ErrorImage = Properties.Resources.icons8_product_90;
            pbImage.Image = Properties.Resources.icons8_product_90;
            pbImage.ImageLocation = "";
            pbImage.Location = new Point(0, 0);
            pbImage.Name = "pbImage";
            pbImage.Size = new Size(194, 135);
            pbImage.SizeMode = PictureBoxSizeMode.Zoom;
            pbImage.TabIndex = 0;
            pbImage.TabStop = false;
            pbImage.Click += SPViewer_Click;
            // 
            // lbID
            // 
            lbID.AutoSize = true;
            lbID.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbID.Location = new Point(3, 141);
            lbID.Name = "lbID";
            lbID.Size = new Size(17, 15);
            lbID.TabIndex = 1;
            lbID.Text = "id";
            lbID.Click += SPViewer_Click;
            // 
            // lbName
            // 
            lbName.AllowDrop = true;
            lbName.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbName.Location = new Point(3, 166);
            lbName.Name = "lbName";
            lbName.Size = new Size(194, 52);
            lbName.TabIndex = 2;
            lbName.Text = "Name";
            lbName.Click += SPViewer_Click;
            // 
            // lbPrice
            // 
            lbPrice.AutoSize = true;
            lbPrice.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbPrice.ForeColor = Color.Brown;
            lbPrice.Location = new Point(3, 270);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new Size(43, 20);
            lbPrice.TabIndex = 5;
            lbPrice.Text = "Price";
            lbPrice.Click += SPViewer_Click;
            // 
            // lbQuantity
            // 
            lbQuantity.AutoSize = true;
            lbQuantity.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbQuantity.Location = new Point(144, 141);
            lbQuantity.Name = "lbQuantity";
            lbQuantity.Size = new Size(53, 15);
            lbQuantity.TabIndex = 7;
            lbQuantity.Text = "Quantity";
            lbQuantity.Click += SPViewer_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(pbImage);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(194, 135);
            panel1.TabIndex = 8;
            // 
            // lbInfomation
            // 
            lbInfomation.AllowDrop = true;
            lbInfomation.BorderStyle = BorderStyle.FixedSingle;
            lbInfomation.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbInfomation.Location = new Point(3, 218);
            lbInfomation.Name = "lbInfomation";
            lbInfomation.Size = new Size(194, 43);
            lbInfomation.TabIndex = 9;
            lbInfomation.Text = "Infomation";
            lbInfomation.Click += SPViewer_Click;
            // 
            // SPViewer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(lbInfomation);
            Controls.Add(panel1);
            Controls.Add(lbQuantity);
            Controls.Add(lbPrice);
            Controls.Add(lbName);
            Controls.Add(lbID);
            Name = "SPViewer";
            Size = new Size(200, 300);
            Click += SPViewer_Click;
            ((System.ComponentModel.ISupportInitialize)pbImage).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbImage;
        private Label lbID;
        private Label lbName;
        private Label lbPrice;
        private Label lbQuantity;
        private Panel panel1;
        private Label lbInfomation;
    }
}
