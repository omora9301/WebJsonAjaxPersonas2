using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using EntityPersonas;

namespace AppDataPersonas
{
    public class DatPersonas
    {
        SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString);

        public DataTable Obtener() 
        {
            SqlCommand cmd = new SqlCommand("spObtenerPersonas", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public void Agregar(EntPersonas p) 
        {
            SqlCommand cmd = new SqlCommand("spAgregar", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Nombre", p.Nombre);
            cmd.Parameters.AddWithValue("@Paterno", p.Paterno);
            cmd.Parameters.AddWithValue("@Materno", p.Materno);
            cmd.Parameters.AddWithValue("@Edad", p.Edad);
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }
        public DataRow ObtenerId(EntPersonas p) 
        {
            SqlCommand cmd = new SqlCommand("spObtenerId", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ObtId", p.Id);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt.Rows[0];          
        }
        public void Editar(EntPersonas p) 
        {
            SqlCommand cmd = new SqlCommand("spActualizar", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Nombre", p.Nombre);
            cmd.Parameters.AddWithValue("@Paterno", p.Paterno);
            cmd.Parameters.AddWithValue("@Materno", p.Materno);
            cmd.Parameters.AddWithValue("@Edad", p.Edad);
        }
        public void Eliminar(EntPersonas p) 
        {
            SqlCommand cmd = new SqlCommand("spEliminar", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id", p.Id);
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }
    }
}
