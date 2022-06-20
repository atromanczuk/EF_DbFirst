using DbFirst.Data.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbFirst.Data.Repositorio
{
     public interface ITipoAnimalRepositorio
    {
        List<TipoAnimal> ObtenerTodos();
    }
}
