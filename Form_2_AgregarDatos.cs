using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Parcial_2_Introduccion_al_Analisis_de_datos
{
    public partial class Form_2_AgregarDatos : Form
    {
        public Form_2_AgregarDatos()
        {
            InitializeComponent();
            this.FormClosed += (s, e) => Application.Exit();
            
            TextBox[] cajas =
            {
                txtBP2023, txtBP2024, txtBP2025,
                txtBN2023, txtBN2024, txtBN2025,
                txtBH2023, txtBH2024, txtBH2025
            };

            foreach (TextBox txt in cajas)
            {
                txt.KeyPress += Tasa_KeyPress;
            }
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            if( txtBP2023.Text=="" || txtBP2024.Text=="" || txtBP2025.Text=="" ||
                txtBN2023.Text=="" || txtBN2024.Text=="" || txtBN2025.Text=="" ||
                txtBH2023.Text=="" || txtBH2024.Text=="" || txtBH2025.Text=="")
            {
                lblError.ForeColor = Color.Red;
                lblError.Text ="No se puede continuar sin completar todos los campos";
                return;
            }
            Form_3_MostrarDatos form = new Form_3_MostrarDatos(txtBP2023.Text
                , txtBP2024.Text
                , txtBP2025.Text
                , txtBN2023.Text
                , txtBN2024.Text
                , txtBN2025.Text
                , txtBH2023.Text
                , txtBH2024.Text
                , txtBH2025.Text);
            form.StartPosition = FormStartPosition.Manual;
            form.Location = this.Location;
            form.Size = this.Size;
            form.Show();
            this.Hide();
        }

        private void Tasa_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txt = (TextBox)sender;

            if (char.IsControl(e.KeyChar))
                return;

            string nuevoTexto = txt.Text
                .Remove(txt.SelectionStart, txt.SelectionLength)
                .Insert(txt.SelectionStart, e.KeyChar.ToString());

            if (!Regex.IsMatch(nuevoTexto, @"^[0-9]{1,3}(\,[0-9]{0,2})?$"))
            {
                e.Handled = true;
            }
        }
    }
}
