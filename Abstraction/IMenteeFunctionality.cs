using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mentoring_system.Abstraction
{
    internal interface IMenteeFunctionality
    {
        Task AddMenteeData(string url, model.Mentee menteeData);
        Task<model.Mentee> AuthenticateUser(string username, string password);

    }
}
