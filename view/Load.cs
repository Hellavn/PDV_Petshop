using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Petshop.view
{
    public partial class Load : Form
    {
        public Load()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (progressBar.Value <100)
            {
                progressBar.Value = progressBar.Value + 5;
            }
            else
            {
                timer.Enabled = false;
                telaLogin login = new telaLogin();
                this.Hide();
                login.Show();
            }
        }
    }
}
