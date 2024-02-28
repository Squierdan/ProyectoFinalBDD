namespace ProyectoFinalBDD
{
    public partial class Ventana1 : Form
    {
        private object textBoxDisplay;
        private object textBoxNombre;
        private object textBoxApellido;
        private object textBoxCorreo;
        private object textBoxCedula;

        public Ventana1()
        {
            InitializeComponent();
            btnIngresar.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private bool datosIngresados = false; // Variable para controlar si los datos han sido ingresados

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Agregar los datos ingresados al DataGridView
            int n = dgvDatos.Rows.Add(); // Agrega una nueva fila
            dgvDatos.Rows[n].Cells[0].Value = txtNombre.Text;
            dgvDatos.Rows[n].Cells[1].Value = txtApellido.Text;
            dgvDatos.Rows[n].Cells[2].Value = txtCorreo.Text;
            dgvDatos.Rows[n].Cells[3].Value = txtCedula.Text;

            // Habilitar el botón de Ingresar al Sistema
            datosIngresados = true;
            btnIngresar.Enabled = true;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (datosIngresados) // Verifica que los datos hayan sido ingresados
            {
                Ventana2 segundaVentana = new Ventana2();
                this.Hide(); // Opcional: Ocultar la ventana actual.
                segundaVentana.Show(); // Muestra la segunda ventana.
            }
            else
            {
                MessageBox.Show("Por favor, guarde los datos antes de ingresar al sistema.");
            }
        }
    }
}