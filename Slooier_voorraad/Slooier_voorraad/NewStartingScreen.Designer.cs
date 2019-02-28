﻿namespace Slooier_voorraad
{
	partial class NewStartingScreen
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewStartingScreen));
			this.PboxLogo = new System.Windows.Forms.PictureBox();
			this.MenuBar = new System.Windows.Forms.MenuStrip();
			this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.VoorraadBekijkenToolStripMenuBar = new System.Windows.Forms.ToolStripMenuItem();
			this.nieuweArtikelenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.losArtikelToevoegenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.AfdelingToevoegenToolStripMenuBar = new System.Windows.Forms.ToolStripMenuItem();
			this.ArtikelToevoegenToolStripMenuBar = new System.Windows.Forms.ToolStripMenuItem();
			this.BestandToevoegenToolStripMenuBar = new System.Windows.Forms.ToolStripMenuItem();
			this.artikelAanpassenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ArtikelAanpassenToolStripMenuBar = new System.Windows.Forms.ToolStripMenuItem();
			this.AfdelingAanpassenToolStripMenuBar = new System.Windows.Forms.ToolStripMenuItem();
			this.verwijderenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ArtikelVerwijderenToolStripMenuBar = new System.Windows.Forms.ToolStripMenuItem();
			this.InstellingenToolStripMenuBar = new System.Windows.Forms.ToolStripMenuItem();
			this.SluitenToolStripMenuBar = new System.Windows.Forms.ToolStripMenuItem();
			this.AfdelingVerwijderenToolStripMenuBar = new System.Windows.Forms.ToolStripMenuItem();
			this.TmrDbCheck = new System.Windows.Forms.Timer(this.components);
			((System.ComponentModel.ISupportInitialize)(this.PboxLogo)).BeginInit();
			this.MenuBar.SuspendLayout();
			this.SuspendLayout();
			// 
			// PboxLogo
			// 
			this.PboxLogo.BackColor = System.Drawing.Color.White;
			this.PboxLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PboxLogo.BackgroundImage")));
			this.PboxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.PboxLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.PboxLogo.Dock = System.Windows.Forms.DockStyle.Top;
			this.PboxLogo.Location = new System.Drawing.Point(0, 24);
			this.PboxLogo.Name = "PboxLogo";
			this.PboxLogo.Size = new System.Drawing.Size(800, 108);
			this.PboxLogo.TabIndex = 5;
			this.PboxLogo.TabStop = false;
			// 
			// MenuBar
			// 
			this.MenuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.nieuweArtikelenToolStripMenuItem,
            this.InstellingenToolStripMenuBar,
            this.SluitenToolStripMenuBar});
			this.MenuBar.Location = new System.Drawing.Point(0, 0);
			this.MenuBar.Name = "MenuBar";
			this.MenuBar.Size = new System.Drawing.Size(800, 24);
			this.MenuBar.TabIndex = 6;
			this.MenuBar.Text = "menuStrip1";
			// 
			// menuToolStripMenuItem
			// 
			this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.VoorraadBekijkenToolStripMenuBar});
			this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
			this.menuToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
			this.menuToolStripMenuItem.Text = "&Voorraad";
			// 
			// VoorraadBekijkenToolStripMenuBar
			// 
			this.VoorraadBekijkenToolStripMenuBar.Name = "VoorraadBekijkenToolStripMenuBar";
			this.VoorraadBekijkenToolStripMenuBar.Size = new System.Drawing.Size(180, 22);
			this.VoorraadBekijkenToolStripMenuBar.Text = "Voorraad bekijken";
			this.VoorraadBekijkenToolStripMenuBar.Click += new System.EventHandler(this.VoorraadBekijkenToolStripMenuBar_Click);
			// 
			// nieuweArtikelenToolStripMenuItem
			// 
			this.nieuweArtikelenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.losArtikelToevoegenToolStripMenuItem,
            this.artikelAanpassenToolStripMenuItem,
            this.verwijderenToolStripMenuItem});
			this.nieuweArtikelenToolStripMenuItem.Name = "nieuweArtikelenToolStripMenuItem";
			this.nieuweArtikelenToolStripMenuItem.Size = new System.Drawing.Size(109, 20);
			this.nieuweArtikelenToolStripMenuItem.Text = "&Nieuwe Artikelen";
			// 
			// losArtikelToevoegenToolStripMenuItem
			// 
			this.losArtikelToevoegenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AfdelingToevoegenToolStripMenuBar,
            this.ArtikelToevoegenToolStripMenuBar,
            this.BestandToevoegenToolStripMenuBar});
			this.losArtikelToevoegenToolStripMenuItem.Name = "losArtikelToevoegenToolStripMenuItem";
			this.losArtikelToevoegenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.losArtikelToevoegenToolStripMenuItem.Text = "&Toevoegen";
			// 
			// AfdelingToevoegenToolStripMenuBar
			// 
			this.AfdelingToevoegenToolStripMenuBar.Name = "AfdelingToevoegenToolStripMenuBar";
			this.AfdelingToevoegenToolStripMenuBar.Size = new System.Drawing.Size(180, 22);
			this.AfdelingToevoegenToolStripMenuBar.Text = "Afdeling toevoegen";
			this.AfdelingToevoegenToolStripMenuBar.Click += new System.EventHandler(this.AfdelingToevoegenToolStripMenuBar_Click);
			// 
			// ArtikelToevoegenToolStripMenuBar
			// 
			this.ArtikelToevoegenToolStripMenuBar.Name = "ArtikelToevoegenToolStripMenuBar";
			this.ArtikelToevoegenToolStripMenuBar.Size = new System.Drawing.Size(180, 22);
			this.ArtikelToevoegenToolStripMenuBar.Text = "Artikel toevoegen";
			this.ArtikelToevoegenToolStripMenuBar.Click += new System.EventHandler(this.ArtikelToevoegenToolStripMenuBar_Click);
			// 
			// BestandToevoegenToolStripMenuBar
			// 
			this.BestandToevoegenToolStripMenuBar.Name = "BestandToevoegenToolStripMenuBar";
			this.BestandToevoegenToolStripMenuBar.Size = new System.Drawing.Size(180, 22);
			this.BestandToevoegenToolStripMenuBar.Text = "Bestand  toevoegen";
			this.BestandToevoegenToolStripMenuBar.Click += new System.EventHandler(this.BestandToevoegenToolStripMenuBar_Click);
			// 
			// artikelAanpassenToolStripMenuItem
			// 
			this.artikelAanpassenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ArtikelAanpassenToolStripMenuBar,
            this.AfdelingAanpassenToolStripMenuBar});
			this.artikelAanpassenToolStripMenuItem.Name = "artikelAanpassenToolStripMenuItem";
			this.artikelAanpassenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.artikelAanpassenToolStripMenuItem.Text = "&Aanpassen";
			// 
			// ArtikelAanpassenToolStripMenuBar
			// 
			this.ArtikelAanpassenToolStripMenuBar.Name = "ArtikelAanpassenToolStripMenuBar";
			this.ArtikelAanpassenToolStripMenuBar.Size = new System.Drawing.Size(180, 22);
			this.ArtikelAanpassenToolStripMenuBar.Text = "Artikel aanpassen";
			// 
			// AfdelingAanpassenToolStripMenuBar
			// 
			this.AfdelingAanpassenToolStripMenuBar.Name = "AfdelingAanpassenToolStripMenuBar";
			this.AfdelingAanpassenToolStripMenuBar.Size = new System.Drawing.Size(180, 22);
			this.AfdelingAanpassenToolStripMenuBar.Text = "Afdeling aanpassen";
			// 
			// verwijderenToolStripMenuItem
			// 
			this.verwijderenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ArtikelVerwijderenToolStripMenuBar,
            this.AfdelingVerwijderenToolStripMenuBar});
			this.verwijderenToolStripMenuItem.Name = "verwijderenToolStripMenuItem";
			this.verwijderenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.verwijderenToolStripMenuItem.Text = "&Verwijderen";
			// 
			// ArtikelVerwijderenToolStripMenuBar
			// 
			this.ArtikelVerwijderenToolStripMenuBar.Name = "ArtikelVerwijderenToolStripMenuBar";
			this.ArtikelVerwijderenToolStripMenuBar.Size = new System.Drawing.Size(183, 22);
			this.ArtikelVerwijderenToolStripMenuBar.Text = "Artikel verwijderen";
			// 
			// InstellingenToolStripMenuBar
			// 
			this.InstellingenToolStripMenuBar.Name = "InstellingenToolStripMenuBar";
			this.InstellingenToolStripMenuBar.Size = new System.Drawing.Size(80, 20);
			this.InstellingenToolStripMenuBar.Text = "&Instellingen";
			this.InstellingenToolStripMenuBar.Click += new System.EventHandler(this.InstellingenToolStripMenuBar_Click);
			// 
			// SluitenToolStripMenuBar
			// 
			this.SluitenToolStripMenuBar.Name = "SluitenToolStripMenuBar";
			this.SluitenToolStripMenuBar.Size = new System.Drawing.Size(55, 20);
			this.SluitenToolStripMenuBar.Text = "&Sluiten";
			this.SluitenToolStripMenuBar.Click += new System.EventHandler(this.SluitenToolStripMenuBar_Click);
			// 
			// AfdelingVerwijderenToolStripMenuBar
			// 
			this.AfdelingVerwijderenToolStripMenuBar.Name = "AfdelingVerwijderenToolStripMenuBar";
			this.AfdelingVerwijderenToolStripMenuBar.Size = new System.Drawing.Size(183, 22);
			this.AfdelingVerwijderenToolStripMenuBar.Text = "Afdeling verwijderen";
			// 
			// TmrDbCheck
			// 
			this.TmrDbCheck.Enabled = true;
			this.TmrDbCheck.Interval = 60000;
			this.TmrDbCheck.Tick += new System.EventHandler(this.TmrDbCheck_Tick);
			// 
			// NewStartingScreen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.PboxLogo);
			this.Controls.Add(this.MenuBar);
			this.IsMdiContainer = true;
			this.Name = "NewStartingScreen";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "NewStartingScreen";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.NewStartingScreen_Load);
			((System.ComponentModel.ISupportInitialize)(this.PboxLogo)).EndInit();
			this.MenuBar.ResumeLayout(false);
			this.MenuBar.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox PboxLogo;
		private System.Windows.Forms.MenuStrip MenuBar;
		private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem nieuweArtikelenToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem InstellingenToolStripMenuBar;
		private System.Windows.Forms.ToolStripMenuItem SluitenToolStripMenuBar;
		private System.Windows.Forms.ToolStripMenuItem losArtikelToevoegenToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem AfdelingToevoegenToolStripMenuBar;
		private System.Windows.Forms.ToolStripMenuItem ArtikelToevoegenToolStripMenuBar;
		private System.Windows.Forms.ToolStripMenuItem BestandToevoegenToolStripMenuBar;
		private System.Windows.Forms.ToolStripMenuItem artikelAanpassenToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ArtikelAanpassenToolStripMenuBar;
		private System.Windows.Forms.ToolStripMenuItem AfdelingAanpassenToolStripMenuBar;
		private System.Windows.Forms.ToolStripMenuItem verwijderenToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ArtikelVerwijderenToolStripMenuBar;
		private System.Windows.Forms.ToolStripMenuItem VoorraadBekijkenToolStripMenuBar;
		private System.Windows.Forms.ToolStripMenuItem AfdelingVerwijderenToolStripMenuBar;
		private System.Windows.Forms.Timer TmrDbCheck;
	}
}