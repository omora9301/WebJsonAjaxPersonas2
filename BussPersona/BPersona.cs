using AppDataPersonas;
using EntityPersonas;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussPersona
{
    public class BPersona
    {
        DatPersonas datos = new DatPersonas();
        public List<EntPersonas> Obtener()
        {
            DataTable dt = datos.Obtener();
            List<EntPersonas> ls = new List<EntPersonas>();
            foreach (DataRow dr in dt.Rows)
            {
                EntPersonas e = new EntPersonas();
                e.Id = Convert.ToInt32(dr["Id"]);
                e.Nombre = dr["Nombre"].ToString();
                e.Paterno = dr["Paterno"].ToString();
                e.Materno = dr["Materno"].ToString();
                e.Edad = Convert.ToInt32(dr["Edad"]);
                ls.Add(e);
            }
            return ls;
        }
        public string Agregar(EntPersonas p) 
        {
            datos.Agregar(p);
            return $"Se agregó {p.Nombre}";
        }
        public EntPersonas ObtPersonaId( EntPersonas p) 
        {
            DataRow dr = datos.ObtenerId(p);
            EntPersonas e = new EntPersonas();

            e.Id = Convert.ToInt32(dr["Id"]);
            e.Nombre = dr["Nombre"].ToString();
            e.Paterno = dr["Paterno"].ToString();
            e.Materno = dr["Materno"].ToString();
            e.Edad = Convert.ToInt32(dr["Edad"]);
            return e;
            
        }
        public string Actualizar(EntPersonas p) 
        {
            datos.Editar(p);
            return $"Registro Actualizado";
        }
        public string Eliminar(EntPersonas p)
        {
            datos.Eliminar(p);
            return $"Registro Eliminado";
        }

    }

}
