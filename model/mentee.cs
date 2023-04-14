using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mentoring_system.model
{

    public class mentee : User
    {

        public mentee(string namaLengkap, string username, string password, string umur) : base(namaLengkap, username, password, umur)
        {
            this.role = (Role)0;
        }

    }

    
}
