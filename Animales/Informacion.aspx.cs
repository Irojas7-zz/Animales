using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Tico.Animales.BusAnimales;
using Tico.Animales.Business.EntAnimales;

public partial class Informacion : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int id = 2;// Request.QueryString["Id"] == null ? 0 : Convert.ToInt32(Request.QueryString["Id"]);
        if (!IsPostBack)
        {
            CargarCatalogos();
        }
        if (id != 0)
        {
            CargarDatos(id);
        }

    }

    private void CargarDatos(int Id)
    {
        EntAnimal ani = new BusAnimal().Obtener(Id);

        txtNomb.Text = ani.Nombre;
        txtExit.Text = Convert.ToString(ani.Existencia);
        txtPeso.Text = Convert.ToString(ani.Peso);
        txtFech.Text = Convert.ToString(ani.Fecha_Alta);
        //txtFech.Text = ani.Fecha_Alta.ToString("dd/MM/yyyy");
        txtEdad.Text = Convert.ToString(ani.Edad);
        txtUrl.Text = ani.Video;
        ddlTipo.SelectedValue = Convert.ToString(ani.Tipo_Id);
        ddlColor.SelectedValue = Convert.ToString(ani.Color_Id);
        ddlGenero.SelectedValue = Convert.ToString(ani.Genero_Id);
        imgPort.Src = Convert.ToString(ani.FotoPortada);
        imgMini.Src = Convert.ToString(ani.FotoMini);
        urlVideo.Src = ani.Video;
    }

    private void CargarCatalogos()
    {
        List<List<EntCatalogos>> list = new BusCatalogos().Obtener();

        ddlTipo.DataSource = list[0];
        ddlTipo.DataTextField = "Nombre";
        ddlTipo.DataValueField = "Id";
        ddlTipo.DataBind();

        ddlColor.DataSource = list[1];
        ddlColor.DataTextField = "Nombre";
        ddlColor.DataValueField = "Id";
        ddlColor.DataBind();

        ddlGenero.DataSource = list[2];
        ddlGenero.DataTextField = "Nombre";
        ddlGenero.DataValueField = "Id";
        ddlGenero.DataBind();
    }
}