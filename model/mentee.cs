using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mentoring_system.model
{
    enum EducationLevel
    {
        SD,
        SMP,
        SMA
    }

    internal class mentee : User
    {
       
        private EducationLevel pendidikanTerakhir;
      
        internal EducationLevel PendidikanTerakhir { get => pendidikanTerakhir; set => pendidikanTerakhir = value; }



    }

    
}
