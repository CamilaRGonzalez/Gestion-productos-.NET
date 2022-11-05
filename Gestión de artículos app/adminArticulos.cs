using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using LogicaNegocio;

namespace Gestión_de_artículos_app
{
    public partial class adminArticulos : Form
    {
        FuncionesFront funcion;
        ArticuloDB baseDatos;
        Articulo art;

        public adminArticulos()
        {
            InitializeComponent();
            funcion = new FuncionesFront();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarArticulo agregarVentana = new AgregarArticulo();
            agregarVentana.ShowDialog();
            funcion.cargarArticulos(dgvArticulos);

        }

        private void adminArticulos_Load(object sender, EventArgs e)
        {
            try
            {
                funcion.cargarArticulos(dgvArticulos);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            baseDatos = new ArticuloDB();

            try
            {
                DialogResult respuesta = MessageBox.Show("¿Desea eliminar el artículo de la base de datos?", "Eliminar", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.OK)
                {
                    art = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;

                    baseDatos.EliminarArticulo(art);
                    funcion.cargarArticulos(dgvArticulos);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            art = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;

            AgregarArticulo agregarVentana = new AgregarArticulo(art);
            agregarVentana.ShowDialog();
            funcion.cargarArticulos(dgvArticulos);
        }
    }
}
