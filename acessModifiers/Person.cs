using System;

namespace acessModifiers
{
    public class Person{
        private DateTime _birthdate;
        
        public DateTime Birthdate{ 
            get => _birthdate;
            set => _birthdate = value;
        }
    }

}