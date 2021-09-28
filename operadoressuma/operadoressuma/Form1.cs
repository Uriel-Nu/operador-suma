using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace operadoressuma
{
    public partial class suma : Form
    {
        public suma()
        {
            InitializeComponent();
        }

        private void butigual_Click(object sender, EventArgs e)
        {
            if (txtsumar.Text=="+")

            {
                int opc1 = System.Convert.ToInt32(txtprimernumero.Text);
                int opc2 = System.Convert.ToInt32(txtsegundonumero.Text);
                int result = opc1 + opc2;
                txtigual.Text = result.ToString();
                
            }
            else
            { txtigual.Text = "ERROR"; }
        }

        private void txtigual_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
