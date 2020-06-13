﻿using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GBM_Dashboard
{
    public partial class Main_Form : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public Main_Form()
        {
            InitializeComponent();
        }

        private void accordionControlElement2_Click(object sender, EventArgs e)
        {
            GBM_IVA gBM_IVA = new GBM_IVA();
            MainControlClass.showControl(gBM_IVA, Content);
        }

        private void Main_Form_Load(object sender, EventArgs e)
        {
            GBM_IVA gBM_IVA = new GBM_IVA();
            MainControlClass.showControl(gBM_IVA, Content);
        }

        private void accordionControlElement4_Click(object sender, EventArgs e)
        {
            ///Configuration configuration = new Configuration();
            //MainControlClass.showControl(configuration, Content);
        }
    }
}
