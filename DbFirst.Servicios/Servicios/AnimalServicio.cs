using DbFirst.Data.EF;
using DbFirst.Data.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbFirst.Servicios.Servicios
{
    public class AnimalServicio : IAnimalServicio
    {
        IAnimalRepositorio _animalRepositorio;
        //Para crear el Servicio neceisto un repositorio
        public AnimalServicio(IAnimalRepositorio animalRepositorio)
        {
            _animalRepositorio = animalRepositorio;
        }

        public void Insertar(Animal entidad)
        {
            _animalRepositorio.Insertar(entidad);
            _animalRepositorio.SaveChanges();
        }

        public List<Animal> ObtenerTodos()
        {
            return _animalRepositorio.ObtenerTodos();
        }

       
    }
}
