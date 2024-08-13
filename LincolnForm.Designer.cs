namespace CSC240_06_01_BedAndBreakfast_DG
{
    partial class LincolnForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LincolnForm));
            lincolnDescriptionLabel = new Label();
            lincolnPriceLabel = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lincolnDescriptionLabel
            // 
            lincolnDescriptionLabel.AutoSize = true;
            lincolnDescriptionLabel.Location = new Point(12, 41);
            lincolnDescriptionLabel.Name = "lincolnDescriptionLabel";
            lincolnDescriptionLabel.Size = new Size(165, 30);
            lincolnDescriptionLabel.TabIndex = 0;
            lincolnDescriptionLabel.Text = "Return to the 1850s in this \r\nlovely room with private bath.";
            // 
            // lincolnPriceLabel
            // 
            lincolnPriceLabel.AutoSize = true;
            lincolnPriceLabel.Location = new Point(51, 120);
            lincolnPriceLabel.Name = "lincolnPriceLabel";
            lincolnPriceLabel.Size = new Size(85, 15);
            lincolnPriceLabel.TabIndex = 1;
            lincolnPriceLabel.Text = "$110 per night.";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(57, 188);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(79, 101);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // LincolnForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(203, 326);
            Controls.Add(pictureBox1);
            Controls.Add(lincolnPriceLabel);
            Controls.Add(lincolnDescriptionLabel);
            Name = "LincolnForm";
            Text = "Lincoln Room";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lincolnDescriptionLabel;
        private Label lincolnPriceLabel;
        private PictureBox pictureBox1;
    }
}