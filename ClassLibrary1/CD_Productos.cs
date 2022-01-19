using System;//
using System.Collections.Generic;//Contiene interfaces y clases que definen colecciones genéricas
using System.Text;//Contiene clases que representan codificaciones de caracteres ASCII y Unicode;
using System.Data.SqlClient;//que permite conectarse a un origen de datos SQL Server 7.0, ejecutar comandos y leer los resultados.
using System.Data;// sirve para consultar y actualizar la base de datos,contienen clases para tener acceso a datos y administrarlos desde distintos orígenes
using ClassLibrary1;
namespace CapaDatos
{
    //CD_Productos clase para hacer consultas a la tabla productos
    public class CD_Productos
    {
        //instanciamos a la clase conexion de forma privada para encapsular la variable
        private CD_Conexion conexion = new CD_Conexion();
        SqlDataReader leer;//agregamos la clase sqldatareader para leer las filas de la tabla
        DataTable tabla = new DataTable();//clase para almacenar las filas de las consultas que hara sqldatareader

        SqlCommand comando = new SqlCommand();//para ejecutar instrucciones sql

        public DataTable mostrar()//creamos un metodo datatable para mostrar los registros de la tabla
        {
            //transact sql
            //abrimos la conexion con comando.connection
            comando.Connection = conexion.abrirconexion();
            //comando sql a ejecutar
            comando.CommandText= "MostrarProductos";
            //usamos executereader para devolver filas
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();

            //rellenamos la tabla
            tabla.Load(leer);
            //cerramos la conexion despues de ejecutar la conexion
            conexion.cerrarconexion();

            //retornamos la tabla con los registros cargados
            return tabla;

        }
    }
}
