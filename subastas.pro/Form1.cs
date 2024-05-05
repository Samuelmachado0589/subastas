namespace subastas.pro
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }
        public List<object> frmSubastas;

        private void participacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
           

            frmGestion form1 = new frmGestion();

            // Call the method and store the result in a variable
            List<string> datosParaTransferir = form1.ObtenerDatosdgv();

            frmSubastas frmSubasta = new frmSubastas();


            frmSubasta.AgregarElementosAlListBox(datosParaTransferir);

            frmSubasta.BringToFront();


            frmSubasta.MdiParent = this;

            frmSubasta.Show();

        }

        private void gestionToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }


        private void resgistrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGestion Registros = new frmGestion();


            Registros.BringToFront();

            Registros.MdiParent = this;
            Registros.Show();

        }

    }
}
