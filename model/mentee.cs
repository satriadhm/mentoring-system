using System;
using System.Diagnostics.Contracts;

namespace mentoring_system.model
{
    public class mentee : User
    {
        public mentee(string namaLengkap, string username, string password, string umur) : base(namaLengkap, username, password, umur)
        {
            Contract.Requires(!string.IsNullOrEmpty(namaLengkap));
            Contract.Requires(!string.IsNullOrEmpty(username));
            Contract.Requires(!string.IsNullOrEmpty(password));
            Contract.Requires(!string.IsNullOrEmpty(umur));
            Contract.Ensures(this.role == Role.MENTEE);

            this.role = Role.MENTEE;
        }
    }
}
