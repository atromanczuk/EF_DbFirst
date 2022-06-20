using DbFirst.Data.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbFirst.Data.Repositorio
{
    public abstract class BaseRepositorio
    {
        protected db_firstContext _Contexto {get; set;}

        //creo objeto
        public BaseRepositorio(db_firstContext ctx) 
        {
            _Contexto = ctx;
        }

        //Guarda todos los cambios en el contexto
        public void SaveChanges() 
        {
            _Contexto.SaveChanges();
         }
    }
}
