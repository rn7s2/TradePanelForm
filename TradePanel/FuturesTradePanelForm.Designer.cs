using System;

namespace TradePanel
{
    partial class FuturesTradePanelForm
    {

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AskLabel = new System.Windows.Forms.Label();
            this.ButtonSellOpen = new System.Windows.Forms.Button();
            this.ButtonBuyClose = new System.Windows.Forms.Button();
            this.BidLabel = new System.Windows.Forms.Label();
            this.CurrentVolume = new System.Windows.Forms.TextBox();
            this.IncrementVol = new System.Windows.Forms.VScrollBar();
            this.ButtonBuyOpen = new System.Windows.Forms.Button();
            this.ButtonSellClose = new System.Windows.Forms.Button();
            this.CheckBoxSkipTick = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // AskLabel
            // 
            this.AskLabel.AutoSize = true;
            this.AskLabel.BackColor = System.Drawing.Color.IndianRed;
            this.AskLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AskLabel.Location = new System.Drawing.Point(12, 8);
            this.AskLabel.Name = "AskLabel";
            this.AskLabel.Size = new System.Drawing.Size(112, 31);
            this.AskLabel.TabIndex = 0;
            this.AskLabel.Text = "1.14068";
            // 
            // ButtonSellOpen
            // 
            this.ButtonSellOpen.Location = new System.Drawing.Point(134, 84);
            this.ButtonSellOpen.Name = "ButtonSellOpen";
            this.ButtonSellOpen.Size = new System.Drawing.Size(54, 27);
            this.ButtonSellOpen.TabIndex = 5;
            this.ButtonSellOpen.Text = "卖开";
            this.ButtonSellOpen.UseVisualStyleBackColor = true;
            // 
            // ButtonBuyClose
            // 
            this.ButtonBuyClose.Location = new System.Drawing.Point(190, 84);
            this.ButtonBuyClose.Name = "ButtonBuyClose";
            this.ButtonBuyClose.Size = new System.Drawing.Size(54, 27);
            this.ButtonBuyClose.TabIndex = 6;
            this.ButtonBuyClose.Text = "买平";
            this.ButtonBuyClose.UseVisualStyleBackColor = true;
            // 
            // BidLabel
            // 
            this.BidLabel.AutoSize = true;
            this.BidLabel.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BidLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BidLabel.Location = new System.Drawing.Point(130, 8);
            this.BidLabel.Name = "BidLabel";
            this.BidLabel.Size = new System.Drawing.Size(112, 31);
            this.BidLabel.TabIndex = 5;
            this.BidLabel.Text = "1.14068";
            // 
            // CurrentVolume
            // 
            this.CurrentVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CurrentVolume.Location = new System.Drawing.Point(12, 51);
            this.CurrentVolume.Name = "CurrentVolume";
            this.CurrentVolume.Size = new System.Drawing.Size(138, 29);
            this.CurrentVolume.TabIndex = 1;
            this.CurrentVolume.Text = "-.--";
            this.CurrentVolume.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // IncrementVol
            // 
            this.IncrementVol.AllowDrop = true;
            this.IncrementVol.Location = new System.Drawing.Point(148, 52);
            this.IncrementVol.Name = "IncrementVol";
            this.IncrementVol.Size = new System.Drawing.Size(15, 27);
            this.IncrementVol.TabIndex = 2;
            // 
            // ButtonBuyOpen
            // 
            this.ButtonBuyOpen.Location = new System.Drawing.Point(11, 84);
            this.ButtonBuyOpen.Name = "ButtonBuyOpen";
            this.ButtonBuyOpen.Size = new System.Drawing.Size(54, 27);
            this.ButtonBuyOpen.TabIndex = 3;
            this.ButtonBuyOpen.Text = "买开";
            this.ButtonBuyOpen.UseVisualStyleBackColor = true;
            // 
            // ButtonSellClose
            // 
            this.ButtonSellClose.Location = new System.Drawing.Point(67, 84);
            this.ButtonSellClose.Name = "ButtonSellClose";
            this.ButtonSellClose.Size = new System.Drawing.Size(54, 27);
            this.ButtonSellClose.TabIndex = 4;
            this.ButtonSellClose.Text = "卖平";
            this.ButtonSellClose.UseVisualStyleBackColor = true;
            // 
            // CheckBoxSkipTick
            // 
            this.CheckBoxSkipTick.AutoSize = true;
            this.CheckBoxSkipTick.Location = new System.Drawing.Point(175, 57);
            this.CheckBoxSkipTick.Name = "CheckBoxSkipTick";
            this.CheckBoxSkipTick.Size = new System.Drawing.Size(72, 16);
            this.CheckBoxSkipTick.TabIndex = 7;
            this.CheckBoxSkipTick.Text = "暂停行情";
            this.CheckBoxSkipTick.UseVisualStyleBackColor = true;
            // 
            // FuturesTradePanelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(254, 119);
            this.Controls.Add(this.CheckBoxSkipTick);
            this.Controls.Add(this.ButtonSellClose);
            this.Controls.Add(this.ButtonBuyOpen);
            this.Controls.Add(this.IncrementVol);
            this.Controls.Add(this.CurrentVolume);
            this.Controls.Add(this.BidLabel);
            this.Controls.Add(this.ButtonBuyClose);
            this.Controls.Add(this.ButtonSellOpen);
            this.Controls.Add(this.AskLabel);
            this.MaximizeBox = false;
            this.Name = "FuturesTradePanelForm";
            this.Text = "期货";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AskLabel;
        private System.Windows.Forms.Button ButtonSellOpen;
        private System.Windows.Forms.Button ButtonBuyClose;
        private System.Windows.Forms.Label BidLabel;
        private System.Windows.Forms.TextBox CurrentVolume;
        private System.Windows.Forms.VScrollBar IncrementVol;
        private System.Windows.Forms.Button ButtonBuyOpen;
        private System.Windows.Forms.Button ButtonSellClose;
        private System.Windows.Forms.CheckBox CheckBoxSkipTick;
    }
}