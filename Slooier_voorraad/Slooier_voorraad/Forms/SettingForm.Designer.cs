﻿namespace Slooier_voorraad.Forms
{
	partial class SettingForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingForm));
			this.PboxLogo = new System.Windows.Forms.PictureBox();
			this.PMain = new System.Windows.Forms.Panel();
			this.GbDB = new System.Windows.Forms.GroupBox();
			this.LblServer = new System.Windows.Forms.Label();
			this.LblUserName = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.PboxLogo)).BeginInit();
			this.PMain.SuspendLayout();
			this.GbDB.SuspendLayout();
			this.SuspendLayout();
			// 
			// PboxLogo
			// 
			this.PboxLogo.BackColor = System.Drawing.Color.White;
			this.PboxLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PboxLogo.BackgroundImage")));
			this.PboxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.PboxLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.PboxLogo.Dock = System.Windows.Forms.DockStyle.Top;
			this.PboxLogo.Location = new System.Drawing.Point(0, 0);
			this.PboxLogo.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
			this.PboxLogo.Name = "PboxLogo";
			this.PboxLogo.Size = new System.Drawing.Size(800, 108);
			this.PboxLogo.TabIndex = 4;
			this.PboxLogo.TabStop = false;
			// 
			// PMain
			// 
			this.PMain.Controls.Add(this.GbDB);
			this.PMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.PMain.Location = new System.Drawing.Point(0, 108);
			this.PMain.Name = "PMain";
			this.PMain.Size = new System.Drawing.Size(800, 342);
			this.PMain.TabIndex = 7;
			// 
			// GbDB
			// 
			this.GbDB.Controls.Add(this.LblUserName);
			this.GbDB.Controls.Add(this.LblServer);
			this.GbDB.Location = new System.Drawing.Point(4, 4);
			this.GbDB.Name = "GbDB";
			this.GbDB.Size = new System.Drawing.Size(234, 161);
			this.GbDB.TabIndex = 0;
			this.GbDB.TabStop = false;
			this.GbDB.Text = "Database connectie";
			// 
			// LblServer
			// 
			this.LblServer.AutoSize = true;
			this.LblServer.Location = new System.Drawing.Point(7, 20);
			this.LblServer.Name = "LblServer";
			this.LblServer.Size = new System.Drawing.Size(44, 13);
			this.LblServer.TabIndex = 0;
			this.LblServer.Text = "Server: ";
			// 
			// LblUserName
			// 
			this.LblUserName.AutoSize = true;
			this.LblUserName.Location = new System.Drawing.Point(7, 44);
			this.LblUserName.Name = "LblUserName";
			this.LblUserName.Size = new System.Drawing.Size(93, 13);
			this.LblUserName.TabIndex = 1;
			this.LblUserName.Text = "Gebruikers naam: ";
			// 
			// SettingForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.PMain);
			this.Controls.Add(this.PboxLogo);
			this.Name = "SettingForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Instellingen";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.SettingForm_Load);
			this.SizeChanged += new System.EventHandler(this.SettingForm_SizeChanged);
			((System.ComponentModel.ISupportInitialize)(this.PboxLogo)).EndInit();
			this.PMain.ResumeLayout(false);
			this.GbDB.ResumeLayout(false);
			this.GbDB.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox PboxLogo;
		private System.Windows.Forms.Panel PMain;
		private System.Windows.Forms.GroupBox GbDB;
		private System.Windows.Forms.Label LblServer;
		private System.Windows.Forms.Label LblUserName;
	}
}