using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaDatos;

namespace Lab7_8
{
    public partial class WebPaises : System.Web.UI.Page
    {
        private GestionBD objBD;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                cargarGrid();
            }

        }
        void cargarCmbPais()
        {
            objBD = new GestionBD();
            listadoRetornar = objBD.listadoPais();

            cmbcodPais.DataSource = listadoPais;
            cmbcodPais.DataTextField = "CodigoPais";
            cmbcodPais.DataValueField = "DescripcionPais";
            cmbcodPais.DataBind();

         

        }
        void cargarCmbIdioma()
        {
            objBD = new GestionBD();
            listadoRetornar = objBD.listadoIdioma();

            cmbcodPais.DataSource = listadoIdioma;
            cmbcodPais.DataTextField = "CodigoIdioma";
            cmbcodPais.DataValueField = "DescripcionIdioma";
            cmbcodPais.DataBind();



        }
        public void cargarGrid()
        {
            using (ModeloPaises contextoBD = new ModeloPaises())
            {
                gridPais.DataSource = contextoBD.Pais.ToList(); //Ahorrando un alto % de tiempo
                gridPais.DataBind();
            }
            using (ModeloPaises contextoBD = new ModeloPaises())
            {
                gridPais.DataSource = contextoBD.Idioma.ToList(); //Ahorrando un alto % de tiempo
                gridPais.DataBind();
            }
            using (ModeloPaises contextoBD = new ModeloPaises())
            {
                gridPais.DataSource = contextoBD.GestionP.ToList(); //Ahorrando un alto % de tiempo
                gridPais.DataBind();
            }
        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            using (ModeloPaises contextoBD = new ModeloPaises())
            {
                Pais objPersona = new Pais();
                objPersona.DescripcionPais = "666666666";

                contextoBD.Pais.Add(objPersona);
                contextoBD.SaveChanges(); //Commit
                                          //ScriptManager.RegisterStartupScript(this, this.GetType(), "s1", "alert('Registro existoso')", true);
                cargarGrid();
            }

        }



        protected void btnActualiza_Click(object sender, EventArgs e)
        {
            using (ModeloPaises contextoBD = new ModeloPaises())
            {

                Pais aux = contextoBD.Pais.Where(x => x.DescripcionPais == "111111111").FirstOrDefault();
                if (aux == null)
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "s1", "alert('El registro no se encontro')", true);
                    return;
                }

                aux.DescripcionPais = "Linda";
                contextoBD.SaveChanges();
                //ScriptManager.RegisterStartupScript(this, this.GetType(), "s1", "alert('Se logro actualizar el registro')", true);
                cargarGrid();

            }
        }



        protected void btnElimina_Click(object sender, EventArgs e)
        {
            using (ModeloPaises contextoBD = new ModeloPaises())
            {

                Pais aux = contextoBD.Pais.Where(x => x.DescripcionPais == "55555555").FirstOrDefault();
                if (aux == null)
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "s1", "alert('El registro no se encontro')", true);
                    return;
                }

                contextoBD.Pais.Remove(aux);
                contextoBD.SaveChanges();
                //ScriptManager.RegisterStartupScript(this, this.GetType(), "s1", "alert('Se logro eliminar el registro')", true);
                cargarGrid();

            }

        }
    }
}
  
   
