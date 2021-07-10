using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServicewithInterfaces.Client.Resources
{
    public class RepositoryInMemory : IRepository
    {
        public List<Data> GetData()
        {
            return new List<Data>()
            {


                new Data(){Id=1, Name="Amit", Address="Noida"},
                new Data(){Id=2, Name="Sumit", Address="Gr Noida"},
                new Data(){Id=3, Name="Sonu", Address="Delhi"}

            };
        }
        
    }
}
