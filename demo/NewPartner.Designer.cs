namespace demo
{
	partial class NewPartner
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
			this.textBoxTypePartnerName = new System.Windows.Forms.TextBox();
			this.textBoxNamePartner = new System.Windows.Forms.TextBox();
			this.textBoxDirector = new System.Windows.Forms.TextBox();
			this.textBoxPhonePartner = new System.Windows.Forms.TextBox();
			this.numericUpDownRating = new System.Windows.Forms.NumericUpDown();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownRating)).BeginInit();
			this.SuspendLayout();
			// 
			// textBoxTypePartnerName
			// 
			this.textBoxTypePartnerName.Location = new System.Drawing.Point(137, 62);
			this.textBoxTypePartnerName.Name = "textBoxTypePartnerName";
			this.textBoxTypePartnerName.Size = new System.Drawing.Size(469, 20);
			this.textBoxTypePartnerName.TabIndex = 0;
			// 
			// textBoxNamePartner
			// 
			this.textBoxNamePartner.Location = new System.Drawing.Point(137, 108);
			this.textBoxNamePartner.Name = "textBoxNamePartner";
			this.textBoxNamePartner.Size = new System.Drawing.Size(469, 20);
			this.textBoxNamePartner.TabIndex = 0;
			// 
			// textBoxDirector
			// 
			this.textBoxDirector.Location = new System.Drawing.Point(137, 134);
			this.textBoxDirector.Name = "textBoxDirector";
			this.textBoxDirector.Size = new System.Drawing.Size(469, 20);
			this.textBoxDirector.TabIndex = 0;
			// 
			// textBoxPhonePartner
			// 
			this.textBoxPhonePartner.Location = new System.Drawing.Point(128, 193);
			this.textBoxPhonePartner.Name = "textBoxPhonePartner";
			this.textBoxPhonePartner.Size = new System.Drawing.Size(469, 20);
			this.textBoxPhonePartner.TabIndex = 0;
			// 
			// numericUpDownRating
			// 
			this.numericUpDownRating.Location = new System.Drawing.Point(280, 291);
			this.numericUpDownRating.Name = "numericUpDownRating";
			this.numericUpDownRating.Size = new System.Drawing.Size(120, 20);
			this.numericUpDownRating.TabIndex = 1;
			// 
			// NewPartner
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1225, 681);
			this.Controls.Add(this.numericUpDownRating);
			this.Controls.Add(this.textBoxPhonePartner);
			this.Controls.Add(this.textBoxDirector);
			this.Controls.Add(this.textBoxNamePartner);
			this.Controls.Add(this.textBoxTypePartnerName);
			this.MaximumSize = new System.Drawing.Size(1280, 720);
			this.Name = "NewPartner";
			this.Text = "NewPartner";
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownRating)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBoxTypePartnerName;
		private System.Windows.Forms.TextBox textBoxNamePartner;
		private System.Windows.Forms.TextBox textBoxDirector;
		private System.Windows.Forms.TextBox textBoxPhonePartner;
		private System.Windows.Forms.NumericUpDown numericUpDownRating;
	}
}