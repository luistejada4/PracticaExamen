using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ultimo.Entidades;

namespace Ultimo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Personas p = new Personas();
            p.PersonaId = 0;
            p.Nombre = textBox2.Text;
            PersonaBLL.Guardar(p);
            dataGridView1.DataSource = PersonaBLL.GetList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Personas p = PersonaBLL.Buscar(int.Parse(textBox1.Text));
            textBox1.Text = p.PersonaId.ToString();
            textBox2.Text = p.Nombre;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PersonaBLL.Eliminar(PersonaBLL.Buscar(int.Parse(textBox1.Text)));
            dataGridView1.DataSource = PersonaBLL.GetList();
        }
    }
}
