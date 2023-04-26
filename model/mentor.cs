using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        private subjekMentoring Subjek { get; set; }

        public mentor(string namaLengkap, string username, string password, string umur, subjekMentoring subjek) : base(namaLengkap, username, password, umur)
        {
            this.Subjek = subjek;
            this.role = (Role)1;
        }
    }
}
