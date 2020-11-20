using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebWCF_eSports.Torneo
{
    public partial class WebTorneoFecha : System.Web.UI.Page
    {
        ProxyTorneo.ServicioTorneoClient objTorneo = new ProxyTorneo.ServicioTorneoClient();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime fi, ff;
                fi = Convert.ToDateTime(txtFecIni.Text);
                ff = Convert.ToDateTime(txtFecFin.Text);

                grvDatos.DataSource = objTorneo.FechaTorneo(fi, ff);
                grvDatos.DataBind();

                lblMensaje.Text = "Torneos Realizados Entre esas Fechas: " + grvDatos.Rows.Count.ToString();


            }
            catch (Exception ex)
            {
                lblMensaje.Text = ex.Message;
            }
        }
    }
}