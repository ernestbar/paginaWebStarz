using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PaginaWebTravel
{
    public partial class Principal : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                DataTable dt = new DataTable();
                dt.Clear();
                dt.Columns.Add("DESCRIPCION");
                dt.Columns.Add("DETALLE");
                foreach (DataRow dr in Clases.Encabezados.GET_PAG_ENCABEZADO("A").Rows)
                {
                    if (dr["DESC_TIPO"].ToString() == "SECCION")
                    {
                        DataRow dr1 = dt.NewRow();
                        dr1["DESCRIPCION"] = dr["DESCRIPCION"];
                        dr1["DETALLE"] = dr["DESCRIPCION"].ToString()+".ASPX";
                        dt.Rows.Add(dr1);
                    }
                    

                }
                Repeater1.DataSource = dt;
                Repeater1.DataBind();

            }
        }
    }
}