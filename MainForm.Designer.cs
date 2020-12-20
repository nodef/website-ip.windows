namespace WebsiteIP
{
	partial class MainForm
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
      this.LURL = new System.Windows.Forms.Label();
      this.TURL = new System.Windows.Forms.TextBox();
      this.LIPv4 = new System.Windows.Forms.Label();
      this.TIPv4 = new System.Windows.Forms.TextBox();
      this.BSubmit = new System.Windows.Forms.Button();
      this.LIPv6 = new System.Windows.Forms.Label();
      this.TIPv6 = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // LURL
      // 
      this.LURL.AutoSize = true;
      this.LURL.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.LURL.Location = new System.Drawing.Point(13, 13);
      this.LURL.Name = "LURL";
      this.LURL.Size = new System.Drawing.Size(146, 50);
      this.LURL.TabIndex = 0;
      this.LURL.Text = "Website";
      // 
      // TURL
      // 
      this.TURL.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.TURL.Location = new System.Drawing.Point(22, 66);
      this.TURL.Name = "TURL";
      this.TURL.Size = new System.Drawing.Size(379, 33);
      this.TURL.TabIndex = 1;
      // 
      // LIPv4
      // 
      this.LIPv4.AutoSize = true;
      this.LIPv4.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.LIPv4.Location = new System.Drawing.Point(12, 102);
      this.LIPv4.Name = "LIPv4";
      this.LIPv4.Size = new System.Drawing.Size(220, 50);
      this.LIPv4.TabIndex = 2;
      this.LIPv4.Text = "IPv4 Address";
      // 
      // TIPv4
      // 
      this.TIPv4.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.TIPv4.Location = new System.Drawing.Point(21, 155);
      this.TIPv4.Name = "TIPv4";
      this.TIPv4.Size = new System.Drawing.Size(379, 33);
      this.TIPv4.TabIndex = 3;
      // 
      // BSubmit
      // 
      this.BSubmit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.BSubmit.Location = new System.Drawing.Point(431, 66);
      this.BSubmit.Name = "BSubmit";
      this.BSubmit.Size = new System.Drawing.Size(106, 211);
      this.BSubmit.TabIndex = 4;
      this.BSubmit.Text = "Obtain";
      this.BSubmit.UseVisualStyleBackColor = true;
      this.BSubmit.Click += new System.EventHandler(this.BSubmit_Click);
      // 
      // LIPv6
      // 
      this.LIPv6.AutoSize = true;
      this.LIPv6.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.LIPv6.Location = new System.Drawing.Point(12, 191);
      this.LIPv6.Name = "LIPv6";
      this.LIPv6.Size = new System.Drawing.Size(219, 50);
      this.LIPv6.TabIndex = 5;
      this.LIPv6.Text = "IPv6 Address";
      // 
      // TIPv6
      // 
      this.TIPv6.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.TIPv6.Location = new System.Drawing.Point(22, 244);
      this.TIPv6.Name = "TIPv6";
      this.TIPv6.Size = new System.Drawing.Size(379, 33);
      this.TIPv6.TabIndex = 6;
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(560, 297);
      this.Controls.Add(this.TIPv6);
      this.Controls.Add(this.LIPv6);
      this.Controls.Add(this.BSubmit);
      this.Controls.Add(this.TIPv4);
      this.Controls.Add(this.LIPv4);
      this.Controls.Add(this.TURL);
      this.Controls.Add(this.LURL);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "MainForm";
      this.Text = "Website IP";
      this.ResumeLayout(false);
      this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label LURL;
		private System.Windows.Forms.TextBox TURL;
		private System.Windows.Forms.Label LIPv4;
		private System.Windows.Forms.TextBox TIPv4;
		private System.Windows.Forms.Button BSubmit;
		private System.Windows.Forms.Label LIPv6;
		private System.Windows.Forms.TextBox TIPv6;
	}
}

