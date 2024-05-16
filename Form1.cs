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
            else if (e.Button == MouseButtons.Left && rdOrange.Checked == true)
            {
                using (Graphics objetoLoco = Graphics.FromImage(imagen))
                {
                    objetoLoco.FillEllipse(Brushes.Orange, e.X, e.Y, 5, 5);
                }
                pbFirma.Image = imagen;
            }


        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            imagen = new Bitmap(pbFirma.Width, pbFirma.Height); 
            pbFirma.Image = imagen; 
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DateTime FECHAHORA_ACTUAL = DateTime.Now;
            string NOMBRE_ARCHIVO = $"Firma_{FECHAHORA_ACTUAL:yyyy.MM.dd}_{FECHAHORA_ACTUAL:HH.mm}hrs.jpg";
            string CARPETA_GUARDADO = Path.Combine(Application.StartupPath, "Firmas");
            string RUTA_ARCHIVO = Path.Combine(CARPETA_GUARDADO, NOMBRE_ARCHIVO);

            // Asegúrate de que la carpeta exista
            if (!Directory.Exists(CARPETA_GUARDADO))
            {
                Directory.CreateDirectory(CARPETA_GUARDADO);
            }

            imagen.Save(RUTA_ARCHIVO, System.Drawing.Imaging.ImageFormat.Jpeg);
            MessageBox.Show("La firma ha sido guardada exitosamente.");
            this.Close();

        }
    }
}
