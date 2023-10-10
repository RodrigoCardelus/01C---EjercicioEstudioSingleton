using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

using EntidadesCompartidas;
using Logica;

public partial class AltaArticulo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }


    protected void btnAgregar_Click(object sender, EventArgs e)
    {
        int Codigo;
        decimal Precio;
        string Nombre;
        Articulo A;

        try
        {
            Codigo = Convert.ToInt32(txtCodigo.Text);
            Precio = Convert.ToDecimal(txtPrecio.Text);
            Nombre = txtNombre.Text;
            A = new Articulo(Codigo, Nombre, Precio);
            FabricaLogica.getLogicaArticulo().AgregarArticulo(A);
            lblError.Text = "Alta con Exito";
            txtCodigo.Text = "";
            txtPrecio.Text = "";
            txtNombre.Text = "";

        }
        catch (Exception ex)
        {
            lblError.Text = ex.Message;

        }
   
    }
}