using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExoApi.Models
{
    public class Medico
    {
        [Key]
        public int Id {get;set;}

        public string NomeMedico {get;set;}

        public string Especialidade {get;set;}

    }
}