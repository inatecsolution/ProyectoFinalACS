using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PFAseguramientoCS
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Desencriptar_Click(object sender, EventArgs e)
        {
            string cadenaform = TxtIngresar.Text;
            string cadenaencriptform = TxtSalida.Text;

            EncriptarDesencriptar(cadenaform, cadenaencriptform);
        }

        public void EncriptarDesencriptar(string cadena, string cadenaencript)
        {
            
            if (Rb_Encriptar.Checked)
            {
                if (string.IsNullOrEmpty(cadena))
                {
                    Response.Write("<script>alert('La cadena está vacia, verifique para continuar')</script>");
                }
                else
                {
                    Byte[] encriptar = Encoding.Unicode.GetBytes(cadena);
                    TxtSalida.Text = Convert.ToBase64String(encriptar);
                    TxtIngresar.Text = string.Empty;
                    TxtIngresar.Focus();
                }
            }
            else if (Rb_Desencriptar.Checked)
            {
                if (string.IsNullOrEmpty(cadenaencript))
                {
                    Response.Write("<script>alert('La cadena está vacia, verifique para continuar')</script>");
                }
                else
                {
                    Byte[] desencriptar = Convert.FromBase64String(cadenaencript);
                    TxtIngresar.Text = Encoding.Unicode.GetString(desencriptar);
                    TxtSalida.Text = string.Empty;
                    TxtIngresar.Focus();
                }
            }
        }
    }
}