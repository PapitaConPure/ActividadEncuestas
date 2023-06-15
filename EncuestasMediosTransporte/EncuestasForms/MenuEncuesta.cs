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
    public partial class MenuEncuesta: Form {
        public MenuEncuesta() {
            InitializeComponent();
        }

        private void MenuEncuesta_Load(object sender, EventArgs e) {

        }

        private void btnConcluirEncuesta_Click(object sender, EventArgs e) {
            Close();
        }

        private void btnCancelarEncuesta_Click(object sender, EventArgs e) {
            Close();
        }

        private void cbEmail_CheckedChanged(object sender, EventArgs e) {
            lbEmail.Enabled = cbEmail.Checked;
            tbEmail.Enabled = cbEmail.Checked;
        }
    }
}
