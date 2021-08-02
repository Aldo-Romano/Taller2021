using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

using ClassAccesoDatos;
using ClassEntidades;


namespace ClassLogicaNegocios
{
    public class LogicaNegocios
    {
        //Cadena de Conexión.
        private AccesoDatos obAcc = new AccesoDatos(@"Data Source=LAPTOP-99LGH8E7\SQLEXPRESS; Initial Catalog=MiTaller2021; Integrated Security = true;");

        //Insertar Marca.
        public Boolean InsertarMarca(Marcas nuevaMarca, ref string msjSalida)
        {
            SqlParameter[] param1 = new SqlParameter[1];
            param1[0] = new SqlParameter
            {
                ParameterName = "idMarca",
                SqlDbType = SqlDbType.Int,
                Direction = ParameterDirection.Input,
                Value = nuevaMarca.id_marca
            };
            param1[1] = new SqlParameter
            {
                ParameterName = "marca",
                SqlDbType = SqlDbType.VarChar,
                Size = 120,
                Direction = ParameterDirection.Input,
                Value = nuevaMarca.marca

            };
            string sentenciaSql = "insert into Marcas values(@idMarca,@marca);";

            Boolean salida = false;
            salida = obAcc.ModificaBDMasSegura(sentenciaSql, obAcc.AbrirConexion(ref msjSalida), ref msjSalida, param1);

            return salida;
        }

        //Insertar Reparaciones.
        public Boolean InsertarReparaciones(Reparaciones nuevaReparacion, ref string msjSalida)
        {
            SqlParameter[] param1 = new SqlParameter[4];
            param1[0] = new SqlParameter
            {
                ParameterName = "idReparacion",
                SqlDbType = SqlDbType.Int,
                Direction = ParameterDirection.Input,
                Value = nuevaReparacion.id_reparacion
            };
            param1[1] = new SqlParameter
            {
                ParameterName = "detalles",
                SqlDbType = SqlDbType.NVarChar,
                Size = 300,
                Direction = ParameterDirection.Input,
                Value = nuevaReparacion.detalles

            };
            param1[2] = new SqlParameter
            {
                ParameterName = "garantia",
                SqlDbType = SqlDbType.VarChar,
                Size = 40,
                Direction = ParameterDirection.Input,
                Value = nuevaReparacion.garantia

            };
            param1[3] = new SqlParameter
            {
                ParameterName = "salida",
                SqlDbType = SqlDbType.Date,
                Direction = ParameterDirection.Input,
                Value = nuevaReparacion.salida

            };
            param1[4] = new SqlParameter
            {
                ParameterName = "fk_revision",
                SqlDbType = SqlDbType.Int,
                Direction = ParameterDirection.Input,
                Value = nuevaReparacion.Fk_revision

            };
            string sentenciaSql = "insert into Reparacion values(@idReparacion,@detalles,@garantia,@salida,@fk_revision);";

            Boolean salida = false;
            salida = obAcc.ModificaBDMasSegura(sentenciaSql, obAcc.AbrirConexion(ref msjSalida), ref msjSalida, param1);

            return salida;
        }

        //Mostrar y devolver Marcas.
        public List<Marcas> DevuelveMarcasID(ref string msj)
        {
            SqlConnection conextemp = null;
            string query = "select * from Marcas";

            conextemp = obAcc.AbrirConexion(ref msj);

            SqlDataReader datos = null;
            datos = obAcc.ConsultaReader(query, conextemp, ref msj);

            List<Marcas> listaSalida = new List<Marcas>();
            if (datos != null)
            {
                while (datos.Read())
                {
                    listaSalida.Add(new Marcas
                    {
                        id_marca = (int)datos[0],
                        marca = (string)datos[1],
                    });
                }

            }
            else
            {
                listaSalida = null;
            }
            conextemp.Close();
            conextemp.Dispose();

            return listaSalida;
        }
        // Mostrar y devolver Reparaciones.
        public List<Reparaciones> DevuelveReparacionID(ref string msj)
        {
            SqlConnection conextemp = null;
            string query = "select * from Reparacion";

            conextemp = obAcc.AbrirConexion(ref msj);

            SqlDataReader datos = null;
            datos = obAcc.ConsultaReader(query, conextemp, ref msj);

            List<Reparaciones> listaSalida = new List<Reparaciones>();
            if (datos != null)
            {
                while (datos.Read())
                {
                    listaSalida.Add(new Reparaciones
                    {
                        id_reparacion = (int)datos[0],
                        detalles = (string)datos[1],
                        garantia = (string)datos[2],
                        salida = (DateTime)datos[3],
                        Fk_revision = (int)datos[4],
                    }
                     );
                }
            }
            else
            {
                listaSalida = null;
            }
            conextemp.Close();
            conextemp.Dispose();

            return listaSalida;
        }
    }
}
