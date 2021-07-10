using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServicewithInterfaces.Client.Resources
{
   public interface IRepository
    {
        List<Data> GetData();
    }
}
