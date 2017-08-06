using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Models
{
    public class User : IUser
    {
        private string username;

        public User(string username)
        {
            this.Username = username;
        }

        public string Username
        {
            get
            {
                return this.username;
            }
             set
            {
                if (string.IsNullOrEmpty(value) || value.Length < Constants.minLengthUsername || value.Length > Constants.maxLengthUsername)
                {
                    throw new ArgumentException(Constants.usernameErrorMessage);
                }
                this.username = value;
            }
        }


    }
}
