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
    public partial class F_Diretor : Form
    {
        public F_Diretor(Form1 f)
        {
            InitializeComponent();
            f.Visible = false;
        }

        private void F_Diretor_Load(object sender, EventArgs e)
        {

        }
        /*
        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           F_CadastrarProf janelaCadastrarProf = new F_CadastrarProf();
            janelaCadastrarProf.ShowDialog();
        }
        */
        private void cadastrarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            F_CadastrarProf janelaCadastrarProf = new F_CadastrarProf();
            janelaCadastrarProf.ShowDialog();
        }
    }
}
