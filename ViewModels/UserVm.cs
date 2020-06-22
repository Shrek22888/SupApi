using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SupApi.ViewModels
{
    public class UserVm
    {
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string Number { get; set; }

        public UserVm(string userName, string firstName, string secondName, string number)
        {
            UserName = userName;
            FirstName = firstName;
            SecondName = secondName;
            Number = number;
        }
    }
}
