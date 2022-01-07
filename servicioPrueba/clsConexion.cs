using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

#region LIBRERIAS AGREGADAS

using System.Data.SqlClient;
using System.Data;

#endregion

namespace servicioPrueba
{
    public class clsConexion
    {
        #region ATRIBUTOS

        protected string cadena = "Password=toor;Persist Security Info=True;User ID=root;Initial Catalog=evaluacion;Data Source=MASTER-10";

        public SqlConnection conexion;

        protected SqlCommandBuilder comandoB;

        public DataSet objDataSet;

        public SqlDataAdapter adaptador;

        public SqlCommand comando;

        #endregion

        #region METODO DE CONEXION

        private void Conectar()
        {
            conexion = new SqlConnection(cadena);
        }

        #endregion

        #region CONSTRUCTOR

        public clsConexion()
        {
            Conectar();
        }

        #endregion

        #region METODOS CONSULTA
        public DataSet consultar(string sql, string tabla)
        {
            objDataSet = new DataSet();
            adaptador = new SqlDataAdapter(sql, conexion);
            adaptador.Fill(objDataSet);
            return objDataSet;
        }
        #endregion
    }
}