﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escola
{
    public partial class F_Professor : Form
    {
        public F_Professor(Form1 f)
        {
            f.Visible = false;
            InitializeComponent();
        }

        private void F_Professor_Load(object sender, EventArgs e)
        {

        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_CadastrarAluno janelaCDAluno = new F_CadastrarAluno();
            janelaCDAluno.ShowDialog();
        }
    }
}
