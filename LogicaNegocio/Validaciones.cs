using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Drawing;
using System.Windows.Forms;


namespace LogicaNegocio
{
    public class Validaciones
    {
        public bool SoloNumerosDecimales(KeyPressEventArgs e)
        {
            bool rechazado = false;
            
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != 8 && e.KeyChar != ',')
                rechazado = true;
            
            return rechazado;
        }

        public bool SoloMayusYNumeros(KeyPressEventArgs e)
        {
            bool rechazado = false;

            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != 8 && (e.KeyChar < 'A' || e.KeyChar > 'Z'))
                rechazado = true;

            return rechazado;
        }

        public bool esDecimal(string numero)
        {
            int puntos = 0;
            bool numDecimal = true;

            foreach (char letra in numero)
            {
                if (!(Char.IsNumber(letra)) && letra != ',')
                    numDecimal = false;
                else if(letra == ',')
                {
                    puntos++;
                    if (puntos > 1)
                        numDecimal = false;
                }
            }

            return numDecimal;
        }

        public bool CodigoValido(string codigo)
        {
            bool esValido = true;

            if (codigo.Length < 3)
                esValido = false;
            else if (Char.IsNumber(codigo[0]) || !(Char.IsNumber(codigo[1])) || !(Char.IsNumber(codigo[2])))
                esValido = false;

            return esValido;
        }

        public bool campoCompleto(TextBox campo, Label label)
        {
            bool campoCompleto = true;

            if (campo.Text == "")
            {
                label.Text = "Campo obligatorio";
                campoCompleto = false;
            }
            else
                label.Text = "";
                

            return campoCompleto;
        }

        public bool txtCompletos(TextBox[] campos,Label[] label)
        {
            bool campo = true;
            bool camposCompletos = true;

            for (int i = 0; i < campos.Length; i++)
            {
                if(i != 3)
                {
                    campo = campoCompleto(campos[i], label[i]);
                    if (!campo)
                        camposCompletos = campo;
                }
                    
            }

            return camposCompletos;
        }

    }
}
