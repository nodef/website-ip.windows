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
			this.Ipv4AddressLabel = new System.Windows.Forms.Label();
			this.Ipv4AddressText = new System.Windows.Forms.TextBox();
			this.ObtainButton = new System.Windows.Forms.Button();
			this.Ipv6AddressLabel = new System.Windows.Forms.Label();
			this.Ipv6AddressText = new System.Windows.Forms.TextBox();
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
			// Ipv4AddressLabel
			// 
			this.Ipv4AddressLabel.AutoSize = true;
			this.Ipv4AddressLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Ipv4AddressLabel.Location = new System.Drawing.Point(12, 102);
			this.Ipv4AddressLabel.Name = "Ipv4AddressLabel";
			this.Ipv4AddressLabel.Size = new System.Drawing.Size(220, 50);
			this.Ipv4AddressLabel.TabIndex = 2;
			this.Ipv4AddressLabel.Text = "IPv4 Address";
			// 
			// Ipv4AddressText
			// 
			this.Ipv4AddressText.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Ipv4AddressText.Location = new System.Drawing.Point(21, 155);
			this.Ipv4AddressText.Name = "Ipv4AddressText";
			this.Ipv4AddressText.Size = new System.Drawing.Size(379, 33);
			this.Ipv4AddressText.TabIndex = 3;
			// 
			// ObtainButton
			// 
			this.ObtainButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ObtainButton.Location = new System.Drawing.Point(431, 66);
			this.ObtainButton.Name = "ObtainButton";
			this.ObtainButton.Size = new System.Drawing.Size(106, 211);
			this.ObtainButton.TabIndex = 4;
			this.ObtainButton.Text = "Obtain";
			this.ObtainButton.UseVisualStyleBackColor = true;
			this.ObtainButton.Click += new System.EventHandler(this.ObtainButton_Click);
			// 
			// Ipv6AddressLabel
			// 
			this.Ipv6AddressLabel.AutoSize = true;
			this.Ipv6AddressLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Ipv6AddressLabel.Location = new System.Drawing.Point(12, 191);
			this.Ipv6AddressLabel.Name = "Ipv6AddressLabel";
			this.Ipv6AddressLabel.Size = new System.Drawing.Size(219, 50);
			this.Ipv6AddressLabel.TabIndex = 5;
			this.Ipv6AddressLabel.Text = "IPv6 Address";
			// 
			// Ipv6AddressText
			// 
			this.Ipv6AddressText.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Ipv6AddressText.Location = new System.Drawing.Point(22, 244);
			this.Ipv6AddressText.Name = "Ipv6AddressText";
			this.Ipv6AddressText.Size = new System.Drawing.Size(379, 33);
			this.Ipv6AddressText.TabIndex = 6;
			// 
			// MainWin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(560, 297);
			this.Controls.Add(this.Ipv6AddressText);
			this.Controls.Add(this.Ipv6AddressLabel);
			this.Controls.Add(this.ObtainButton);
			this.Controls.Add(this.Ipv4AddressText);
			this.Controls.Add(this.Ipv4AddressLabel);
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
		private System.Windows.Forms.Label Ipv4AddressLabel;
		private System.Windows.Forms.TextBox Ipv4AddressText;
		private System.Windows.Forms.Button ObtainButton;
		private System.Windows.Forms.Label Ipv6AddressLabel;
		private System.Windows.Forms.TextBox Ipv6AddressText;
	}
}

