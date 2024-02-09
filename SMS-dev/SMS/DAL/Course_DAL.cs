using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace SMS.DAL
{
    class Course_DAL
    {
        public int CID { get; set; }
        public string CName { get; set; }
        public string CType { get; set; }
        public int Cstatus { get; set; }
    }
}
