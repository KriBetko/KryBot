﻿using System.Drawing;
using KryBot.CommonResources.Localization;
using KryBot.Core;
using KryBot.Gui.WinFormsGui.Properties;

namespace KryBot.Gui.WinFormsGui.Forms
{
	partial class FormDonate
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxWMU = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxWMZ = new System.Windows.Forms.TextBox();
            this.textBoxWMR = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxYandex = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxPayPal = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "You can help the developer material transfer any amount to one of the accounts, i" +
    "ven below:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxWMU);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxWMZ);
            this.groupBox1.Controls.Add(this.textBoxWMR);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 94);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "WebMoney";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "WMU: ";
            // 
            // textBoxWMU
            // 
            this.textBoxWMU.Location = new System.Drawing.Point(53, 65);
            this.textBoxWMU.Name = "textBoxWMU";
            this.textBoxWMU.ReadOnly = true;
            this.textBoxWMU.Size = new System.Drawing.Size(201, 20);
            this.textBoxWMU.TabIndex = 4;
            this.textBoxWMU.Text = "U353566680538";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "WMZ: ";
            // 
            // textBoxWMZ
            // 
            this.textBoxWMZ.Location = new System.Drawing.Point(53, 39);
            this.textBoxWMZ.Name = "textBoxWMZ";
            this.textBoxWMZ.ReadOnly = true;
            this.textBoxWMZ.Size = new System.Drawing.Size(201, 20);
            this.textBoxWMZ.TabIndex = 2;
            this.textBoxWMZ.Text = "Z332499191215";
            // 
            // textBoxWMR
            // 
            this.textBoxWMR.Location = new System.Drawing.Point(53, 13);
            this.textBoxWMR.Name = "textBoxWMR";
            this.textBoxWMR.ReadOnly = true;
            this.textBoxWMR.Size = new System.Drawing.Size(201, 20);
            this.textBoxWMR.TabIndex = 1;
            this.textBoxWMR.Text = "R287737597223";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "WMR: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxYandex);
            this.groupBox2.Location = new System.Drawing.Point(12, 151);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(260, 53);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Yandex.Money";
            // 
            // textBoxYandex
            // 
            this.textBoxYandex.Location = new System.Drawing.Point(9, 19);
            this.textBoxYandex.Name = "textBoxYandex";
            this.textBoxYandex.ReadOnly = true;
            this.textBoxYandex.Size = new System.Drawing.Size(245, 20);
            this.textBoxYandex.TabIndex = 0;
            this.textBoxYandex.Text = "410011518354546";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBoxPayPal);
            this.groupBox3.Location = new System.Drawing.Point(12, 210);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(260, 57);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "PayPal";
            // 
            // textBoxPayPal
            // 
            this.textBoxPayPal.Location = new System.Drawing.Point(9, 19);
            this.textBoxPayPal.Name = "textBoxPayPal";
            this.textBoxPayPal.ReadOnly = true;
            this.textBoxPayPal.Size = new System.Drawing.Size(245, 20);
            this.textBoxPayPal.TabIndex = 0;
            this.textBoxPayPal.Text = "kribetko@gmail.com";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.linkLabel1);
            this.groupBox4.Location = new System.Drawing.Point(12, 273);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(260, 49);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Steam";
            // 
            // linkLabel1
            // 
            this.linkLabel1.Location = new System.Drawing.Point(9, 16);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(245, 30);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "https://steamcommunity.com/tradeoffer/new/?partner=107171644&token=eSC3IOi7";
            this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // FormDonate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 337);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDonate";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Donate";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBoxWMU;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBoxWMZ;
		private System.Windows.Forms.TextBox textBoxWMR;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox textBoxYandex;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.TextBox textBoxPayPal;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.LinkLabel linkLabel1;

		public void Localization()
		{
			label1.Text = strings.DonateForm_Text;
			linkLabel1.Text = Links.SteamTradeUrl;
			Text = strings.DonateForm_Donate;
			Icon = Icon = Icon.FromHandle(Resources.wallet.GetHicon());
		}
	}
}