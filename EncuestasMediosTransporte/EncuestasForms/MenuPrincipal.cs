using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Encuestas;

namespace EncuestasForms {
    public partial class MenuPrincipal: Form {
        private readonly ProcesoEncuestas proceso = new ProcesoEncuestas();

        public MenuPrincipal() {
            InitializeComponent();
        }

        private void btnRegistroEncuesta_Click(object sender, EventArgs e) {
            Encuesta nuevo = new Encuesta();
            MenuEncuesta menuEncuesta = new MenuEncuesta();

            menuEncuesta.Show();

            if(menuEncuesta.DialogResult != DialogResult.OK)
                return;

            nuevo.UsaBicicleta = menuEncuesta.cbBicicleta.Checked;
            nuevo.UsaAuto = menuEncuesta.cbMovil.Checked;
            nuevo.UsaTransportePublico = menuEncuesta.cbTransportePublico.Checked;

            nuevo.DistanciaASuDestino = Convert.ToDouble(menuEncuesta.nudDistancia.Value);

            bool puedeSerContactado = menuEncuesta.cbEmail.Checked;
            if(puedeSerContactado == true)
                nuevo.Email = menuEncuesta.tbEmail.Text;

            proceso.RegistrarEncuesta(nuevo, puedeSerContactado);
        }

        private void btnMostrarResultados_Click(object sender, EventArgs e) {

        }

        private void btnMostrarContactos_Click(object sender, EventArgs e) {

        }

        private void Form1_Load(object sender, EventArgs e) {

        }
    }
}
