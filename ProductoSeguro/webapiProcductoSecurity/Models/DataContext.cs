using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace webapiProcductoSecurity.Models
{
    using System.Data.Entity;
    public class DataContext:DbContext
    {
        public DataContext():base("DefaultConnection")
        {
                                            
        }

        public System.Data.Entity.DbSet<webapiProcductoSecurity.Models.Product> Products { get; set; }
    }
}