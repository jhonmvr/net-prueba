using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gestion_pistas_core.Models.wrapper
{
    public class PaginateWrapper<T>
    {
        public int totalResult { get; set; }
        public List<T> list { get; set; }
        public int? currentPage { get; set; }
        public int? pageSize { get; set; }
        public List<String> estado { get; set; }
        public List<OrdenamientoWrapper> sort {get; set;}
    }
}
