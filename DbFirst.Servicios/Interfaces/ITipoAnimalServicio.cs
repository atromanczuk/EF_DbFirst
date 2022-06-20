using DbFirst.Data.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbFirst.Servicios.Servicios
{
    public interface ITipoAnimalServicio
    {
        List<TipoAnimal> ObtenerTodos();

    }
}
