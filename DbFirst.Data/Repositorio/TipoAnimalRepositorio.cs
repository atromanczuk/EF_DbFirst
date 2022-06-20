using DbFirst.Data.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbFirst.Data.Repositorio
{
    public class TipoAnimalRepositorio : BaseRepositorio, ITipoAnimalRepositorio
    {
        //Para vivir necesito un contexto en base a eso
        public TipoAnimalRepositorio(db_firstContext ctx) : base(ctx)
        {
        }

        public List<TipoAnimal> ObtenerTodos()
        {
            return _Contexto.TipoAnimals.ToList();  
        }
    }
}
