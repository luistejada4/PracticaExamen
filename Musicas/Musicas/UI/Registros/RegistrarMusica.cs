using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Musicas.UI.Registros
{
    public partial class RegistrarMusica : Form
    {
        public RegistrarMusica()
        {
            InitializeComponent();
        }
        private void Limpiar()
        {
            textBoxID.Clear();
            textBoxArtista.Clear();
            textBoxNombre.Clear();
        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if(Utils.Utils.NoWhiteNoEmpty(textBoxID.Text))
            {
                if (BLL.MusicaBLL.Eliminar(int.Parse(textBoxID.Text)))
                {
                    Limpiar();
                    MessageBox.Show("Musica eliminada!");
                }
                else
                {
                    MessageBox.Show("Musica no existe!");
                }          
            }
            else
            {
                errorProvider.SetError(textBoxID, "ID vacio o con espacio");
            }
            
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if (!Utils.Utils.NoWhiteNoEmpty(textBoxArtista.Text) && !Utils.Utils.NoWhiteNoEmpty(textBoxArtista.Text))
            {
                errorProvider.SetError(textBoxNombre, "Nombre esta vacio");
                errorProvider.SetError(textBoxArtista, "Artista esta vacio");
            }
            else
            {
                if (Utils.Utils.NoWhiteNoEmpty(textBoxArtista.Text))
                {
                    if (Utils.Utils.NoWhiteNoEmpty(textBoxNombre.Text))
                    {
                        int id = BLL.MusicaBLL.Guardar(new Entidades.Musicas(string.IsNullOrEmpty(textBoxID.Text) == true ? 0 : int.Parse(textBoxID.Text), textBoxArtista.Text, textBoxNombre.Text, DateTime.Now.Date));
                        textBoxID.Text = id.ToString();
                    }
                    else
                    {
                        errorProvider.SetError(textBoxNombre, "Nombre esta vacio");
                    }
                }
                else
                {
                    errorProvider.SetError(textBoxArtista, "Artista esta vacio");
                }
            }
        }
    }
}
