using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace SMS.DAL
{
    class Staff_DAL
    {
          public int EID{ get; set; }
          public string EFName{ get; set; }
          public string ELName{ get; set; }
	      public string EFullName{ get; set; }
	      public string ENameWithInit{ get; set; }
	      public string EAddress{ get; set; }
	      public string ENIC{ get; set; }
	      public string EGende{ get; set; }
	      public string EmartitalStatus{ get; set; }
	      public string Enationality{ get; set; }
	      public string EDOB{ get; set; }
	      public string EEmail{ get; set; }
	      public string EMobile{ get; set; }
	      public string EHomeMobile{ get; set; }
	      public string EDesignation{ get; set; }
	      public DateTime EEnrollDate { get; set; }
          public string photo_data { get; set; }




    }
}
