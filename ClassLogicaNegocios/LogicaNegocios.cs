using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ClassAccesoDatos;
using ClassEntidades;
using System.Data;
using System.Data.SqlClient;

namespace ClassLogicaNegocios
{
    public class LogicaNegocios
    {
       //Cadena de Conexión.
        private AccesoDatos obAcc = new AccesoDatos(@"Data Source=LAPTOP-C63MHBI1\SQLEXPRESS2017; Initial Catalog=MiTaller2021; Integrated Security = true;");

        //Insertar Revisiones.
        public Boolean InsertarRevisiones(Revisiones nuevaRev, ref string msjSalida )
        {
            SqlParameter[] param1 = new SqlParameter[7];
            param1[0] = new SqlParameter
            {
                ParameterName = "idRev",
                SqlDbType = SqlDbType.Int,
                Direction = ParameterDirection.Input,
                Value = nuevaRev.id_Revision

            };
            param1[1] = new SqlParameter
            {
                ParameterName = "Entrada",
                SqlDbType = SqlDbType.DateTime,
                Direction = ParameterDirection.Input,
                Value = nuevaRev.Entrada

            };
            param1[2] = new SqlParameter
            {
                ParameterName = "Falla",
                SqlDbType = SqlDbType.VarChar,
                Size = 300,
                Direction = ParameterDirection.Input,
                Value = nuevaRev.Falla

            };
            param1[3] = new SqlParameter
            {
                ParameterName = "Dignostico",
                SqlDbType = SqlDbType.VarChar,
                Size = 350,
                Direction = ParameterDirection.Input,
                Value = nuevaRev.diagnostico

            };
            param1[4] = new SqlParameter
            {
                ParameterName = "Autorizacion",
                SqlDbType = SqlDbType.Bit,
                Direction = ParameterDirection.Input,
                Value = nuevaRev.Autorizacion

            };
            param1[5] = new SqlParameter
            {
                ParameterName = "Auto",
                SqlDbType = SqlDbType.Int,
                Direction = ParameterDirection.Input,
                Value = nuevaRev.Auto

            };
            param1[6] = new SqlParameter
            {
                ParameterName = "Mecanico",
                SqlDbType = SqlDbType.Int,
                Direction = ParameterDirection.Input,
                Value = nuevaRev.Mecanico

            };
            
            string sentenciaSql = "insert into Revision values(@idRev,@Entrada,@Falla,@Diagnostico,@Autorizacion,@Auto,@Mecanico);";

            Boolean salida = false;
            salida = obAcc.ModificaBDMasSegura(sentenciaSql,obAcc.AbrirConexion(ref msjSalida),ref msjSalida, param1);

            return salida;
        }

        //Insertar Mecanico.
        public Boolean InsertarMecanico(Mecanicos nuevoMec, ref string msjSalida)
        {
            SqlParameter[] param1 = new SqlParameter[6];
            param1[0] = new SqlParameter
            {
                ParameterName = "idTec",
                SqlDbType = SqlDbType.Int,
                Direction = ParameterDirection.Input,
                Value = nuevoMec.id_Tecnico

            };
            param1[1] = new SqlParameter
            {
                ParameterName = "Nombre",
                SqlDbType = SqlDbType.VarChar,
                Size = 120,
                Direction = ParameterDirection.Input,
                Value = nuevoMec.Nombre

            };
            param1[2] = new SqlParameter
            {
                ParameterName = "App",
                SqlDbType = SqlDbType.VarChar,
                Size = 100,
                Direction = ParameterDirection.Input,
                Value = nuevoMec.App

            };
            param1[3] = new SqlParameter
            {
                ParameterName = "Apm",
                SqlDbType = SqlDbType.VarChar,
                Size = 100,
                Direction = ParameterDirection.Input,
                Value = nuevoMec.Apm

            };
            param1[4] = new SqlParameter
            {
                ParameterName = "Cel",
                SqlDbType = SqlDbType.VarChar,
                Size = 20,
                Direction = ParameterDirection.Input,
                Value = nuevoMec.Celular

            };
            param1[5] = new SqlParameter
            {
                ParameterName = "Correo",
                SqlDbType = SqlDbType.VarChar,
                Size = 120,
                Direction = ParameterDirection.Input,
                Value = nuevoMec.Correo

            };
            
          
            string sentenciaSql = "insert into Mecanico values(@idTec,@Nombre,@App,@Apm,@Cel,@Correo);";

            Boolean salida = false;
            salida = obAcc.ModificaBDMasSegura(sentenciaSql, obAcc.AbrirConexion(ref msjSalida), ref msjSalida, param1);

            return salida;
        }

        //Mostrar/Devolver Revisiones.
        public List<Revisiones> DevuelveRevisionID(ref string msj)
        {
            SqlConnection conextemp = null;
            string query = "select * from Revision";

            conextemp = obAcc.AbrirConexion(ref msj);

            SqlDataReader datos = null;
            datos = obAcc.ConsultaReader(query, conextemp, ref msj);

            List<Revisiones> listaSalida = new List<Revisiones>();
            if(datos != null)
            {
                while(datos.Read())
                {
                    listaSalida.Add(new Revisiones
                    {
                        id_Revision = (int)datos[0],
                        Entrada = (DateTime)datos[1],
                        Falla = (string)datos[2],
                        diagnostico = (string)datos[3],
                        Autorizacion = (byte)datos[4],
                        Auto = (int)datos[5],
                        Mecanico = (int)datos[6]

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

        public List<Mecanicos> DevuelveMecanicoID(ref string msj)
        {
            SqlConnection conextemp = null;
            string query = "select * from Mecanico";

            conextemp = obAcc.AbrirConexion(ref msj);

            SqlDataReader datos = null;
            datos = obAcc.ConsultaReader(query, conextemp, ref msj);

            List<Mecanicos> listaSalida = new List<Mecanicos>();
            if (datos != null)
            {
                while (datos.Read())
                {
                    listaSalida.Add(new Mecanicos
                    {
                        id_Tecnico = (int)datos[0],
                        Nombre = (string)datos[1],
                        App = (string)datos[2],
                        Apm = (string)datos[3],
                        Celular = (string)datos[4],
                        Correo = (string)datos[5]

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
