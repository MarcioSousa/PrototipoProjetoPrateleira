using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace View
{
    public partial class FrmPrateleira : Form
    {
        public FrmPrateleira()
        {
            InitializeComponent();
            DgvPrateleira.AutoGenerateColumns = false;
        }

        private static void CarregaTodasPrateleiras()
        {
            try
            {
                Localizacao localizacao = new();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void FrmPrateleira_Load(object sender, EventArgs e)
        {
            CarregaTodasPrateleiras();
        }
    }
}
