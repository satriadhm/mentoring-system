using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mentoring_system.model
{
    enum subjekMentoring
    {
        KALKULUS,
        PEMROGRAMAN_DASAR,
        KIMIA,
        FISIKA,
        BIOLOGI

    }
    public class mentor : User
    {
        public mentor(string namaLengkap, string username, string password, string umur, Role role) : base(namaLengkap, username, password, umur, role)
        {
        }
    }
}
