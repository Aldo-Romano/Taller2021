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

        //Insertar Clientes.
        public Boolean InsertarClientes(Clientes nuevoCliente, ref string msjSalida )
        {
            SqlParameter[] param1 = new SqlParameter[7];
            param1[0] = new SqlParameter
            {
                ParameterName = "idClien",
                SqlDbType = SqlDbType.Int,
                Direction = ParameterDirection.Input,
                Value = nuevoCliente.id_cliente

            };
            param1[1] = new SqlParameter
            {
                ParameterName = "nom",
                SqlDbType = SqlDbType.VarChar,
                Size = 90,
                Direction = ParameterDirection.Input,
                Value = nuevoCliente.nombre

            };
            param1[2] = new SqlParameter
            {
                ParameterName = "app",
                SqlDbType = SqlDbType.VarChar,
                Size = 90,
                Direction = ParameterDirection.Input,
                Value = nuevoCliente.app

            };
            param1[3] = new SqlParameter
            {
                ParameterName = "apm",
                SqlDbType = SqlDbType.VarChar,
                Size = 90,
                Direction = ParameterDirection.Input,
                Value = nuevoCliente.apm

            };
            param1[4] = new SqlParameter
            {
                ParameterName = "cel",
                SqlDbType = SqlDbType.VarChar,
                Size = 20,
                Direction = ParameterDirection.Input,
                Value = nuevoCliente.celular

            };
            param1[5] = new SqlParameter
            {
                ParameterName = "telO",
                SqlDbType = SqlDbType.VarChar,
                Size = 20,
                Direction = ParameterDirection.Input,
                Value = nuevoCliente.telOficina

            };
            param1[6] = new SqlParameter
            {
                ParameterName = "correoP",
                SqlDbType = SqlDbType.VarChar,
                Size = 120,
                Direction = ParameterDirection.Input,
                Value = nuevoCliente.correoPer

            };
            param1[7] = new SqlParameter
            {
                ParameterName = "correoC",
                SqlDbType = SqlDbType.VarChar,
                Size = 120,
                Direction = ParameterDirection.Input,
                Value = nuevoCliente.correoCorp

            };
            string sentenciaSql = "insert into Cliente values(@nom,@nom,@app,@apm,@cel,@telO,@correoP,@correoC);";

            Boolean salida = false;
            salida = obAcc.ModificaBDMasSegura(sentenciaSql,obAcc.AbrirConexion(ref msjSalida),ref msjSalida, param1);

            return salida;
        }

        //Insertar Autos.
        public Boolean InsertarAutos(Autos nuevoAuto, ref string msjSalida)
        {
            SqlParameter[] param1 = new SqlParameter[6];
            param1[0] = new SqlParameter
            {
                ParameterName = "idAut",
                SqlDbType = SqlDbType.Int,
                Direction = ParameterDirection.Input,
                Value = nuevoAuto.id_Auto

            };
            param1[1] = new SqlParameter
            {
                ParameterName = "marc",
                SqlDbType = SqlDbType.Int,
                Direction = ParameterDirection.Input,
                Value = nuevoAuto.f_marca

            };
            param1[2] = new SqlParameter
            {
                ParameterName = "model",
                SqlDbType = SqlDbType.VarChar,
                Size = 100,
                Direction = ParameterDirection.Input,
                Value = nuevoAuto.modelo

            };
            param1[3] = new SqlParameter
            {
                ParameterName = "anio",
                SqlDbType = SqlDbType.VarChar,
                Size = 4,
                Direction = ParameterDirection.Input,
                Value = nuevoAuto.año

            };
            param1[4] = new SqlParameter
            {
                ParameterName = "color",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Direction = ParameterDirection.Input,
                Value = nuevoAuto.color

            };
            param1[5] = new SqlParameter
            {
                ParameterName = "plac",
                SqlDbType = SqlDbType.VarChar,
                Size = 16,
                Direction = ParameterDirection.Input,
                Value = nuevoAuto.placas

            };
            param1[6] = new SqlParameter
            {
                ParameterName = "duen",
                SqlDbType = SqlDbType.Int,
                Direction = ParameterDirection.Input,
                Value = nuevoAuto.dueño

            };
          
            string sentenciaSql = "insert into Auto values(@idAut,@marc,@model,@anio,@color,@plac,@duen);";

            Boolean salida = false;
            salida = obAcc.ModificaBDMasSegura(sentenciaSql, obAcc.AbrirConexion(ref msjSalida), ref msjSalida, param1);

            return salida;
        }

        //Mostrar/Devolver Clientes.
        public List<Clientes> DevuelveClientesID(ref string msj)
        {
            SqlConnection conextemp = null;
            string query = "select * from Cliente";

            conextemp = obAcc.AbrirConexion(ref msj);

            SqlDataReader datos = null;
            datos = obAcc.ConsultaReader(query, conextemp, ref msj);

            List<Clientes> listaSalida = new List<Clientes>();
            if(datos != null)
            {
                while(datos.Read())
                {
                    listaSalida.Add(new Clientes
                    {
                        id_cliente = (int)datos[0],
                        nombre = (string)datos[1],
                        app = (string)datos[2],
                        apm = (string)datos[3],
                        celular = (string)datos[4],
                        telOficina = (string)datos[5],
                        correoPer = (string)datos[6],
                        correoCorp = (string)datos[7]

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
        //Mostrar/Devolver Autos.
        public List<Autos> DevuelveAutosID(ref string msj)
        {
            SqlConnection conextemp = null;
            string query = "select * from Auto";

            conextemp = obAcc.AbrirConexion(ref msj);

            SqlDataReader datos = null;
            datos = obAcc.ConsultaReader(query, conextemp, ref msj);

            List<Autos> listaSalida = new List<Autos>();
            if (datos != null)
            {
                while (datos.Read())
                {
                    listaSalida.Add(new Autos
                    {
                        id_Auto = (int)datos[0],
                        f_marca = (int)datos[1],
                        modelo = (string)datos[2],
                        año = (string)datos[3],
                        color = (string)datos[4],
                        placas = (string)datos[5],
                        dueño = (int)datos[6]

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
