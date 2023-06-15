namespace EncuestasForms {
    partial class MenuPrincipal {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent() {
            this.btnRegistroEncuesta = new System.Windows.Forms.Button();
            this.btnMostrarResultados = new System.Windows.Forms.Button();
            this.btnMostrarContactables = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRegistroEncuesta
            // 
            this.btnRegistroEncuesta.Location = new System.Drawing.Point(13, 13);
            this.btnRegistroEncuesta.Name = "btnRegistroEncuesta";
            this.btnRegistroEncuesta.Size = new System.Drawing.Size(179, 26);
            this.btnRegistroEncuesta.TabIndex = 0;
            this.btnRegistroEncuesta.Text = "Registrar encuesta";
            this.btnRegistroEncuesta.UseVisualStyleBackColor = true;
            this.btnRegistroEncuesta.Click += new System.EventHandler(this.btnRegistroEncuesta_Click);
            // 
            // btnMostrarResultados
            // 
            this.btnMostrarResultados.Location = new System.Drawing.Point(13, 43);
            this.btnMostrarResultados.Name = "btnMostrarResultados";
            this.btnMostrarResultados.Size = new System.Drawing.Size(179, 26);
            this.btnMostrarResultados.TabIndex = 1;
            this.btnMostrarResultados.Text = "Mostrar Resultados";
            this.btnMostrarResultados.UseVisualStyleBackColor = true;
            this.btnMostrarResultados.Click += new System.EventHandler(this.btnMostrarResultados_Click);
            // 
            // btnMostrarContactables
            // 
            this.btnMostrarContactables.Location = new System.Drawing.Point(13, 73);
            this.btnMostrarContactables.Name = "btnMostrarContactables";
            this.btnMostrarContactables.Size = new System.Drawing.Size(179, 26);
            this.btnMostrarContactables.TabIndex = 2;
            this.btnMostrarContactables.Text = "Mostrar Listado contactables";
            this.btnMostrarContactables.UseVisualStyleBackColor = true;
            this.btnMostrarContactables.Click += new System.EventHandler(this.btnMostrarContactos_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(204, 111);
            this.Controls.Add(this.btnMostrarContactables);
            this.Controls.Add(this.btnMostrarResultados);
            this.Controls.Add(this.btnRegistroEncuesta);
            this.Name = "MenuPrincipal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRegistroEncuesta;
        private System.Windows.Forms.Button btnMostrarResultados;
        private System.Windows.Forms.Button btnMostrarContactables;
    }
}

