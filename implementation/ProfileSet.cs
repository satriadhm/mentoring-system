using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace mentoring_system.implementation
{
    internal class ProfileSet<T>
    {
        public T namaUser;
        public T umurUser;
        public T userName;
        public T password;

        public ProfileSet(T namaUser, T umurUser, T userName, T password)
        {
            this.namaUser = namaUser;
            this.umurUser = umurUser;
            this.userName = userName;
            this.password = password;
        }

        public void ProfileSets(T namaUser, T umurUser, T userName, T password) { 
            this.namaUser = namaUser;
            this.umurUser = umurUser;
            this.userName = userName;
            this.password = password;
        }

        public T Getnama() { 
            return this.namaUser;
        }

        public T Getumur() {
            return this.umurUser;
        }

        public T GetuserName()
        {
            return this.userName;

        }

        public T Getpassword()
        {
            return this.password;
        }

        public void PrintProfile() {
  
            Console.WriteLine("Nama: "+ Getnama() );
            Console.WriteLine("Umur " + Getumur());
            Console.WriteLine("Username "+ GetuserName());
            Console.WriteLine("Password: "+ Getpassword());
        }
    }
}
