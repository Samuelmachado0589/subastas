using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace subastas.pro
{
    public partial class frmSubastas : Form
    {
        public frmSubastas()
        {
            InitializeComponent();
        }



        public void AgregarElementosAlListBox(List<string> elementos)
        {
            foreach (var elemento in elementos)
            {
                ltbSubasta.Items.Add(elemento);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
