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

<<<<<<< HEAD
        public User(string namaLengkap, string username, string password, string umur, Role role)
=======
        private string username;

        private int Id;
        private string NamaLengkap;
        private string userName;
        private string password;
       // private JenisKelamin jenisKelamin;
        private int umur;

        public User(string namaLengkap, string username, string password,  int umur) 
>>>>>>> fe2e47a7e5e38946aa13b0a96361e5180c91a380
        {
            Debug.Assert(namaLengkap != null);

            Random random = new Random();
            this.NamaLengkap = namaLengkap;
            this.userName = username;
            this.umur = umur;
            this.Id = random.Next();
            this.role = role;
            this.password = password;
            //Debug.Assert(namaLengkap.Length <= 30);
            //Debug.Assert(username.Length <= 10);
            //Debug.Assert(!string.IsNullOrEmpty(namaLengkap));
            //Debug.Assert(!string.IsNullOrEmpty(userName));
            //Debug.Assert();

        }

    }

}
