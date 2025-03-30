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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewPartner));
			this.txtNamePartner = new System.Windows.Forms.TextBox();
			this.txtDirector = new System.Windows.Forms.TextBox();
			this.txtPhonePartner = new System.Windows.Forms.TextBox();
			this.numRating = new System.Windows.Forms.NumericUpDown();
			this.panel3 = new System.Windows.Forms.Panel();
			this.btnAddPartner = new System.Windows.Forms.Button();
			this.btnSavePartner = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.txtInn = new System.Windows.Forms.TextBox();
			this.cbTypePartnerName = new System.Windows.Forms.ComboBox();
			this.txtAddress = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.numRating)).BeginInit();
			this.panel3.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// txtNamePartner
			// 
			this.txtNamePartner.Location = new System.Drawing.Point(322, 139);
			this.txtNamePartner.Name = "txtNamePartner";
			this.txtNamePartner.Size = new System.Drawing.Size(317, 20);
			this.txtNamePartner.TabIndex = 0;
			// 
			// txtDirector
			// 
			this.txtDirector.Location = new System.Drawing.Point(170, 205);
			this.txtDirector.Name = "txtDirector";
			this.txtDirector.Size = new System.Drawing.Size(469, 20);
			this.txtDirector.TabIndex = 0;
			// 
			// txtPhonePartner
			// 
			this.txtPhonePartner.Location = new System.Drawing.Point(170, 267);
			this.txtPhonePartner.Name = "txtPhonePartner";
			this.txtPhonePartner.Size = new System.Drawing.Size(469, 20);
			this.txtPhonePartner.TabIndex = 0;
			// 
			// numRating
			// 
			this.numRating.Location = new System.Drawing.Point(478, 432);
			this.numRating.Name = "numRating";
			this.numRating.Size = new System.Drawing.Size(161, 20);
			this.numRating.TabIndex = 1;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(211)))));
			this.panel3.Controls.Add(this.btnAddPartner);
			this.panel3.Controls.Add(this.btnSavePartner);
			this.panel3.Controls.Add(this.button1);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel3.Location = new System.Drawing.Point(0, 506);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(902, 100);
			this.panel3.TabIndex = 2;
			// 
			// btnAddPartner
			// 
			this.btnAddPartner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(186)))), ((int)(((byte)(128)))));
			this.btnAddPartner.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnAddPartner.ForeColor = System.Drawing.Color.White;
			this.btnAddPartner.Location = new System.Drawing.Point(35, 28);
			this.btnAddPartner.Name = "btnAddPartner";
			this.btnAddPartner.Size = new System.Drawing.Size(171, 46);
			this.btnAddPartner.TabIndex = 0;
			this.btnAddPartner.Text = "Add";
			this.btnAddPartner.UseVisualStyleBackColor = false;
			this.btnAddPartner.Click += new System.EventHandler(this.btnAddPartner_Click);
			// 
			// btnSavePartner
			// 
			this.btnSavePartner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(186)))), ((int)(((byte)(128)))));
			this.btnSavePartner.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnSavePartner.ForeColor = System.Drawing.Color.White;
			this.btnSavePartner.Location = new System.Drawing.Point(235, 28);
			this.btnSavePartner.Name = "btnSavePartner";
			this.btnSavePartner.Size = new System.Drawing.Size(171, 46);
			this.btnSavePartner.TabIndex = 0;
			this.btnSavePartner.Text = "Save";
			this.btnSavePartner.UseVisualStyleBackColor = false;
			this.btnSavePartner.Click += new System.EventHandler(this.btnSavePartner_Click);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(186)))), ((int)(((byte)(128)))));
			this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button1.ForeColor = System.Drawing.Color.White;
			this.button1.Location = new System.Drawing.Point(656, 28);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(171, 46);
			this.button1.TabIndex = 0;
			this.button1.Text = "Выход";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(211)))));
			this.panel2.Controls.Add(this.pictureBox1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(902, 113);
			this.panel2.TabIndex = 3;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(3, 3);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(134, 107);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// txtEmail
			// 
			this.txtEmail.Location = new System.Drawing.Point(170, 363);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(469, 20);
			this.txtEmail.TabIndex = 0;
			// 
			// txtInn
			// 
			this.txtInn.Location = new System.Drawing.Point(170, 432);
			this.txtInn.Name = "txtInn";
			this.txtInn.Size = new System.Drawing.Size(208, 20);
			this.txtInn.TabIndex = 0;
			this.txtInn.Text = " ";
			// 
			// cbTypePartnerName
			// 
			this.cbTypePartnerName.FormattingEnabled = true;
			this.cbTypePartnerName.Location = new System.Drawing.Point(170, 139);
			this.cbTypePartnerName.Name = "cbTypePartnerName";
			this.cbTypePartnerName.Size = new System.Drawing.Size(121, 21);
			this.cbTypePartnerName.TabIndex = 4;
			// 
			// txtAddress
			// 
			this.txtAddress.Location = new System.Drawing.Point(170, 314);
			this.txtAddress.Name = "txtAddress";
			this.txtAddress.Size = new System.Drawing.Size(469, 20);
			this.txtAddress.TabIndex = 0;
			// 
			// NewPartner
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(902, 606);
			this.Controls.Add(this.cbTypePartnerName);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.numRating);
			this.Controls.Add(this.txtAddress);
			this.Controls.Add(this.txtPhonePartner);
			this.Controls.Add(this.txtEmail);
			this.Controls.Add(this.txtDirector);
			this.Controls.Add(this.txtNamePartner);
			this.Controls.Add(this.txtInn);
			this.MaximumSize = new System.Drawing.Size(1280, 720);
			this.Name = "NewPartner";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "NewPartner";
			this.Load += new System.EventHandler(this.NewPartner_Load);
			((System.ComponentModel.ISupportInitialize)(this.numRating)).EndInit();
			this.panel3.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.TextBox txtNamePartner;
		private System.Windows.Forms.TextBox txtDirector;
		private System.Windows.Forms.TextBox txtPhonePartner;
		private System.Windows.Forms.NumericUpDown numRating;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button btnSavePartner;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.TextBox txtInn;
		private System.Windows.Forms.ComboBox cbTypePartnerName;
		private System.Windows.Forms.Button btnAddPartner;
		private System.Windows.Forms.TextBox txtAddress;
	}
}