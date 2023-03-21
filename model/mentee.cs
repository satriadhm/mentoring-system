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
    enum PilihanSubjek
    {
        KALKULUS,
        KIMIA,
        FISIKA
    }
    internal class mentee : User
    {
       
        private EducationLevel pendidikanTerakhir;
        private PilihanSubjek subjek;

        
        internal EducationLevel PendidikanTerakhir { get => pendidikanTerakhir; set => pendidikanTerakhir = value; }

        internal PilihanSubjek 
            Subjek { get => 
            Subjek; set => Subjek = value;          
        }

    }

    
}
