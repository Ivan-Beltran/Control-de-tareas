using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemLibrary
{
    public class Users
    {
        public string name { get; set; }
        public string password { get; set; }
        public Users(string name, string password)
        {
            this.name = name;
            this.password = password;
        }
        public bool Validate(string inputName, string inputPassword)
        {
            return name==inputName && password==inputPassword;
       
        }

    }



} 
