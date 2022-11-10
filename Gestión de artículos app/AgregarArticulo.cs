using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicaNegocio;
using Dominio;

namespace Gestión_de_artículos_app
{
    public partial class AgregarArticulo : Form
    {
        private Validaciones validacion;
        private FuncionesFront funcion;
        private ArticuloDB baseDatos;
        private Articulo articulo = null;
        private TextBox[] campos;
        private Label[] label;
        private ComboBox[] combx;

        public AgregarArticulo()
        {
            InitializeComponent();
            validacion = new Validaciones();
            funcion = new FuncionesFront();
            campos = new TextBox[] { txtCodigo, txtNombre, txtPrecio, txtUrlImg, txtDescripcion };
            label = new Label[] { warningCodigo, warningNombre, warningPrecio,warningImagen,warningDesc };
            combx = new ComboBox[] { cbMarca, cbCategoria };
        }

        public AgregarArticulo(Articulo articulo)
        {
            InitializeComponent();
            validacion = new Validaciones();
            funcion = new FuncionesFront();
            this.articulo = articulo;
            Text = "Modificar artículo";

            campos = new TextBox[] { txtCodigo, txtNombre, txtPrecio, txtUrlImg, txtDescripcion };
            label = new Label[] { warningCodigo, warningNombre, warningPrecio, warningImagen, warningDesc };
            combx = new ComboBox[] { cbMarca, cbCategoria };
        }

        private void AgregarArticulo_Load(object sender, EventArgs e)
        {
            CaracteristicaDB baseDatos = new CaracteristicaDB();

            try
            {
                cbMarca.DataSource = baseDatos.ListarMarcas();
                cbMarca.ValueMember = "Id";
                cbMarca.DisplayMember = "Descripcion";

                cbCategoria.DataSource = baseDatos.ListarCategorias();
                cbCategoria.ValueMember = "Id";
                cbCategoria.DisplayMember = "Descripcion";

                if(articulo != null)
                {
                    funcion.llenarCampos(articulo, campos, combx);
                    funcion.CargarImagen(txtUrlImg.Text, pbxImagen);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = validacion.SoloNumerosDecimales(e);
        }

        private void brnAgregar_Click(object sender, EventArgs e)
        {
            bool camposOK = true;

            camposOK = validacion.txtCompletos(campos, label);

            if (txtCodigo.Text != "" && !(validacion.CodigoValido(txtCodigo.Text)))
            {
                warningCodigo.Text = "El código debe tener \r\n 1 letra y 2 números";
                camposOK = false;
            } 

            if (txtPrecio.Text != "" && !(validacion.esDecimal(txtPrecio.Text)))
            {
                warningPrecio.Text = "Formato incorrecto";
                camposOK = false;
            }

            if (camposOK)
            {
                baseDatos = new ArticuloDB();
                try
                {
                    if(articulo == null)
                    {
                        articulo = new Articulo();
                        funcion.TomarDatos(articulo, campos, combx);

                        DialogResult respuesta = MessageBox.Show("¿Desea agregar éste artículo a la base de datos?", "Agregar", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                        if (respuesta == DialogResult.OK)
                        {
                            baseDatos.AgregarArticulo(articulo);
                            MessageBox.Show("Artículo agregado con éxito");
                            funcion.limpiarCampos(campos);
                        }
                    }
                    else
                    {
                        funcion.TomarDatos(articulo, campos, combx);

                        DialogResult respuesta = MessageBox.Show("¿Desea modificar éste artículo?", "Modificar", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                        if (respuesta == DialogResult.OK)
                        {
                            baseDatos.ModificarArticulo(articulo);
                            MessageBox.Show("Artículo Modificado con éxito");
                            funcion.limpiarCampos(campos);
                        }
                    }    
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = validacion.SoloMayusYNumeros(e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUrlImg_Leave(object sender, EventArgs e)
        {
            if (articulo == null)
                funcion.CargarImagen(txtUrlImg.Text, pbxImagen);
        }
    }
}
