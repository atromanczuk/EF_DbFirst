using DbFirst.Data.EF;
using DbFirst.Data.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbFirst.Servicios.Servicios
{
    public class TipoAnimalServicio : ITipoAnimalServicio
    {
        ITipoAnimalRepositorio _tipoAnimalRepositorio;
        //Para crear el Servicio neceisto un repositorio
        public TipoAnimalServicio(ITipoAnimalRepositorio tipoAnimalRepositorio)
        {
            _tipoAnimalRepositorio = tipoAnimalRepositorio;
        }

        List<TipoAnimal> ITipoAnimalServicio.ObtenerTodos()
        {
           return _tipoAnimalRepositorio.ObtenerTodos();
        }
    }
}
