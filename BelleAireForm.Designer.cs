using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSC240_06_01_BedAndBreakfast_DG
{
    partial class BelleAireForm 
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
            belleAireDescriptionLabel = new Label();
            belleAirePriceLabel = new Label();
            SuspendLayout();
            // 
            // belleAireDescriptionLabel
            // 
            belleAireDescriptionLabel.AutoSize = true;
            belleAireDescriptionLabel.Location = new Point(66, 67);
            belleAireDescriptionLabel.Name = "belleAireDescriptionLabel";
            belleAireDescriptionLabel.Size = new Size(210, 30);
            belleAireDescriptionLabel.TabIndex = 0;
            belleAireDescriptionLabel.Text = "The BelleAire suite has two bedrooms, \r\ntwo baths, and a private balcony";
            // 
            // belleAirePriceLabel
            // 
            belleAirePriceLabel.AutoSize = true;
            belleAirePriceLabel.Location = new Point(117, 151);
            belleAirePriceLabel.Name = "belleAirePriceLabel";
            belleAirePriceLabel.Size = new Size(82, 15);
            belleAirePriceLabel.TabIndex = 1;
            belleAirePriceLabel.Text = "$199 per night";
            // 
            // BelleAireForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Yellow;
            ClientSize = new Size(318, 266);
            Controls.Add(belleAirePriceLabel);
            Controls.Add(belleAireDescriptionLabel);
            Name = "BelleAireForm";
            Text = "BelleAireForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label belleAireDescriptionLabel;
        private Label belleAirePriceLabel;
    }
}