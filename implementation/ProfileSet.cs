using System;
using System.Collections.Generic;
using System.Diagnostics;
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

        // Precondition: parameter namaUser, umurUser, userName, dan password tidak boleh null
        // Postcondition: objek ProfileSet diisi dengan parameter namaUser, umurUser, userName, dan password
        public void ProfileSets(T namaUser, T umurUser, T userName, T password)
        {
            Debug.Assert(namaUser != null, "namaUser tidak boleh null");
            Debug.Assert(umurUser != null, "umurUser tidak boleh null");
            Debug.Assert(userName != null, "userName tidak boleh null");
            Debug.Assert(password != null, "password tidak boleh null");

            this.namaUser = namaUser;
            this.umurUser = umurUser;
            this.userName = userName;
            this.password = password;
        }

        public T Getnama()
        {
            return this.namaUser;
        }

        public T Getumur()
        {
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

        // Invariant: namaUser, umurUser, userName, dan password tidak boleh null
        public void PrintProfile()
        {
            Debug.Assert(namaUser != null, "namaUser tidak boleh null");
            Debug.Assert(umurUser != null, "umurUser tidak boleh null");
            Debug.Assert(userName != null, "userName tidak boleh null");
            Debug.Assert(password != null, "password tidak boleh null");

            Console.WriteLine("Nama: " + Getnama());
            Console.WriteLine("Umur " + Getumur());
            Console.WriteLine("Username " + GetuserName());
            Console.WriteLine("Password: " + Getpassword());
        }
    }
}
