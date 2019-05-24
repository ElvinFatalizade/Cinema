namespace homepracticaCinema.Forms
{
    partial class Hall
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
            this.PnlSeats = new System.Windows.Forms.Panel();
            this.LblSeatCountPrice = new System.Windows.Forms.Panel();
            this.LblSeatPriceCount = new System.Windows.Forms.Label();
            this.BtnOrder = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.LblSelectedSeats = new System.Windows.Forms.Label();
            this.LblPrice = new System.Windows.Forms.Label();
            this.LblSeat = new System.Windows.Forms.Label();
            this.LblSeatCountPrice.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlSeats
            // 
            this.PnlSeats.Location = new System.Drawing.Point(0, 1);
            this.PnlSeats.Name = "PnlSeats";
            this.PnlSeats.Size = new System.Drawing.Size(649, 577);
            this.PnlSeats.TabIndex = 0;
            // 
            // LblSeatCountPrice
            // 
            this.LblSeatCountPrice.Controls.Add(this.LblSeat);
            this.LblSeatCountPrice.Controls.Add(this.LblPrice);
            this.LblSeatCountPrice.Controls.Add(this.LblSeatPriceCount);
            this.LblSeatCountPrice.Controls.Add(this.BtnOrder);
            this.LblSeatCountPrice.Controls.Add(this.label2);
            this.LblSeatCountPrice.Controls.Add(this.LblSelectedSeats);
            this.LblSeatCountPrice.Location = new System.Drawing.Point(656, 1);
            this.LblSeatCountPrice.Name = "LblSeatCountPrice";
            this.LblSeatCountPrice.Size = new System.Drawing.Size(411, 220);
            this.LblSeatCountPrice.TabIndex = 1;
            // 
            // LblSeatPriceCount
            // 
            this.LblSeatPriceCount.AutoSize = true;
            this.LblSeatPriceCount.Location = new System.Drawing.Point(157, 133);
            this.LblSeatPriceCount.Name = "LblSeatPriceCount";
            this.LblSeatPriceCount.Size = new System.Drawing.Size(0, 17);
            this.LblSeatPriceCount.TabIndex = 3;
            // 
            // BtnOrder
            // 
            this.BtnOrder.Location = new System.Drawing.Point(163, 133);
            this.BtnOrder.Name = "BtnOrder";
            this.BtnOrder.Size = new System.Drawing.Size(128, 51);
            this.BtnOrder.TabIndex = 2;
            this.BtnOrder.Text = "Tesdiqle";
            this.BtnOrder.UseVisualStyleBackColor = true;
            this.BtnOrder.Click += new System.EventHandler(this.BtnOrder_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Toplam Mebleg";
            // 
            // LblSelectedSeats
            // 
            this.LblSelectedSeats.AutoSize = true;
            this.LblSelectedSeats.Location = new System.Drawing.Point(22, 25);
            this.LblSelectedSeats.Name = "LblSelectedSeats";
            this.LblSelectedSeats.Size = new System.Drawing.Size(103, 17);
            this.LblSelectedSeats.TabIndex = 0;
            this.LblSelectedSeats.Text = "Secilmis Stullar";
            // 
            // LblPrice
            // 
            this.LblPrice.AutoSize = true;
            this.LblPrice.Location = new System.Drawing.Point(133, 91);
            this.LblPrice.Name = "LblPrice";
            this.LblPrice.Size = new System.Drawing.Size(0, 17);
            this.LblPrice.TabIndex = 4;
            // 
            // LblSeat
            // 
            this.LblSeat.AutoSize = true;
            this.LblSeat.Location = new System.Drawing.Point(150, 24);
            this.LblSeat.Name = "LblSeat";
            this.LblSeat.Size = new System.Drawing.Size(0, 17);
            this.LblSeat.TabIndex = 5;
            // 
            // Hall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 574);
            this.Controls.Add(this.LblSeatCountPrice);
            this.Controls.Add(this.PnlSeats);
            this.Name = "Hall";
            this.Text = "Hall";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Hall_FormClosing_1);
            this.LblSeatCountPrice.ResumeLayout(false);
            this.LblSeatCountPrice.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlSeats;
        private System.Windows.Forms.Panel LblSeatCountPrice;
        private System.Windows.Forms.Label LblSeatPriceCount;
        private System.Windows.Forms.Button BtnOrder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblSelectedSeats;
        private System.Windows.Forms.Label LblPrice;
        private System.Windows.Forms.Label LblSeat;
    }
}