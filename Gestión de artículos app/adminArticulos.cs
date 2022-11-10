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

        public Articulo Art() //getter
        {
            return art; 
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

            cbCampo.Items.Add("Código");
            cbCampo.Items.Add("Nombre");
            cbCampo.Items.Add("Precio");
            cbCampo.Items.Add("Marca");
            cbCampo.Items.Add("Categoría");
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

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            Articulo seleccion = new Articulo();
            if(dgvArticulos.CurrentRow != null)
            {
                seleccion = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                funcion.CargarImagen(seleccion.UrlImg, pbxImagen);
            }
        }

        private void btnDetalle_Click(object sender, EventArgs e)
        {
            art = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            
            Ver_detalle detalle = new Ver_detalle(art);
            detalle.ShowDialog();
           
                 
        }

        private void cbCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string elegido = cbCampo.SelectedItem.ToString();
            CaracteristicaDB datos = new CaracteristicaDB();
            string[] criterios;

            if (elegido == "Marca" || elegido == "Categoría")
            {
                cbCriterio.Enabled = true;
                txtFiltro.Enabled = false;
                warning.Text = "";
                txtFiltro.Text = "";
                try
                {
                    if (elegido == "Marca")
                        cbCriterio.DataSource = datos.ListarMarcas();
                    else
                        cbCriterio.DataSource = datos.ListarCategorias();

                    cbCriterio.ValueMember = "Id";
                    cbCriterio.DisplayMember = "Descripcion";

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else if(elegido == "Precio")
            {
                criterios = new string[] { "Mayor a", "Menor a", "Igual a" };
                txtFiltro.Enabled = true;
                cbCriterio.Enabled = true;
                cbCriterio.DataSource = criterios;
                warning.Text = "";
                txtFiltro.Text = "";
            }
            else 
            {
                txtFiltro.Text = "";
                cbCriterio.DataSource = null;
                cbCriterio.Enabled = false;
                txtFiltro.Enabled = true;
                warning.Text = "";
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string elegido = cbCampo.SelectedItem.ToString();
            baseDatos = new ArticuloDB();
            List<Articulo> lista;
            Validaciones validacion = new Validaciones();
            char operador;

            try
            {
                switch (elegido)
                {
                    case "Código":
                        if (txtFiltro.Text != "")
                        {
                            warning.Text = "";
                            lista = baseDatos.FiltrarFrase(txtFiltro.Text, "A.Codigo");
                            funcion.cargarArticulosFiltrados(dgvArticulos, lista);
                        }
                        else
                        {
                            warning.Text = "*Campo obligatorio";
                        }
                        break;
                    case "Nombre":
                        if (txtFiltro.Text != "")
                        {
                            warning.Text = "";
                            lista = baseDatos.FiltrarFrase(txtFiltro.Text, "A.Nombre");
                            funcion.cargarArticulosFiltrados(dgvArticulos, lista);
                        }
                        else
                        {
                            warning.Text = "*Campo obligatorio";
                        }
                        break;
                    case "Precio":
                        if (txtFiltro.Text != "")
                        {
                            warning.Text = "";
                            if (!validacion.esDecimal(txtFiltro.Text))
                                warning.Text = "*Campo numérico";
                            else
                            {
                                if (cbCriterio.SelectedItem.ToString() == "Mayor a")
                                    operador = '>';
                                else if (cbCriterio.SelectedItem.ToString() == "Menor a")
                                    operador = '<';
                                else
                                    operador = '=';

                                lista = baseDatos.FiltrarPrecio(operador, txtFiltro.Text);
                                funcion.cargarArticulosFiltrados(dgvArticulos, lista);
                            }

                        }
                        else
                        {
                            warning.Text = "*Campo obligatorio";
                        }
                        break;
                    case "Marca":
                        lista = baseDatos.FiltrarFrase(cbCriterio.SelectedItem.ToString(), "M.Descripcion");
                        funcion.cargarArticulosFiltrados(dgvArticulos, lista);
                        break;
                    case "Categoría":
                        lista = baseDatos.FiltrarFrase(cbCriterio.SelectedItem.ToString(), "C.Descripcion");
                        funcion.cargarArticulosFiltrados(dgvArticulos, lista);
                        break;

                    default:
                        break;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
