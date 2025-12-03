using System;

namespace aplicacionTelegrama
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private void btnCalcularPrecio_Click(object sender, EventArgs e)
        {
            string textoTelegrama;
            char tipoTelegrama = ' ';
            int numPalabras = 0;
            double coste;
            //Leo el telegrama
            textoTelegrama = txtTelegramas.Text;
            // telegrama urgente?
            if (chkUrgentes.Checked)
            {
                tipoTelegrama = 'u';
            }
            //Obtengo el número de palabras que forma el telegrama
            numPalabras = textoTelegrama.Length;
            //Si el telegrama es ordinario
            if (tipoTelegrama == 'o')
            {
                if (numPalabras <= 10)
                {
                    coste = 2.5;
                }
                else
                {
                    coste = 0.5 * numPalabras;
                }
            }
            else
            //Si el telegrama es urgente
            {
                if (tipoTelegrama == 'u')
                {
                    if (numPalabras <= 10)
                    {
                        coste = 5;
                    }
                    else
                    {
                        coste = 5 + 0.75 * (numPalabras - 10);
                    }
                }
                else
                {
                    coste = 0;
                }
            }
            txtPrecios.Text = coste.ToString() + " euros";
        }
        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtTelegramas = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkUrgentes = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrecios = new System.Windows.Forms.TextBox();
            this.btnCalcularPrecios = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTelegramas
            // 
            this.txtTelegramas.Location = new System.Drawing.Point(42, 39);
            this.txtTelegramas.Multiline = true;
            this.txtTelegramas.Name = "txtTelegramas";
            this.txtTelegramas.Size = new System.Drawing.Size(142, 36);
            this.txtTelegramas.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Texto";
            // 
            // chkUrgentes
            // 
            this.chkUrgentes.AutoSize = true;
            this.chkUrgentes.Location = new System.Drawing.Point(42, 82);
            this.chkUrgentes.Name = "chkUrgentes";
            this.chkUrgentes.Size = new System.Drawing.Size(70, 17);
            this.chkUrgentes.TabIndex = 2;
            this.chkUrgentes.Text = "Urgente?";
            this.chkUrgentes.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Coste:";
            // 
            // txtPrecios
            // 
            this.txtPrecios.Location = new System.Drawing.Point(84, 106);
            this.txtPrecios.Name = "txtPrecios";
            this.txtPrecios.Size = new System.Drawing.Size(100, 20);
            this.txtPrecios.TabIndex = 4;
            // 
            // btnCalcularPrecios
            // 
            this.btnCalcularPrecios.Location = new System.Drawing.Point(45, 139);
            this.btnCalcularPrecios.Name = "btnCalcularPrecios";
            this.btnCalcularPrecios.Size = new System.Drawing.Size(75, 23);
            this.btnCalcularPrecios.TabIndex = 5;
            this.btnCalcularPrecios.Text = "Calcular";
            this.btnCalcularPrecios.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(213, 190);
            this.Controls.Add(this.btnCalcularPrecios);
            this.Controls.Add(this.txtPrecios);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chkUrgentes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTelegramas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTelegramas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkUrgentes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrecios;
        private System.Windows.Forms.Button btnCalcularPrecios;
    }
}

