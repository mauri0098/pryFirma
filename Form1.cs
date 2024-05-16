using System.Windows.Forms;

namespace pryFirma
{
    public partial class frmFirma : Form
    {
        private Bitmap imagen;
        public frmFirma()
        {
            InitializeComponent();
            imagen = new Bitmap(pbFirma.Width, pbFirma.Height);
        }

        private void pbFirma_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && rdBlue.Checked == true)
            {
                using (Graphics objetoLoco = Graphics.FromImage(imagen))
                {
                    objetoLoco.FillEllipse(Brushes.Blue, e.X, e.Y, 5, 5);
                }
                pbFirma.Image = imagen;
            }
            else if (e.Button == MouseButtons.Left && rdRed.Checked == true)
            {
                using (Graphics objetoLoco = Graphics.FromImage(imagen))
                {
                    objetoLoco.FillEllipse(Brushes.Red, e.X, e.Y, 5, 5);
                }
                pbFirma.Image = imagen;
            }
            else if (e.Button == MouseButtons.Left && rdYellow.Checked == true)
            {
                using (Graphics objetoLoco = Graphics.FromImage(imagen))
                {
                    objetoLoco.FillEllipse(Brushes.Yellow, e.X, e.Y, 5, 5);
                }
                pbFirma.Image = imagen;
            }


        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            imagen = new Bitmap(pbFirma.Width, pbFirma.Height); // Crea una nueva imagen en blanco
            pbFirma.Image = imagen; // Asigna la nueva imagen al PictureBox
        }
    }
}
