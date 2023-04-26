using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mentoring_system.model
{

    public enum Role
    {
        MENTOR,
        MENTEE
    }
    public class User
    {
        public int Id { get; set; }
        public string NamaLengkap { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
        public string umur { get; set; }
        public Role role { get; set; }

        public User(string namaLengkap, string username, string password, string umur)
        { 
            Random random = new Random();
            this.NamaLengkap = namaLengkap;
            this.userName = username;
            this.umur = umur;
            this.Id = random.Next();
            this.password = password;

            Debug.Assert(!string.IsNullOrEmpty(namaLengkap), "Nama Lengkap tidak boleh kosong.");
            Debug.Assert(!string.IsNullOrEmpty(userName), "Username tidak boleh kosong.");
            Debug.Assert(!string.IsNullOrEmpty(password), "Password tidak boleh kosong.");
            Debug.Assert(namaLengkap.Length <= 30, "Nama Lengkap maksimal 3 kata.");
            //Debug.Assert(username.Length <= 15, "Username maksimal 15 karakter.");


        }

    }

}
