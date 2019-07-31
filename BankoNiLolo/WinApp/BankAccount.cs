using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinApp
{
    class BankAccount
    {
        //properties

        /*ACCESS MODIFIER
        *  - sets the level of scope of a particular variable or properties , method
        * PUBLIC - can be access within the whole project
        * PRIVATE - can be access within a file..
        * PROTECTED - this is the access modifier to prevent your properties to be inherit
        * 
        * */
        public string AccountNumber { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string middleInitial { get; set; }
        public string emailAddress { get; set; }
        public string contactNumber { get; set; }
        public string AccountType { get; set; }

        private int someVariable { get; set; }// you can't access outside 

        //Method
    
        /*Method is compose of 
        * 1. Access Modifier (public)
        * 2. return Type/DataType  (void, string, float, Int)
        * 3. the Name - 
        * 4. () argument.. 
        *    - you can optionally set / not set a parameter
        *    - a method can handle unlimited parameter
        * */
        public void SaveAccount(string accountnumber, int age, bool syaBayMahalMo)
        {

        }

        public void UpdateAccount()
        {

        }

        public void DeleteAccount()
        {

        }

        //sample of that returns a value
        public double getBalance()
        {
            //you have to ensure that whenever you use a type, you Put a return keyword.

            return 143.44;
        }

        public string getAccountByNumber(string accountnumber) //that account number is an argument/ parameter
        {
            return "Poncho Piccaso";
        }

       
    }
}
