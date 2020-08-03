using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; 
using CapaDatos;
using System.Configuration;
using System.Data;

namespace CapaDatos
{
    public class GestionBD
    {
        SqlConnection conexion;
        SqlCommand comando;
        string cadenaConexion = ConfigurationManager.ConnectionStrings["conexionPruebas"].ConnectionString;
        List<Pais> listadoTools; //Declarando

        public List<Pais> listadoPais()
        {
            SqlDataReader datosLeidos;
            List<Pais> listadoRentornar;
            List<Idioma> listadoRentorna;
            List<GestionP> listadoR;

            //Paso#1 Crear la conexion
            conexion = new SqlConnection(); //Creamos el objeto en memoria     
                                            //conexion.ConnectionString = "Data Source=DESKTOP-3SB06G1;Initial Catalog=UIA;Integrated Security=True";  //String de Conexion
            conexion.ConnectionString = cadenaConexion;

            comando = new SqlCommand();
            comando.Connection = conexion; 
            comando.CommandText = "Select * from Pais";
            comando.CommandText = "Select * from Idioma";
            comando.CommandText = "Select * from GestionP";
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandTimeout = 0;  //expresado en segundos

            //Paso#3 Ejecutar el comando
            conexion.Open();
            datosLeidos = comando.ExecuteReader(); //Es la que ejecuta la accion en base de datos


            //Paso#4 Configurar la estructura a retornar
            listadoRentornar = new List<Pais>();
            listadoRentorna = new List<Idioma>();
            listadoR = new List<GestionP>();
            while (datosLeidos.Read())
            {

                Pais objPais = new Pais(); //Creamo el objeto genero
                objPais.CodigoPais = datosLeidos.GetInt32(0);
                objPais.DescripcionPais = datosLeidos.GetString(1);

                listadoRentornar.Add(objPais);

                Idioma objIdioma = new Idioma();
                objIdioma.CodigoIdioma = datosLeidos.GetInt32(0);
                objIdioma.DescripcionIdioma = datosLeidos.GetString(1);
                listadoRentorna.Add(objIdioma);

                GestionP objGestion = new GestionP();
                objGestion.CodigoPais = datosLeidos.GetInt32(0);
                objGestion.Habitantes = datosLeidos.GetInt32(1);
                objGestion.Idioma = datosLeidos.GetChar(2);
                objGestion.PIB = datosLeidos.GetInt32(3);
                objGestion.Superficie = datosLeidos.GetInt32(4);
                objGestion.Riesgo = datosLeidos.GetChar(5);
                objGestion.SujetoP = datosLeidos.GetByte(6);
                listadoR.Add(objGestion);


            }

            return listadoRentornar;


        }
        public bool registrarPaises(Pais objPais)
        {
            int control = -1;
            bool respuesta = false;

            using (SqlConnection cnx = new SqlConnection(cadenaConexion))
            {
                comando = new SqlCommand();
                comando.Connection = cnx;
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "Insert into Pais (CodigoPais,DescripcionPais) " +
                                      " Values (@CodigoPais,@DescripcionPais)";

                //Definicion del parametro @Identificacion
                SqlParameter objParametro = new SqlParameter();
                objParametro.ParameterName = "@CodigoPais";
                objParametro.SqlDbType = System.Data.SqlDbType.VarChar;
                objParametro.Size = 30;
                objParametro.Value = objPais.DescripcionPais;

                comando.Parameters.Add(objParametro);


                comando.Parameters.Add(new SqlParameter("@DescripcionPais", objPais.DescripcionPais));


                cnx.Open();

                control = comando.ExecuteNonQuery();  //ejecucion del comando en base de datos

            }

            if (control > 0)
            {
                respuesta = true;
            }

            return respuesta;


        }
        public bool registrarIdioma(Idioma objIdioma)
        {
            int control = -1;
            bool respuesta = false;

            using (SqlConnection cnx = new SqlConnection(cadenaConexion))
            {
                comando = new SqlCommand();
                comando.Connection = cnx;
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "Insert into Idioma (CodigoIdioma,DescripcionIdioma) " +
                                      " Values (@CodigoIdioma,@DescripcionIdioma)";

                //Definicion del parametro @Identificacion
                SqlParameter objParametro = new SqlParameter();
                objParametro.ParameterName = "@CodigoIdioma";
                objParametro.SqlDbType = System.Data.SqlDbType.VarChar;
                objParametro.Size = 30;
                objParametro.Value = objIdioma.DescripcionIdioma;

                comando.Parameters.Add(objParametro);


                comando.Parameters.Add(new SqlParameter("@DescripcionIdioma", objIdioma.DescripcionIdioma));


                cnx.Open();

                control = comando.ExecuteNonQuery();

            }

            if (control > 0)
            {
                respuesta = true;
            }

            return respuesta;
        }
        public bool registrarGestionP(GestionP objGestionP)
        {
            int control = -1;
            bool respuesta = false;

            using (SqlConnection cnx = new SqlConnection(cadenaConexion))
            {
                comando = new SqlCommand();
                comando.Connection = cnx;
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "Insert into GestionP (CodigoPais,Habitantes,Idioma,PIB,Superficie,Riesgo,SujetoP) " +
                                      " Values (@CodigoPais,@Habitantes,@Idioma,@PIB,@Superficie,@Riesgo,@SujetoP)";

              
                SqlParameter objParametro = new SqlParameter();
                objParametro.ParameterName = "@CodigoPais";
                objParametro.SqlDbType = System.Data.SqlDbType.VarChar;
                objParametro.Size = 30;
                objParametro.Value = objGestionP.CodigoPais;

                comando.Parameters.Add(objParametro);
                comando.Parameters.Add(new SqlParameter("@Habitantes", objGestionP.Habitantes));

                
                comando.Parameters.Add(new SqlParameter("@Idioma", objGestionP.Idioma));

               
                comando.Parameters.Add(new SqlParameter("@PIB", objGestionP.PIB));

                comando.Parameters.Add(new SqlParameter("@Superficie", objGestionP.Superficie));

                comando.Parameters.Add(new SqlParameter("@Riesgo", objGestionP.Riesgo));

                comando.Parameters.Add(new SqlParameter("@SujetoP", objGestionP.SujetoP));

                cnx.Open();

                control = comando.ExecuteNonQuery();  

            }

            if (control > 0)
            {
                respuesta = true;
            }

            return respuesta;


        }

    }
}