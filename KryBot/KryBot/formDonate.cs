﻿using System;
using System.Drawing;
using System.Windows.Forms;
using KryBot.Properties;

namespace KryBot
{
    public partial class FormDonate : Form
    {
        public FormDonate()
        {
            InitializeComponent();
        }

        private void formDonate_Load(object sender, EventArgs e)
        {
            Design();
        }

        private void Design()
        {
            Icon = Icon.FromHandle(Resources.wallet.GetHicon());
            Text = @"Донат";

            textBoxWMR.Text = @"R287737597223";
            textBoxWMR.ReadOnly = true;
            textBoxWMZ.Text = @"Z332499191215";
            textBoxWMZ.ReadOnly = true;
            textBoxWMU.Text = @"U353566680538";
            textBoxWMU.ReadOnly = true;
            textBoxYandex.Text = @"410011518354546";
            textBoxYandex.ReadOnly = true;
            textBoxPayPal.Text = @"kribetko@gmail.com";
            textBoxPayPal.ReadOnly = true;
        }
    }
}