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

    public class mentee : User
    {
        
        private EducationLevel pendidikanTerakhir;

        public mentee(string namaLengkap, string username, string password, string umur, Role role) : base(namaLengkap, username, password, umur, role)
        {
        }

        internal EducationLevel PendidikanTerakhir { get => pendidikanTerakhir; set => pendidikanTerakhir = value; }



    }

    
}
