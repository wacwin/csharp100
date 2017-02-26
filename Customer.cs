using System;

namespace MiniLib
{
    class Customer
    {
        public String FirstName {get;set;}
        public String LastName {get;set;}
        public int Loyalty {get;private set;} = 0;

        private String _email;

        public void UpdateEmail(String email){
            _email = email;
        }

        public bool IsValidCustomer() => Loyalty>=1?true:false;

        public void UpdateVIP(double amount) 
        {
            if(amount>100.0){
                Loyalty +=1;
            }
        }


    }
}