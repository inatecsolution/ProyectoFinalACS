using System;
using System.Text;

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

            Compute(cadenaform, cadenaencriptform);
            //EncriptarDesencriptar(cadenaform, cadenaencriptform);
        }

        public int EncriptarDesencriptar(string cadena, string cadenaencript)
        {
            int x = 0;
            if (Rb_Encriptar.Checked)
            {
                if (string.IsNullOrEmpty(cadena))
                {
                    Response.Write("<script>alert('La cadena está vacia, verifique para continuar')</script>");
                    x = -1;
                }
                else
                {
                    Byte[] encriptar = Encoding.Unicode.GetBytes(cadena);
                    TxtSalida.Text = Convert.ToBase64String(encriptar);
                    TxtIngresar.Text = string.Empty;
                    TxtIngresar.Focus();
                    x = 1;
                }
            }
            else if (Rb_Desencriptar.Checked)
            {
                if (string.IsNullOrEmpty(cadenaencript))
                {
                    Response.Write("<script>alert('La cadena está vacia, verifique para continuar')</script>");
                    x = -1;
                }
                else
                {
                    Byte[] desencriptar = Convert.FromBase64String(cadenaencript);
                    TxtIngresar.Text = Encoding.Unicode.GetString(desencriptar);
                    TxtSalida.Text = string.Empty;
                    TxtIngresar.Focus();
                    x = 1;
                }
            }
            return x;     
        }


        public int Compute(string s, string t)
        {
            int n = s.Length;
            int m = t.Length;
            int[,] d = new int[n + 1, m + 1];

            if (n == 0)
            {
                return m;
            }

            if (m == 0)
            {
                return n;
            }

            for (int i = 0; i<= n; d[i,0] = i++)
            {

            }

            for (int j = 0; j <= m; d[0, j] = j++)
            {

            }

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j<= m; j++)
                {
                    int cost = (t[j - 1] == s[i - 1]) ? 0 : 1;

                    d[i, j] = Math.Min(
                        Math.Min(d[i - 1, j] + 1, d[i, j - 1] + 1),
                        d[i - 1, j - 1] + cost);
                }
            }
            string x = Convert.ToString(d[n, m]);
            if (!string.IsNullOrEmpty(x))
            {
                LblResultado.Text = "Faltan " + x + " caracteres para igualar la cadena 1";
            }
            return d[n, m];
            
        }        
    }
}