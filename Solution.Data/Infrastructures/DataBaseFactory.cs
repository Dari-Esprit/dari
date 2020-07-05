using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.Data.Infrastructures
{
    public class DataBaseFactory : Disposable,IDataBaseFactory
    {

        private MyContext datacontext;

        public MyContext DataContext
        {
            get { return datacontext; }
            
        }

        public DataBaseFactory()
        {
            datacontext = new MyContext();
        }

        public override void DisposeCore()
        {
            if (datacontext != null)
                datacontext.Dispose();
        }
    }
}
