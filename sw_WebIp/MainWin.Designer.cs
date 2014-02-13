namespace sw_WebIp
{
	partial class MainWin
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
			if ( disposing && (components != null) )
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWin));
			this.WebsiteLabel = new System.Windows.Forms.Label();
			this.WebsiteText = new System.Windows.Forms.TextBox();
			this.IpAddressLabel = new System.Windows.Forms.Label();
			this.IpAddressText = new System.Windows.Forms.TextBox();
			this.ObtainButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// WebsiteLabel
			// 
			this.WebsiteLabel.AutoSize = true;
			this.WebsiteLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.WebsiteLabel.Location = new System.Drawing.Point(13, 13);
			this.WebsiteLabel.Name = "WebsiteLabel";
			this.WebsiteLabel.Size = new System.Drawing.Size(146, 50);
			this.WebsiteLabel.TabIndex = 0;
			this.WebsiteLabel.Text = "Website";
			// 
			// WebsiteText
			// 
			this.WebsiteText.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.WebsiteText.Location = new System.Drawing.Point(22, 66);
			this.WebsiteText.Name = "WebsiteText";
			this.WebsiteText.Size = new System.Drawing.Size(379, 33);
			this.WebsiteText.TabIndex = 1;
			// 
			// IpAddressLabel
			// 
			this.IpAddressLabel.AutoSize = true;
			this.IpAddressLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.IpAddressLabel.Location = new System.Drawing.Point(12, 102);
			this.IpAddressLabel.Name = "IpAddressLabel";
			this.IpAddressLabel.Size = new System.Drawing.Size(183, 50);
			this.IpAddressLabel.TabIndex = 2;
			this.IpAddressLabel.Text = "IP Address";
			// 
			// IpAddressText
			// 
			this.IpAddressText.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.IpAddressText.Location = new System.Drawing.Point(21, 155);
			this.IpAddressText.Name = "IpAddressText";
			this.IpAddressText.Size = new System.Drawing.Size(379, 33);
			this.IpAddressText.TabIndex = 3;
			// 
			// ObtainButton
			// 
			this.ObtainButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ObtainButton.Location = new System.Drawing.Point(431, 66);
			this.ObtainButton.Name = "ObtainButton";
			this.ObtainButton.Size = new System.Drawing.Size(106, 122);
			this.ObtainButton.TabIndex = 4;
			this.ObtainButton.Text = "Obtain";
			this.ObtainButton.UseVisualStyleBackColor = true;
			this.ObtainButton.Click += new System.EventHandler(this.ObtainButton_Click);
			// 
			// MainWin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(560, 211);
			this.Controls.Add(this.ObtainButton);
			this.Controls.Add(this.IpAddressText);
			this.Controls.Add(this.IpAddressLabel);
			this.Controls.Add(this.WebsiteText);
			this.Controls.Add(this.WebsiteLabel);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainWin";
			this.Text = "WebIp";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label WebsiteLabel;
		private System.Windows.Forms.TextBox WebsiteText;
		private System.Windows.Forms.Label IpAddressLabel;
		private System.Windows.Forms.TextBox IpAddressText;
		private System.Windows.Forms.Button ObtainButton;
	}
}

