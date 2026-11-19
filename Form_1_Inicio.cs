namespace Parcial_2_Introduccion_al_Analisis_de_datos
{
    public partial class Form_1_Inicio : Form
    {
        public Form_1_Inicio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_2_AgregarDatos form2 = new Form_2_AgregarDatos();

            form2.StartPosition = FormStartPosition.Manual;
            form2.Location = this.Location;
            form2.Size = this.Size;
            form2.Show();
            this.Hide();

        }
    }
}
