using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExoApi.Contexts;
using ExoApi.Models;
namespace ExoApi.Repositories
{
    public class MedicosRepository
    {
        ExoContext ctx = new ExoContext();

        public List<Medico> Listar()
        {
            return ctx.Medico.ToList();
        }
    }
}