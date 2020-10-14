namespace FormComplejos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.txtbComReal1 = new System.Windows.Forms.TextBox();
            this.txtbComReal2 = new System.Windows.Forms.TextBox();
            this.lbOperador = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbResultadoSuma = new System.Windows.Forms.Label();
            this.btnSumar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtbComImag1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtbComImag2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.rdbSuma = new System.Windows.Forms.RadioButton();
            this.rdbResta = new System.Windows.Forms.RadioButton();
            this.rdbMultiplicacion = new System.Windows.Forms.RadioButton();
            this.rdbConjugar = new System.Windows.Forms.RadioButton();
            this.btnRestar = new System.Windows.Forms.Button();
            this.btnMultiplicar = new System.Windows.Forms.Button();
            this.btnConjugar = new System.Windows.Forms.Button();
            this.lbConjugar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtbComReal1
            // 
            this.txtbComReal1.Location = new System.Drawing.Point(68, 104);
            this.txtbComReal1.Name = "txtbComReal1";
            this.txtbComReal1.Size = new System.Drawing.Size(56, 26);
            this.txtbComReal1.TabIndex = 0;
            this.txtbComReal1.Text = "1";
            // 
            // txtbComReal2
            // 
            this.txtbComReal2.Location = new System.Drawing.Point(310, 104);
            this.txtbComReal2.Name = "txtbComReal2";
            this.txtbComReal2.Size = new System.Drawing.Size(58, 26);
            this.txtbComReal2.TabIndex = 1;
            this.txtbComReal2.Text = "2";
            // 
            // lbOperador
            // 
            this.lbOperador.AutoSize = true;
            this.lbOperador.Location = new System.Drawing.Point(263, 110);
            this.lbOperador.Name = "lbOperador";
            this.lbOperador.Size = new System.Drawing.Size(18, 20);
            this.lbOperador.TabIndex = 2;
            this.lbOperador.Text = "+";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(507, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "=";
            // 
            // lbResultadoSuma
            // 
            this.lbResultadoSuma.AutoSize = true;
            this.lbResultadoSuma.Location = new System.Drawing.Point(531, 107);
            this.lbResultadoSuma.Name = "lbResultadoSuma";
            this.lbResultadoSuma.Size = new System.Drawing.Size(39, 20);
            this.lbResultadoSuma.TabIndex = 2;
            this.lbResultadoSuma.Text = "3+5i";
            // 
            // btnSumar
            // 
            this.btnSumar.Location = new System.Drawing.Point(73, 185);
            this.btnSumar.Name = "btnSumar";
            this.btnSumar.Size = new System.Drawing.Size(75, 45);
            this.btnSumar.TabIndex = 3;
            this.btnSumar.Text = "Sumar";
            this.btnSumar.UseVisualStyleBackColor = true;
            this.btnSumar.Click += new System.EventHandler(this.btnSumar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(100, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Complejo 1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(327, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Complejo 2";
            // 
            // txtbComImag1
            // 
            this.txtbComImag1.Location = new System.Drawing.Point(169, 104);
            this.txtbComImag1.Name = "txtbComImag1";
            this.txtbComImag1.Size = new System.Drawing.Size(56, 26);
            this.txtbComImag1.TabIndex = 0;
            this.txtbComImag1.Text = "2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(130, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "+";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(374, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "+";
            // 
            // txtbComImag2
            // 
            this.txtbComImag2.Location = new System.Drawing.Point(406, 104);
            this.txtbComImag2.Name = "txtbComImag2";
            this.txtbComImag2.Size = new System.Drawing.Size(58, 26);
            this.txtbComImag2.TabIndex = 1;
            this.txtbComImag2.Text = "3";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(231, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(12, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "i";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(470, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(12, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "i";
            // 
            // rdbSuma
            // 
            this.rdbSuma.AutoSize = true;
            this.rdbSuma.Location = new System.Drawing.Point(672, 55);
            this.rdbSuma.Name = "rdbSuma";
            this.rdbSuma.Size = new System.Drawing.Size(73, 24);
            this.rdbSuma.TabIndex = 4;
            this.rdbSuma.TabStop = true;
            this.rdbSuma.Text = "suma";
            this.rdbSuma.UseVisualStyleBackColor = true;
            this.rdbSuma.CheckedChanged += new System.EventHandler(this.rdbSuma_CheckedChanged);
            // 
            // rdbResta
            // 
            this.rdbResta.AutoSize = true;
            this.rdbResta.Location = new System.Drawing.Point(672, 103);
            this.rdbResta.Name = "rdbResta";
            this.rdbResta.Size = new System.Drawing.Size(70, 24);
            this.rdbResta.TabIndex = 4;
            this.rdbResta.TabStop = true;
            this.rdbResta.Text = "resta";
            this.rdbResta.UseVisualStyleBackColor = true;
            this.rdbResta.CheckedChanged += new System.EventHandler(this.rdbResta_CheckedChanged);
            // 
            // rdbMultiplicacion
            // 
            this.rdbMultiplicacion.AutoSize = true;
            this.rdbMultiplicacion.Location = new System.Drawing.Point(672, 154);
            this.rdbMultiplicacion.Name = "rdbMultiplicacion";
            this.rdbMultiplicacion.Size = new System.Drawing.Size(128, 24);
            this.rdbMultiplicacion.TabIndex = 4;
            this.rdbMultiplicacion.TabStop = true;
            this.rdbMultiplicacion.Text = "multiplicación";
            this.rdbMultiplicacion.UseVisualStyleBackColor = true;
            this.rdbMultiplicacion.CheckedChanged += new System.EventHandler(this.rdbMultiplicacion_CheckedChanged);
            // 
            // rdbConjugar
            // 
            this.rdbConjugar.AutoSize = true;
            this.rdbConjugar.Location = new System.Drawing.Point(672, 206);
            this.rdbConjugar.Name = "rdbConjugar";
            this.rdbConjugar.Size = new System.Drawing.Size(95, 24);
            this.rdbConjugar.TabIndex = 4;
            this.rdbConjugar.TabStop = true;
            this.rdbConjugar.Text = "conjugar";
            this.rdbConjugar.UseVisualStyleBackColor = true;
            this.rdbConjugar.CheckedChanged += new System.EventHandler(this.rdbConjugar_CheckedChanged);
            // 
            // btnRestar
            // 
            this.btnRestar.Location = new System.Drawing.Point(185, 185);
            this.btnRestar.Name = "btnRestar";
            this.btnRestar.Size = new System.Drawing.Size(75, 45);
            this.btnRestar.TabIndex = 3;
            this.btnRestar.Text = "Restar";
            this.btnRestar.UseVisualStyleBackColor = true;
            this.btnRestar.Click += new System.EventHandler(this.btnRestar_Click);
            // 
            // btnMultiplicar
            // 
            this.btnMultiplicar.Location = new System.Drawing.Point(310, 185);
            this.btnMultiplicar.Name = "btnMultiplicar";
            this.btnMultiplicar.Size = new System.Drawing.Size(103, 45);
            this.btnMultiplicar.TabIndex = 3;
            this.btnMultiplicar.Text = "Multiplicar";
            this.btnMultiplicar.UseVisualStyleBackColor = true;
            this.btnMultiplicar.Click += new System.EventHandler(this.btnSumar_Click);
            // 
            // btnConjugar
            // 
            this.btnConjugar.Location = new System.Drawing.Point(450, 185);
            this.btnConjugar.Name = "btnConjugar";
            this.btnConjugar.Size = new System.Drawing.Size(100, 45);
            this.btnConjugar.TabIndex = 3;
            this.btnConjugar.Text = "Conjugar";
            this.btnConjugar.UseVisualStyleBackColor = true;
            this.btnConjugar.Click += new System.EventHandler(this.btnSumar_Click);
            // 
            // lbConjugar
            // 
            this.lbConjugar.AutoSize = true;
            this.lbConjugar.Location = new System.Drawing.Point(531, 76);
            this.lbConjugar.Name = "lbConjugar";
            this.lbConjugar.Size = new System.Drawing.Size(73, 20);
            this.lbConjugar.TabIndex = 2;
            this.lbConjugar.Text = "Conjugar";
            this.lbConjugar.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 322);
            this.Controls.Add(this.rdbConjugar);
            this.Controls.Add(this.rdbMultiplicacion);
            this.Controls.Add(this.rdbResta);
            this.Controls.Add(this.rdbSuma);
            this.Controls.Add(this.btnConjugar);
            this.Controls.Add(this.btnMultiplicar);
            this.Controls.Add(this.btnRestar);
            this.Controls.Add(this.btnSumar);
            this.Controls.Add(this.lbResultadoSuma);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbConjugar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtbComImag2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbOperador);
            this.Controls.Add(this.txtbComReal2);
            this.Controls.Add(this.txtbComImag1);
            this.Controls.Add(this.txtbComReal1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbComReal1;
        private System.Windows.Forms.TextBox txtbComReal2;
        private System.Windows.Forms.Label lbOperador;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbResultadoSuma;
        private System.Windows.Forms.Button btnSumar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtbComImag1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtbComImag2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton rdbSuma;
        private System.Windows.Forms.RadioButton rdbResta;
        private System.Windows.Forms.RadioButton rdbMultiplicacion;
        private System.Windows.Forms.RadioButton rdbConjugar;
        private System.Windows.Forms.Button btnRestar;
        private System.Windows.Forms.Button btnMultiplicar;
        private System.Windows.Forms.Button btnConjugar;
        private System.Windows.Forms.Label lbConjugar;
    }
}

