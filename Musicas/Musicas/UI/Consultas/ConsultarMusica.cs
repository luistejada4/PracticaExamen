using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Musicas.UI.Consultas
{
    public partial class ConsultarMusica : Form
    {
        public ConsultarMusica()
        {
            InitializeComponent();
        }

        private void ConsultarMusica_Load(object sender, EventArgs e)
        {
            dateTimePickerDesde.Visible = false;
            dateTimePickerHasta.Visible = false;
            labelDesde.Visible = false;
            labelHasta.Visible = false;
            comboBoxFilter.SelectedIndex = 0;
        }

        private void comboBoxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxFilter.SelectedIndex == 3)
            {
                dateTimePickerDesde.Visible = true;
                dateTimePickerHasta.Visible = true;
                labelDesde.Visible = true;
                labelHasta.Visible = true;
                textBoxSearch.Visible = false;
            }
            else
            {
                dateTimePickerDesde.Visible = false;
                dateTimePickerHasta.Visible = false;
                labelDesde.Visible = false;
                labelHasta.Visible = false;
                textBoxSearch.Visible = true;
            }
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            switch(comboBoxFilter.SelectedIndex)
            {
                case 0:
                    {
                        if (Utils.Utils.NoWhiteNoEmpty(textBoxSearch.Text))
                        {

                            Entidades.Musicas m = BLL.MusicaBLL.Buscar(int.Parse(textBoxSearch.Text));
                            if (m != null)
                            {
                                List<Entidades.Musicas> lista = new List<Entidades.Musicas>();
                                lista.Add(m);
                                dataGridViewMusicas.DataSource = lista;
                            }
                            else
                            {
                                MessageBox.Show("No se encontraron resultados!");
                            }
                        }
                        else
                        {
                            errorProviderConsulta.SetError(textBoxSearch, "Id invalido");
                        }
                        break;
                    }
                case 1:
                    {
                        if (Utils.Utils.NoWhiteNoEmpty(textBoxSearch.Text))
                        {
                            dataGridViewMusicas.DataSource = BLL.MusicaBLL.GetListArtista(textBoxSearch.Text);
                        }
                        else
                        {
                            errorProviderConsulta.SetError(textBoxSearch, "Vacio");
                        }
                            break;
                    }
                case 2:
                    {
                        if (Utils.Utils.NoWhiteNoEmpty(textBoxSearch.Text))
                        {
                            dataGridViewMusicas.DataSource = BLL.MusicaBLL.GetListNombre(textBoxSearch.Text);
                        }
                        else
                        {
                            errorProviderConsulta.SetError(textBoxSearch, "Vacio");
                        }
                        break;
                    }
                case 3:
                    {
                        dataGridViewMusicas.DataSource = BLL.MusicaBLL.GetListFecha(dateTimePickerDesde.Value.Date, dateTimePickerHasta.Value.Date);    
                        break;
                    }
                default:
                    {
                        break;
                    }
                    
            }
        }
    }
}
