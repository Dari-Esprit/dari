using Service.Pattern;
using Solution.Data.Infrastructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.Service
{
    public class ExempleService:/*Service<Exemple>,*/IExempleService
    {
        static IDataBaseFactory Factory = new DataBaseFactory();
        static IUnitOfWork utk = new UnitOfWork(Factory);
        public ExempleService()//:base(utk)
        {

        }
        // implémentation des méthodes sauf CRUD
    }
}
