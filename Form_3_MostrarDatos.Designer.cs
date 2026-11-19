namespace Parcial_2_Introduccion_al_Analisis_de_datos
{
    partial class Form_3_MostrarDatos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            lblTituloBP = new Label();
            lblAnualBP = new Label();
            lblTituloBN = new Label();
            lblAnualBN = new Label();
            lblTituloBH = new Label();
            lblAnualBH = new Label();
            lblRenAnual = new Label();
            lblRenTrimestral = new Label();
            lblRenMensual = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(453, 9);
            label1.Name = "label1";
            label1.Size = new Size(429, 41);
            label1.TabIndex = 0;
            label1.Text = "Promedio anual de cada banco";
            // 
            // lblTituloBP
            // 
            lblTituloBP.AutoSize = true;
            lblTituloBP.Font = new Font("Segoe UI", 9F);
            lblTituloBP.Location = new Point(44, 60);
            lblTituloBP.Name = "lblTituloBP";
            lblTituloBP.Size = new Size(140, 25);
            lblTituloBP.TabIndex = 1;
            lblTituloBP.Text = "Banco Provincia:";
            // 
            // lblAnualBP
            // 
            lblAnualBP.AutoSize = true;
            lblAnualBP.Font = new Font("Segoe UI", 9F);
            lblAnualBP.Location = new Point(84, 95);
            lblAnualBP.Name = "lblAnualBP";
            lblAnualBP.Size = new Size(0, 25);
            lblAnualBP.TabIndex = 2;
            // 
            // lblTituloBN
            // 
            lblTituloBN.AutoSize = true;
            lblTituloBN.Font = new Font("Segoe UI", 9F);
            lblTituloBN.Location = new Point(573, 60);
            lblTituloBN.Name = "lblTituloBN";
            lblTituloBN.Size = new Size(124, 25);
            lblTituloBN.TabIndex = 3;
            lblTituloBN.Text = "Banco Nación:";
            // 
            // lblAnualBN
            // 
            lblAnualBN.AutoSize = true;
            lblAnualBN.Font = new Font("Segoe UI", 9F);
            lblAnualBN.Location = new Point(605, 97);
            lblAnualBN.Name = "lblAnualBN";
            lblAnualBN.Size = new Size(0, 25);
            lblAnualBN.TabIndex = 4;
            // 
            // lblTituloBH
            // 
            lblTituloBH.AutoSize = true;
            lblTituloBH.Font = new Font("Segoe UI", 9F);
            lblTituloBH.Location = new Point(1068, 60);
            lblTituloBH.Name = "lblTituloBH";
            lblTituloBH.Size = new Size(161, 25);
            lblTituloBH.TabIndex = 5;
            lblTituloBH.Text = "Banco Hipotecário:";
            // 
            // lblAnualBH
            // 
            lblAnualBH.AutoSize = true;
            lblAnualBH.Font = new Font("Segoe UI", 9F);
            lblAnualBH.Location = new Point(1120, 97);
            lblAnualBH.Name = "lblAnualBH";
            lblAnualBH.Size = new Size(0, 25);
            lblAnualBH.TabIndex = 6;
            // 
            // lblRenAnual
            // 
            lblRenAnual.AutoSize = true;
            lblRenAnual.Location = new Point(44, 302);
            lblRenAnual.Name = "lblRenAnual";
            lblRenAnual.Size = new Size(16, 25);
            lblRenAnual.TabIndex = 7;
            lblRenAnual.Text = ".";
            // 
            // lblRenTrimestral
            // 
            lblRenTrimestral.AutoSize = true;
            lblRenTrimestral.Location = new Point(573, 302);
            lblRenTrimestral.Name = "lblRenTrimestral";
            lblRenTrimestral.Size = new Size(16, 25);
            lblRenTrimestral.TabIndex = 8;
            lblRenTrimestral.Text = ".";
            // 
            // lblRenMensual
            // 
            lblRenMensual.AutoSize = true;
            lblRenMensual.Location = new Point(979, 302);
            lblRenMensual.Name = "lblRenMensual";
            lblRenMensual.Size = new Size(16, 25);
            lblRenMensual.TabIndex = 9;
            lblRenMensual.Text = ".";
            // 
            // Form_3_MostrarDatos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1365, 592);
            Controls.Add(lblRenMensual);
            Controls.Add(lblRenTrimestral);
            Controls.Add(lblRenAnual);
            Controls.Add(lblAnualBH);
            Controls.Add(lblTituloBH);
            Controls.Add(lblAnualBN);
            Controls.Add(lblTituloBN);
            Controls.Add(lblAnualBP);
            Controls.Add(lblTituloBP);
            Controls.Add(label1);
            Name = "Form_3_MostrarDatos";
            Text = "Parcial 2 - Introducción al análisis de datos";
            Load += Form_3_MostrarDatos_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void Form_3_MostrarDatos_Load(object sender, EventArgs e)
        {
        }

        #endregion

        private Label label1;
        private Label lblTituloBP;
        private Label lblAnualBP;
        private Label lblTituloBN;
        private Label lblAnualBN;
        private Label lblTituloBH;
        private Label lblAnualBH;
        private Label lblRenAnual;
        private Label lblRenTrimestral;
        private Label lblRenMensual;
    }
}