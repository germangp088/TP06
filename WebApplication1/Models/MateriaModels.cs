using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class MateriaModels
    {
        public string Nombre_Materia { get; set; }
        public DateTime Fecha_Materia { get; set; }
        public int Nota_Materia { get; set; }
        public int Legajo { get; set; }
    }
}