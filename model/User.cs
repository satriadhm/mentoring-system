using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mentoring_system.model
{
    enum JenisKelamin
    {
        PRIA,
        WANITA
    }
    internal class User
    {

        private string username;

        private int Id;
        private string NamaLengkap;
        private string userName;
        private string password;
        private JenisKelamin jenisKelamin;
        private int umur;

        public User(string namaLengkap, string username, string password, int umur)
        {
            Debug.Assert(namaLengkap != null);

            Random random = new Random();
            Debug.Assert(namaLengkap.Length <= 30);
            Debug.Assert(username.Length <= 10);
            Debug.Assert(!string.IsNullOrEmpty(namaLengkap));
            Debug.Assert(!string.IsNullOrEmpty(userName));
            //Debug.Assert();
            this.NamaLengkap = namaLengkap;
            this.userName = username;
            this.umur = umur;
            this.Id = random.Next();

        }
        public int ID { get => Id; set => Id = value; }
        
        public int Umur { get => umur; set => umur = value; }
         

    }

    class userState 
    {
        
    }
}
