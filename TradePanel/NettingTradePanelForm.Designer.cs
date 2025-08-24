using System;

namespace TradePanel
{
    partial class NettingTradePanelForm
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
            this.ButtonBuyOpen = new System.Windows.Forms.Button();
            this.ButtonSellClose = new System.Windows.Forms.Button();
            this.CheckBoxSkipTick = new System.Windows.Forms.CheckBox();
            this.StopLoss = new System.Windows.Forms.TextBox();
            this.TakeProfit = new System.Windows.Forms.TextBox();
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
            this.ButtonSellOpen.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonSellOpen.Location = new System.Drawing.Point(162, 47);
            this.ButtonSellOpen.Name = "ButtonSellOpen";
            this.ButtonSellOpen.Size = new System.Drawing.Size(80, 29);
            this.ButtonSellOpen.TabIndex = 5;
            this.ButtonSellOpen.Text = "Sell Open";
            this.ButtonSellOpen.UseVisualStyleBackColor = true;
            // 
            // ButtonBuyClose
            // 
            this.ButtonBuyClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonBuyClose.Location = new System.Drawing.Point(162, 82);
            this.ButtonBuyClose.Name = "ButtonBuyClose";
            this.ButtonBuyClose.Size = new System.Drawing.Size(80, 29);
            this.ButtonBuyClose.TabIndex = 6;
            this.ButtonBuyClose.Text = "Buy Close";
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
            this.CurrentVolume.Location = new System.Drawing.Point(98, 82);
            this.CurrentVolume.Name = "CurrentVolume";
            this.CurrentVolume.Size = new System.Drawing.Size(58, 29);
            this.CurrentVolume.TabIndex = 1;
            this.CurrentVolume.Text = "-.--";
            this.CurrentVolume.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ButtonBuyOpen
            // 
            this.ButtonBuyOpen.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonBuyOpen.Location = new System.Drawing.Point(12, 47);
            this.ButtonBuyOpen.Name = "ButtonBuyOpen";
            this.ButtonBuyOpen.Size = new System.Drawing.Size(80, 29);
            this.ButtonBuyOpen.TabIndex = 3;
            this.ButtonBuyOpen.Text = "Buy Open";
            this.ButtonBuyOpen.UseVisualStyleBackColor = true;
            // 
            // ButtonSellClose
            // 
            this.ButtonSellClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonSellClose.Location = new System.Drawing.Point(12, 82);
            this.ButtonSellClose.Name = "ButtonSellClose";
            this.ButtonSellClose.Size = new System.Drawing.Size(80, 29);
            this.ButtonSellClose.TabIndex = 4;
            this.ButtonSellClose.Text = "Sell Close";
            this.ButtonSellClose.UseVisualStyleBackColor = true;
            // 
            // CheckBoxSkipTick
            // 
            this.CheckBoxSkipTick.AutoSize = true;
            this.CheckBoxSkipTick.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CheckBoxSkipTick.Location = new System.Drawing.Point(104, 53);
            this.CheckBoxSkipTick.Name = "CheckBoxSkipTick";
            this.CheckBoxSkipTick.Size = new System.Drawing.Size(48, 19);
            this.CheckBoxSkipTick.TabIndex = 7;
            this.CheckBoxSkipTick.Text = "Skip";
            this.CheckBoxSkipTick.UseVisualStyleBackColor = true;
            // 
            // StopLoss
            // 
            this.StopLoss.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StopLoss.Location = new System.Drawing.Point(12, 117);
            this.StopLoss.Name = "StopLoss";
            this.StopLoss.Size = new System.Drawing.Size(110, 29);
            this.StopLoss.TabIndex = 8;
            this.StopLoss.Text = "-.--";
            this.StopLoss.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TakeProfit
            // 
            this.TakeProfit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TakeProfit.Location = new System.Drawing.Point(132, 117);
            this.TakeProfit.Name = "TakeProfit";
            this.TakeProfit.Size = new System.Drawing.Size(110, 29);
            this.TakeProfit.TabIndex = 9;
            this.TakeProfit.Text = "-.--";
            this.TakeProfit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NettingTradePanelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(254, 156);
            this.Controls.Add(this.TakeProfit);
            this.Controls.Add(this.StopLoss);
            this.Controls.Add(this.CheckBoxSkipTick);
            this.Controls.Add(this.ButtonSellClose);
            this.Controls.Add(this.ButtonBuyOpen);
            this.Controls.Add(this.CurrentVolume);
            this.Controls.Add(this.BidLabel);
            this.Controls.Add(this.ButtonBuyClose);
            this.Controls.Add(this.ButtonSellOpen);
            this.Controls.Add(this.AskLabel);
            this.MaximizeBox = false;
            this.Name = "NettingTradePanelForm";
            this.Text = "Netting";
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
        private System.Windows.Forms.Button ButtonBuyOpen;
        private System.Windows.Forms.Button ButtonSellClose;
        private System.Windows.Forms.CheckBox CheckBoxSkipTick;
        private System.Windows.Forms.TextBox StopLoss;
        private System.Windows.Forms.TextBox TakeProfit;
    }
}