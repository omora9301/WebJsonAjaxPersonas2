using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityPersonas
{
    public class EntPersonas
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Paterno { get; set; }
        public string Materno { get; set; }
        public  int Edad { get; set; }
        public DateTime FechaRegistro { get; set; }

        private string fechaformato;
        public string FechaFormato
        {
            get {
                fechaformato = FechaRegistro.ToString("yyyy-MM-dd");
                return fechaformato;
            }
        }
        private string nombrecompleto;
        public string Nombrecompleto 
        {
            get 
            {
                nombrecompleto = $"{Nombre } { Paterno} { Materno}";
                return nombrecompleto;
            }
        }
    }
}
