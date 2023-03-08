namespace QueueHelper
{
	// Token: 0x02000004 RID: 4
	public partial class QueueHelper : global::System.Windows.Forms.Form
	{
		// Token: 0x06000014 RID: 20 RVA: 0x00002309 File Offset: 0x00000509
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002328 File Offset: 0x00000528
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QueueHelper));
            this.welcomeTextLabel = new System.Windows.Forms.Label();
            this.autoAcceptBox = new System.Windows.Forms.CheckBox();
            this.PixelCoordButton = new System.Windows.Forms.Button();
            this.einschaltenText = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // welcomeTextLabel
            // 
            this.welcomeTextLabel.AutoSize = true;
            this.welcomeTextLabel.Location = new System.Drawing.Point(24, 25);
            this.welcomeTextLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.welcomeTextLabel.Name = "welcomeTextLabel";
            this.welcomeTextLabel.Size = new System.Drawing.Size(105, 14);
            this.welcomeTextLabel.TabIndex = 5;
            this.welcomeTextLabel.Text = "willkommenText";
            // 
            // autoAcceptBox
            // 
            this.autoAcceptBox.AutoSize = true;
            this.autoAcceptBox.Location = new System.Drawing.Point(14, 247);
            this.autoAcceptBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.autoAcceptBox.Name = "autoAcceptBox";
            this.autoAcceptBox.Size = new System.Drawing.Size(348, 18);
            this.autoAcceptBox.TabIndex = 6;
            this.autoAcceptBox.Text = "Auto Accept (Client darf nicht minimiert sein)";
            this.autoAcceptBox.UseVisualStyleBackColor = true;
            // 
            // PixelCoordButton
            // 
            this.PixelCoordButton.Location = new System.Drawing.Point(14, 188);
            this.PixelCoordButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PixelCoordButton.Name = "PixelCoordButton";
            this.PixelCoordButton.Size = new System.Drawing.Size(134, 25);
            this.PixelCoordButton.TabIndex = 7;
            this.PixelCoordButton.Text = "Pixel überprüfen";
            this.PixelCoordButton.UseVisualStyleBackColor = true;
            this.PixelCoordButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // einschaltenText
            // 
            this.einschaltenText.AutoSize = true;
            this.einschaltenText.Location = new System.Drawing.Point(10, 229);
            this.einschaltenText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.einschaltenText.Name = "einschaltenText";
            this.einschaltenText.Size = new System.Drawing.Size(252, 14);
            this.einschaltenText.TabIndex = 8;
            this.einschaltenText.Text = "F1 = Einschalten | F2 = Ausschalten";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork_1);
            // 
            // QueueHelper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::LoL_QueueHelper.Properties.Resources.defeat;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(600, 281);
            this.Controls.Add(this.einschaltenText);
            this.Controls.Add(this.PixelCoordButton);
            this.Controls.Add(this.autoAcceptBox);
            this.Controls.Add(this.welcomeTextLabel);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "QueueHelper";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "League of Legends Queue Helper";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		// Token: 0x0400000C RID: 12
		private global::System.ComponentModel.IContainer components;

		// Token: 0x0400000D RID: 13
		private global::System.Windows.Forms.Label welcomeTextLabel;

		// Token: 0x0400000E RID: 14
		private global::System.Windows.Forms.CheckBox autoAcceptBox;

		// Token: 0x0400000F RID: 15
		private global::System.Windows.Forms.Button PixelCoordButton;

		// Token: 0x04000010 RID: 16
		private global::System.Windows.Forms.Label einschaltenText;

		// Token: 0x04000011 RID: 17
		private global::System.ComponentModel.BackgroundWorker backgroundWorker1;
	}
}
