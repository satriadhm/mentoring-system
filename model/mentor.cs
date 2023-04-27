using System;
using System.Diagnostics.Contracts;

namespace mentoring_system.model
{
    public enum subjekMentoring
    {
        interactionDesign,
        Algorithm,
        dataStructure
    }

    public class mentor : User
    {
        public subjekMentoring Subjek { get; set; }

        public mentor(string namaLengkap, string username, string password, string umur, subjekMentoring subjek) : base(namaLengkap, username, password, umur)
        {
            Contract.Requires(!string.IsNullOrEmpty(namaLengkap));
            Contract.Requires(!string.IsNullOrEmpty(username));
            Contract.Requires(!string.IsNullOrEmpty(password));
            Contract.Requires(!string.IsNullOrEmpty(umur));
            Contract.Requires(Enum.IsDefined(typeof(subjekMentoring), subjek));
            Contract.Ensures(this.Subjek == subjek);
            Contract.Ensures(this.role == Role.MENTOR);

            this.Subjek = subjek;
            this.role = Role.MENTOR;
        }
    }
}
