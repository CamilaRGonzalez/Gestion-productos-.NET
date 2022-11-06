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
    public partial class Ver_detalle : Form
    {
        Label[] labels;
        FuncionesFront funcion = new FuncionesFront();
        Articulo art;
        
        public Ver_detalle(Articulo art)
        {
            InitializeComponent();
            labels = new Label[] {infoCod, infoNomb, InfoPrec, InfoURL, infoMarca, InfoCateg,infoDesc};
            this.art = art;
        }

        private void Ver_detalle_Load(object sender, EventArgs e)
        {
            adminArticulos grilla = new adminArticulos();

            funcion.llenarLabels(art, labels);
            funcion.CargarImagen(art.UrlImg, pbxImagDetalle);
        }
    }
}
