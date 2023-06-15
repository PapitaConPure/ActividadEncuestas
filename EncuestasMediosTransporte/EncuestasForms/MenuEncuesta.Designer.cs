namespace EncuestasForms {
    partial class MenuEncuesta {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.gbTransporte = new System.Windows.Forms.GroupBox();
            this.cbTransportePublico = new System.Windows.Forms.CheckBox();
            this.cbMovil = new System.Windows.Forms.CheckBox();
            this.cbBicicleta = new System.Windows.Forms.CheckBox();
            this.gbDestino = new System.Windows.Forms.GroupBox();
            this.lbDistancia = new System.Windows.Forms.Label();
            this.gbContacto = new System.Windows.Forms.GroupBox();
            this.cbEmail = new System.Windows.Forms.CheckBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.btnConcluirEncuesta = new System.Windows.Forms.Button();
            this.btnCancelarEncuesta = new System.Windows.Forms.Button();
            this.nudDistancia = new System.Windows.Forms.NumericUpDown();
            this.gbTransporte.SuspendLayout();
            this.gbDestino.SuspendLayout();
            this.gbContacto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDistancia)).BeginInit();
            this.SuspendLayout();
            // 
            // gbTransporte
            // 
            this.gbTransporte.Controls.Add(this.cbTransportePublico);
            this.gbTransporte.Controls.Add(this.cbMovil);
            this.gbTransporte.Controls.Add(this.cbBicicleta);
            this.gbTransporte.Location = new System.Drawing.Point(13, 13);
            this.gbTransporte.Name = "gbTransporte";
            this.gbTransporte.Size = new System.Drawing.Size(200, 101);
            this.gbTransporte.TabIndex = 0;
            this.gbTransporte.TabStop = false;
            this.gbTransporte.Text = "Modo de transporte habitual";
            // 
            // cbTransportePublico
            // 
            this.cbTransportePublico.AutoSize = true;
            this.cbTransportePublico.Location = new System.Drawing.Point(7, 68);
            this.cbTransportePublico.Name = "cbTransportePublico";
            this.cbTransportePublico.Size = new System.Drawing.Size(115, 17);
            this.cbTransportePublico.TabIndex = 2;
            this.cbTransportePublico.Text = "Transporte Público";
            this.cbTransportePublico.UseVisualStyleBackColor = true;
            // 
            // cbMovil
            // 
            this.cbMovil.AutoSize = true;
            this.cbMovil.Location = new System.Drawing.Point(7, 44);
            this.cbMovil.Name = "cbMovil";
            this.cbMovil.Size = new System.Drawing.Size(72, 17);
            this.cbMovil.TabIndex = 1;
            this.cbMovil.Text = "Automóvil";
            this.cbMovil.UseVisualStyleBackColor = true;
            // 
            // cbBicicleta
            // 
            this.cbBicicleta.AutoSize = true;
            this.cbBicicleta.Location = new System.Drawing.Point(7, 20);
            this.cbBicicleta.Name = "cbBicicleta";
            this.cbBicicleta.Size = new System.Drawing.Size(66, 17);
            this.cbBicicleta.TabIndex = 0;
            this.cbBicicleta.Text = "Bicicleta";
            this.cbBicicleta.UseVisualStyleBackColor = true;
            // 
            // gbDestino
            // 
            this.gbDestino.Controls.Add(this.nudDistancia);
            this.gbDestino.Controls.Add(this.lbDistancia);
            this.gbDestino.Location = new System.Drawing.Point(13, 120);
            this.gbDestino.Name = "gbDestino";
            this.gbDestino.Size = new System.Drawing.Size(200, 56);
            this.gbDestino.TabIndex = 1;
            this.gbDestino.TabStop = false;
            this.gbDestino.Text = "Sobre el destino al trabajo/estudio";
            // 
            // lbDistancia
            // 
            this.lbDistancia.AutoSize = true;
            this.lbDistancia.Location = new System.Drawing.Point(6, 21);
            this.lbDistancia.Name = "lbDistancia";
            this.lbDistancia.Size = new System.Drawing.Size(74, 13);
            this.lbDistancia.TabIndex = 1;
            this.lbDistancia.Text = "Distancia (km)";
            // 
            // gbContacto
            // 
            this.gbContacto.Controls.Add(this.cbEmail);
            this.gbContacto.Controls.Add(this.lbEmail);
            this.gbContacto.Controls.Add(this.tbEmail);
            this.gbContacto.Location = new System.Drawing.Point(13, 182);
            this.gbContacto.Name = "gbContacto";
            this.gbContacto.Size = new System.Drawing.Size(200, 77);
            this.gbContacto.TabIndex = 2;
            this.gbContacto.TabStop = false;
            this.gbContacto.Text = "Contacto";
            // 
            // cbEmail
            // 
            this.cbEmail.AutoSize = true;
            this.cbEmail.Location = new System.Drawing.Point(7, 19);
            this.cbEmail.Name = "cbEmail";
            this.cbEmail.Size = new System.Drawing.Size(96, 17);
            this.cbEmail.TabIndex = 3;
            this.cbEmail.Text = "Registrar Email";
            this.cbEmail.UseVisualStyleBackColor = true;
            this.cbEmail.CheckedChanged += new System.EventHandler(this.cbEmail_CheckedChanged);
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Enabled = false;
            this.lbEmail.Location = new System.Drawing.Point(6, 45);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(32, 13);
            this.lbEmail.TabIndex = 3;
            this.lbEmail.Text = "Email";
            // 
            // tbEmail
            // 
            this.tbEmail.Enabled = false;
            this.tbEmail.Location = new System.Drawing.Point(44, 42);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(150, 20);
            this.tbEmail.TabIndex = 2;
            // 
            // btnConcluirEncuesta
            // 
            this.btnConcluirEncuesta.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnConcluirEncuesta.Location = new System.Drawing.Point(13, 266);
            this.btnConcluirEncuesta.Name = "btnConcluirEncuesta";
            this.btnConcluirEncuesta.Size = new System.Drawing.Size(97, 49);
            this.btnConcluirEncuesta.TabIndex = 3;
            this.btnConcluirEncuesta.Text = "Aceptar";
            this.btnConcluirEncuesta.UseVisualStyleBackColor = true;
            this.btnConcluirEncuesta.Click += new System.EventHandler(this.btnConcluirEncuesta_Click);
            // 
            // btnCancelarEncuesta
            // 
            this.btnCancelarEncuesta.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnCancelarEncuesta.Location = new System.Drawing.Point(117, 266);
            this.btnCancelarEncuesta.Name = "btnCancelarEncuesta";
            this.btnCancelarEncuesta.Size = new System.Drawing.Size(96, 49);
            this.btnCancelarEncuesta.TabIndex = 4;
            this.btnCancelarEncuesta.Text = "Cancelar";
            this.btnCancelarEncuesta.UseVisualStyleBackColor = true;
            this.btnCancelarEncuesta.Click += new System.EventHandler(this.btnCancelarEncuesta_Click);
            // 
            // nudDistancia
            // 
            this.nudDistancia.Location = new System.Drawing.Point(86, 19);
            this.nudDistancia.Name = "nudDistancia";
            this.nudDistancia.Size = new System.Drawing.Size(108, 20);
            this.nudDistancia.TabIndex = 2;
            // 
            // MenuEncuesta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 327);
            this.Controls.Add(this.btnCancelarEncuesta);
            this.Controls.Add(this.btnConcluirEncuesta);
            this.Controls.Add(this.gbContacto);
            this.Controls.Add(this.gbDestino);
            this.Controls.Add(this.gbTransporte);
            this.Name = "MenuEncuesta";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.MenuEncuesta_Load);
            this.gbTransporte.ResumeLayout(false);
            this.gbTransporte.PerformLayout();
            this.gbDestino.ResumeLayout(false);
            this.gbDestino.PerformLayout();
            this.gbContacto.ResumeLayout(false);
            this.gbContacto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDistancia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbTransporte;
        private System.Windows.Forms.GroupBox gbDestino;
        private System.Windows.Forms.GroupBox gbContacto;
        private System.Windows.Forms.Label lbDistancia;
        public System.Windows.Forms.CheckBox cbTransportePublico;
        public System.Windows.Forms.CheckBox cbMovil;
        public System.Windows.Forms.CheckBox cbBicicleta;
        public System.Windows.Forms.CheckBox cbEmail;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Button btnConcluirEncuesta;
        public System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Button btnCancelarEncuesta;
        public System.Windows.Forms.NumericUpDown nudDistancia;
    }
}