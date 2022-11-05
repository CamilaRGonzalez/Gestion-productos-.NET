using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Articulo
    {
        public Articulo() //Al instanciar articulo se instancian los objetos marca y categoria para que no tire excepcion por null
        {
            this.Marca = new Caracteristica();
            this.Categoria = new Caracteristica();
            Codigo = "";  //inicio los strings como vacio ya que al estar inicialmente en null se rompe el programa si le quiero asignar null a los parametros de la consulta db
            Nombre = "";
            Descripcion = "";
            UrlImg = "";
        }
        public int Id { get; set; }

        [DisplayName("Código")]
        public string Codigo { get; set; }
        public string Nombre { get; set; }

        [DisplayName("Descripción")]
        public string Descripcion { get; set; }
        public string UrlImg { get; set; }
        public decimal Precio { get; set; }

        public Caracteristica Marca { get; set; }

        [DisplayName("Categoría")]
        public Caracteristica Categoria { get; set; }
    }
}
