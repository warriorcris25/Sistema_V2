﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Sol_PuntoVenta.Entidades;

namespace Sol_PuntoVenta.Datos
{
    public class D_Familias
    {
        public DataTable Listado_fa(string cTexto)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("USP_Listado_fa", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@cTexto", SqlDbType.VarChar).Value = cTexto;
                SqlCon.Open();
                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
        }

        public string Guardar_fa(int nOpcion, E_Familias oPropiedad)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("USP_Guardar_fa", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@nOpcion", SqlDbType.Int).Value = nOpcion;
                Comando.Parameters.Add("@nCodigo", SqlDbType.Int).Value = oPropiedad.Codigo_fa;
                Comando.Parameters.Add("@cDescripcion", SqlDbType.VarChar).Value = oPropiedad.Descripcion_fa;
                SqlCon.Open();
                Rpta = Comando.ExecuteNonQuery() >= 1 ? "OK" : "No se pudo ingresar el registro";

            }
            catch (Exception ex)
            {

                Rpta = ex.Message;

            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Rpta;
        }
        public string Eliminar_fa(int nCodigo)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("USP_Eliminar_fa", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@nCodigo", SqlDbType.Int).Value = nCodigo;
                SqlCon.Open();
                Rpta = Comando.ExecuteNonQuery() >= 1 ? "OK" : "No se pudo eliminar el registro";
            }
            catch (Exception ex)
            {

                Rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Rpta;
        }
    }
}
