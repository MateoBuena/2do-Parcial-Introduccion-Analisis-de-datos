namespace Parcial_2_Introduccion_al_Analisis_de_datos
{
    partial class Form_1_Inicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelTitulo = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Segoe UI", 15F);
            labelTitulo.Location = new Point(442, 146);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(578, 41);
            labelTitulo.TabIndex = 0;
            labelTitulo.Text = "Parcial 2 - Introducción al análisis de datos";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 13F);
            button1.Location = new Point(660, 264);
            button1.Name = "button1";
            button1.Size = new Size(166, 73);
            button1.TabIndex = 1;
            button1.Text = "Entrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form_1_Inicio
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1402, 601);
            Controls.Add(button1);
            Controls.Add(labelTitulo);
            Name = "Form_1_Inicio";
            Text = "Parcial 2 - Introducción al análisis de datos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitulo;
        private Button button1;
    }
}
