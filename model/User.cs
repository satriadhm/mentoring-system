using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mentoring_system.model
{
    internal class User
    {
        enum JenisKelamin
        {
            PRIA,
            WANITA
        }

        private int Id;
        private string ?namaLengkap;
       // private JenisKelamin jenisKelamin;
        private int umur;
        public int ID { get => Id; set => Id = value; }
        public string NamaLengkap { get => namaLengkap; set => namaLengkap = value; }
        public int Umur { get => umur; set => umur = value; }
         

    }

    class userState 
    {
        
    }
}
