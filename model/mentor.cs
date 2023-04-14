using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mentoring_system.model
{
   public enum subjekMentoring
    {
        KALKULUS,
        PEMROGRAMAN_DASAR,
        KIMIA,
        FISIKA,
        BIOLOGI

    }
    public class mentor : User
    {
        public mentor(string namaLengkap, string username, string password, string umur) : base(namaLengkap, username, password, umur)
        {
        
            this.role = (Role)1;
        }
    }
}
