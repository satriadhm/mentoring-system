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

        public mentee(string namaLengkap, string username, string password, int umur) : base(namaLengkap, username, password, umur)
        {

        }

        internal EducationLevel PendidikanTerakhir { get => pendidikanTerakhir; set => pendidikanTerakhir = value; }



    }

    
}
