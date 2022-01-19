using System;
using System.Data;
using System.Data.SqlClient;

namespace ClassLibrary1
{
    public class CD_Conexion
    {
        public SqlConnection Conexion = new SqlConnection("Server=DESKTOP-9B888EI;DataBase=Practica;Integrated Security=true");

        public SqlConnection abrirconexion()
        {
            if (Conexion.State == ConnectionState.Closed)
                Conexion.Open();
            return Conexion;

            
        }
        public SqlConnection cerrarconexion()
        {
            if (Conexion.State == ConnectionState.Open)
                Conexion.Close();
            return Conexion;

        }
    }
}
