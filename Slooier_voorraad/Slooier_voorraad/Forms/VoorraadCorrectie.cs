﻿using System;
using System.Windows.Forms;

namespace Slooier_voorraad.Forms
{
	public partial class VoorraadCorrectie : Form
	{
		string ConnString;
		public VoorraadCorrectie(string ConnString, FormWindowState windowState)
		{
			InitializeComponent();
			this.ConnString = ConnString;
			WindowState = windowState;
		}

		private void PMain_SizeChanged(object sender, EventArgs e)
		{
			// Set minimumsize
			MinimumSize = new System.Drawing.Size(800, 600);
			// Set panels to center of the Form
			PMain.Left = (ClientSize.Width - PMain.Width) / 2;
			PMain.Top = (ClientSize.Height - PMain.Height) / 2;
		}
	}
}
