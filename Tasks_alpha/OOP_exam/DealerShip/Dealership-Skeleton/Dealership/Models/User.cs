using Dealership.Common.Enums;
using Dealership.Contracts;
using System;
using System.Collections.Generic;

namespace Dealership.Models
{
    class User : IUser
    {
        private string username;
        private string firstName;
        private string lastName;
        private string password;
        //private string role;

        public User(string username, string firstName, string lastName, string password, Role role)
        {
            this.Username = username;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Password = password;
            this.Role = role;

        }

        public string Username
        {
            get
            {
                return this.username;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Enter valid username!");
                }
                this.username = value;
            }
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Enter valid first Name!");
                }
                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Enter valid last Name!");
                }
                this.lastName = value;
            }
        }

        public string Password
        {
            get
            {
                return this.password;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Enter valid last Name!");
                }
                if (value.Length < 8)
                {
                    throw new ArgumentException("Password must be better than 7 symbols!");
                }
                this.password = value;
            }
        }

        public Role Role {get; private set;}



        public IList<IVehicle> Vehicles { get; set;}

        public void AddComment(IComment commentToAdd, IVehicle vehicleToAddComment)
        {
            throw new NotImplementedException();
        }

        public void AddVehicle(IVehicle vehicle)
        {
            throw new NotImplementedException();
        }

        public string PrintVehicles()
        {
            throw new NotImplementedException();
        }

        public void RemoveComment(IComment commentToRemove, IVehicle vehicleToRemoveComment)
        {
            throw new NotImplementedException();
        }

        public void RemoveVehicle(IVehicle vehicle)
        {
            throw new NotImplementedException();
        }
    }
}
