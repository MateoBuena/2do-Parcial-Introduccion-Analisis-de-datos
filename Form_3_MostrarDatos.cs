using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Parcial_2_Introduccion_al_Analisis_de_datos
{
    public partial class Form_3_MostrarDatos : Form
    {
        private double txtBP2023=0;
        private double txtBP2024=0;
        private double txtBP2025=0;

        private double txtBN2023=0;
        private double txtBN2024=0;
        private double txtBN2025=0;
        
        private double txtBH2023=0;
        private double txtBH2024=0;
        private double txtBH2025=0;

        public double Capital = 850000;//$850.000 ->Ochocientos cincuenta mil

        public Form_3_MostrarDatos()
        {
            InitializeComponent();
            this.FormClosed += (s, e) => Application.Exit();
            
        }

        public Form_3_MostrarDatos(string txtBP2023, string txtBP2024, string txtBP2025, string txtBN2023, string txtBN2024, string txtBN2025, string txtBH2023, string txtBH2024, string txtBH2025)
        {
            InitializeComponent();
            this.FormClosed += (s, e) => Application.Exit();

            //Datos del banco provincia
            this.txtBP2023 =double.Parse(txtBP2023);
            this.txtBP2024 =double.Parse(txtBP2024);
            this.txtBP2025 =double.Parse(txtBP2025);
            
            //Datos del banco nacion
            this.txtBN2023 = double.Parse(txtBN2023);
            this.txtBN2024 = double.Parse(txtBN2024);
            this.txtBN2025 = double.Parse(txtBN2025);

            //Datos del banco hipotecario
            this.txtBH2023 = double.Parse(txtBH2023);
            this.txtBH2024 = double.Parse(txtBH2024);
            this.txtBH2025 = double.Parse(txtBH2025);

            lblAnualBP.Text = Math.Round((PromBP()*100),2).ToString().ToUpper() + " %";
            lblAnualBN.Text = Math.Round((PromBN()*100),2).ToString().ToUpper() + " %";
            lblAnualBH.Text = Math.Round((PromBH()*100),2).ToString().ToUpper() + " %";

            lblRenAnual.Text = InversionAnual();
            lblRenTrimestral.Text = InversionTrimestral();
            lblRenMensual.Text = InversionMensual();
        }


        //PROMEDIOS ANUALES DE CADA BANCO
        public double PromBP()
        {
            return Math.Round(((txtBP2023 + txtBP2024 + txtBP2025)/ 300),4);
        }

        public double PromBN()
        {
            return Math.Round(((txtBN2023 + txtBN2024 + txtBN2025) / 300),4);
        }

        public double PromBH()
        {
            return Math.Round(((txtBH2023 + txtBH2024 + txtBH2025) / 300),4);
        }

        //INVERSIONES ANUALES DE CADA BANCO

        public double InversionAnualBP()
        {
            return (Math.Round((Capital * (1 + PromBP())), 2)- Capital);
        }

        public double InversionAnualBN()
        {
            return (Math.Round((Capital * (1 + PromBN())), 2)- Capital);
        }

        public double InversionAnualBH()
        {
            return (Math.Round((Capital * (1 + PromBH())), 2)- Capital);
        }

        //INVERSIONES TRIMESTRALES DE CADA BANCO

        public double InversionTrimestralBP()
        {
            double Inversion = Capital;
            
            double trimestre = (PromBP()) / 4;
            
            for (int i = 1; i <= 4; i++)
            {
                Inversion *= (1 + trimestre);
            }
            
            return Math.Round(Inversion - Capital, 2);
        }

        public double InversionTrimestralBN()
        {
            double Inversion = Capital;
            
            double trimestre = (PromBN()) / 4;
            
            for (int i = 1; i <= 4; i++)
            {
                Inversion *= (1 + trimestre);
            }
            
            return Math.Round(Inversion - Capital, 2);
        }

        public double InversionTrimestralBH()
        {
            double Inversion = Capital;
            
            double trimestre = (PromBH()) / 4;
            
            for (int i = 1; i <= 4; i++)
            {
                Inversion *= (1 + trimestre);
            }
            
            return Math.Round(Inversion - Capital, 2);
        }

        //INVERSIONES MENSUALES DE CADA BANCO

        public double InversionMensualBP()
        {
            double Inversion = Capital;
            
            double mes = (PromBP()) / 12;
            
            for (int i = 1; i <= 12; i++)
            {
                Inversion *= (1 + mes);
            }
            
            return Math.Round(Inversion - Capital, 2);
        }

        public double InversionMensualBN()
        {
            double Inversion = Capital;
            
            double mes = (PromBN()) / 12;
            
            for (int i = 1; i <= 12; i++)
            {
                Inversion *= (1 + mes);
            }
            
            return Math.Round(Inversion - Capital, 2);
        }

        public double InversionMensualBH()
        {
            double Inversion = Capital;
            
            double mes = (PromBH()) / 12;
            
            for (int i = 1; i <= 12; i++)
            {
                Inversion *= (1 + mes);
            }
            
            return Math.Round(Inversion - Capital, 2);
        }

        //FUNCION PARA OBTENER EL RENDIMIENTO ANUAL DE TODOS LOS BANCOS ORDENADOS DE MAYOR A MENOR
        public string InversionAnual()
        {
            string text = "Inversion Anual: \n \n";
            
            double[] Vinversion = { InversionAnualBP(), InversionAnualBN(), InversionAnualBH()};

            Array.Sort(Vinversion);

            Array.Reverse(Vinversion);

            foreach(double inv in Vinversion)
            {
                if(inv == InversionAnualBP())
                {
                    text += "- Banco Provincia: $" + inv.ToString() + "\n \n";
                }
                else if (inv == InversionAnualBN())
                {
                    text += "- Banco Nación: $" + inv.ToString() + "\n \n";
                }
                else if (inv == InversionAnualBH())
                {
                    text += "- Banco Hipotecario: $" + inv.ToString() + "\n \n";
                }
            }
            
            return text;
        }

        //FUNCION PARA OBTENER EL RENDIMIENTO TRIMESTRAL DE TODOS LOS BANCOS ORDENADOS DE MAYOR A MENOR
        public string InversionTrimestral()
        {
            string text = "Inversion Trimestral: \n \n";

            double[] Vinversion = { InversionTrimestralBP(), InversionTrimestralBN(), InversionTrimestralBH() };

            Array.Sort(Vinversion);

            Array.Reverse(Vinversion);

            foreach (double inv in Vinversion)
            {
                if (inv == InversionTrimestralBP())
                {
                    text += "- Banco Provincia: $" + inv.ToString() + "\n \n";
                }
                else if (inv == InversionTrimestralBN())
                {
                    text += "- Banco Nación: $" + inv.ToString() + "\n \n";
                }
                else if (inv == InversionTrimestralBH())
                {
                    text += "- Banco Hipotecario: $" + inv.ToString() + "\n \n";
                }
            }

            return text;
        }

        //FUNCION PARA OBTENER EL RENDIMIENTO MENSUAL DE TODOS LOS BANCOS ORDENADOS DE MAYOR A MENOR
        public string InversionMensual()
        {
            string text = "Inversion Mensual: \n \n";

            double[] Vinversion = { InversionMensualBP(), InversionMensualBN(), InversionMensualBH() };

            Array.Sort(Vinversion);

            Array.Reverse(Vinversion);

            foreach (double inv in Vinversion)
            {
                if (inv == InversionMensualBP())
                {
                    text += "- Banco Provincia: $" + inv.ToString() + "\n \n";
                }
                else if (inv == InversionMensualBN())
                {
                    text += "- Banco Nación: $" + inv.ToString() + "\n \n";
                }
                else if (inv == InversionMensualBH())
                {
                    text += "- Banco Hipotecario: $" + inv.ToString() + "\n \n";
                }
            }

            return text;
        }

    }
}
