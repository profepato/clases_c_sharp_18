﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_WF_140818 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnMenu_Click(object sender, EventArgs e) {
            FormMenu fm = new FormMenu();
            fm.Show();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e) {
            if (MessageBox.Show(
                "Desea abrir el formulario?",
                "título",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Information
                ) == DialogResult.Yes) {
                new FormMenu().Show();
            }
            
        }
    }
}
