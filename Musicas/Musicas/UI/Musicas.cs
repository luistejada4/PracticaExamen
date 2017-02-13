using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Musicas
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void nuevoRegistroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new UI.Registros.RegistrarMusica().Show();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new UI.Consultas.ConsultarMusica().Show();
        }
    }
}
