using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;

namespace LogicaNegocio
{
    public class FuncionesFront
    {
        public void TomarDatos(Articulo art, TextBox[] textBoxes,ComboBox[] combx) //toma el texto de los textboxes de un array y se los asigna a los atributos de un objeto Articulo
        {
            art.Codigo = textBoxes[0].Text;
            art.Nombre = textBoxes[1].Text;
            art.Precio = decimal.Parse(textBoxes[2].Text);
            art.UrlImg = textBoxes[3].Text;
            art.Descripcion = textBoxes[4].Text;
            art.Marca = (Caracteristica)combx[0].SelectedItem;
            art.Categoria = (Caracteristica)combx[1].SelectedItem;
        }

        public void limpiarCampos(TextBox[] campos)
        {
            foreach (TextBox campo in campos)
            {
                campo.Text = "";
            }
        }

        public void llenarCampos(Articulo art,TextBox[] campos, ComboBox[] combx)
        {
            campos[0].Text = art.Codigo;
            campos[1].Text = art.Nombre;
            campos[2].Text = art.Precio.ToString();
            campos[3].Text = art.UrlImg;
            campos[4].Text = art.Descripcion;
            combx[0].SelectedValue = art.Marca.Id;
            combx[1].SelectedValue = art.Categoria.Id;
        }

        public void cargarArticulos(DataGridView grilla)
        {
            List<Articulo> listaArt = new List<Articulo>();
            ArticuloDB baseDatos = new ArticuloDB();

            listaArt = baseDatos.ListarArticulos();
            grilla.DataSource = listaArt;
            grilla.Columns["UrlImg"].Visible = false;
            grilla.Columns["Id"].Visible = false;

        }
    }
}
