using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Tico.Animales.BusAnimales;
using Tico.Animales.Business.EntAnimales;
using Tico.Animales.DatAnimales;

public partial class Informacion : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int id = Request.QueryString["Id"] == null ? 0 : Convert.ToInt32(Request.QueryString["Id"]);
        ViewState["Id"] = id;
        if (!IsPostBack)
        {
            CargarCatalogos();
            if (id != 0)
            {
                CargarDatos(id);
                btnNew.Visible = false;
            }
            else
            {
                btnDelete.Visible = false;
                btnUpdate.Visible = false;
                //txtFech.Enabled = false;
                txtFech.Text = DateTime.Today.ToString("dd/MM/yyyy hh:mm A"); 
            }
        }
              

        //ModificarDatos();
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

        ViewState["FotoPortada"] = imgPort.Src;
        ViewState["FotoMini"] = imgMini.Src;
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
    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        ModificarDatos(Convert.ToInt32(ViewState["Id"]));
    }
    protected void btnDelete_Click(object sender, EventArgs e)
    {
        EliminarDatos(Convert.ToInt32(ViewState["Id"]));
    }
    protected void btnNew_Click(object sender, EventArgs e)
    {
        InsertarDatos();
    }
    private void InsertarDatos()
    {
        string Nombre = txtNomb.Text.Trim();
        int Tipo_Id = Convert.ToInt32(ddlTipo.SelectedValue);
        int Color_Id = Convert.ToInt32(ddlColor.SelectedValue);
        int Genero_Id = Convert.ToInt32(ddlGenero.SelectedValue);
        int Existencias = Convert.ToInt32(txtExit.Text.Trim());
        int Edad = Convert.ToInt32(txtEdad.Text.Trim());
        decimal Peso = Convert.ToDecimal(txtPeso.Text.Trim());
        bool Estatus = Convert.ToBoolean(1);
        string FotoPortada = "img\\hipopotamo.jpg";
        string FotoMini = "img\\hipoMini.jpg";
        string Video = txtUrl.Text.Trim() == "" ? "https ://www.youtube.com/embed/xPndNFuqEWY" : txtUrl.Text.Trim();

        new DatAnimal().Insertar(Nombre,Tipo_Id,Color_Id,Genero_Id,Existencias,Edad,Peso,Estatus,FotoPortada,FotoMini,Video);
    }
    private void ModificarDatos(int Id)
    {
        string Nombre = txtNomb.Text.Trim();
        int Tipo_Id = Convert.ToInt32(ddlTipo.SelectedValue);
        int Color_Id = Convert.ToInt32(ddlColor.SelectedValue);
        int Genero_Id = Convert.ToInt32(ddlGenero.SelectedValue);
        int Existencias = Convert.ToInt32(txtExit.Text.Trim());
        int Edad = Convert.ToInt32(txtEdad.Text.Trim());
        decimal Peso = Convert.ToDecimal(txtPeso.Text.Trim());
        bool Estatus = Convert.ToBoolean(1);
        string FotoPortada = ViewState["FotoPortada"].ToString();
        string FotoMini = ViewState["FotoMini"].ToString();
        string Video = txtUrl.Text.Trim();

        new DatAnimal().Actualizar(Id, Nombre, Tipo_Id, Color_Id, Genero_Id, Existencias, Edad, Peso, Estatus, FotoPortada, FotoMini, Video);
    }
    private void EliminarDatos(int Id)
    {
        new DatAnimal().Eliminar(Id);
    }
}