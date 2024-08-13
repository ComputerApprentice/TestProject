namespace CSC240_06_01_BedAndBreakfast_DG
{
    partial class UxBaileysForm
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
            UxWelcomeLabel = new Label();
            UxRateLabel = new Label();
            belleaireCheckBox = new CheckBox();
            lincolnCheckBox = new CheckBox();
            SuspendLayout();
            // 
            // UxWelcomeLabel
            // 
            UxWelcomeLabel.AutoSize = true;
            UxWelcomeLabel.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UxWelcomeLabel.Location = new Point(98, 57);
            UxWelcomeLabel.Name = "UxWelcomeLabel";
            UxWelcomeLabel.Size = new Size(248, 29);
            UxWelcomeLabel.TabIndex = 0;
            UxWelcomeLabel.Text = "Welcome to Bailey's";
            // 
            // UxRateLabel
            // 
            UxRateLabel.AutoSize = true;
            UxRateLabel.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UxRateLabel.Location = new Point(139, 130);
            UxRateLabel.Name = "UxRateLabel";
            UxRateLabel.Size = new Size(164, 25);
            UxRateLabel.TabIndex = 1;
            UxRateLabel.Text = "Check our rates";
            // 
            // belleaireCheckBox
            // 
            belleaireCheckBox.AutoSize = true;
            belleaireCheckBox.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            belleaireCheckBox.Location = new Point(139, 199);
            belleaireCheckBox.Name = "belleaireCheckBox";
            belleaireCheckBox.Size = new Size(173, 28);
            belleaireCheckBox.TabIndex = 2;
            belleaireCheckBox.Text = "Belle Aire Suite";
            belleaireCheckBox.UseVisualStyleBackColor = true;
            belleaireCheckBox.CheckedChanged += belleaireCheckBox_CheckedChanged;
            // 
            // lincolnCheckBox
            // 
            lincolnCheckBox.AutoSize = true;
            lincolnCheckBox.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lincolnCheckBox.Location = new Point(139, 273);
            lincolnCheckBox.Name = "lincolnCheckBox";
            lincolnCheckBox.Size = new Size(158, 28);
            lincolnCheckBox.TabIndex = 3;
            lincolnCheckBox.Text = "Lincoln Room";
            lincolnCheckBox.UseVisualStyleBackColor = true;
            lincolnCheckBox.CheckedChanged += lincolnCheckBox_CheckedChanged;
            // 
            // UxBaileysForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Yellow;
            ClientSize = new Size(442, 395);
            Controls.Add(lincolnCheckBox);
            Controls.Add(belleaireCheckBox);
            Controls.Add(UxRateLabel);
            Controls.Add(UxWelcomeLabel);
            Name = "UxBaileysForm";
            Text = "Bailey's Bed and Breakfast";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label UxWelcomeLabel;
        private Label UxRateLabel;
        private CheckBox belleaireCheckBox;
        private CheckBox lincolnCheckBox;
    }
}
