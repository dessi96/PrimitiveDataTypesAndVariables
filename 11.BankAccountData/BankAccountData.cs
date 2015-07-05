using System;

    class BankAccountData
    {
        static void Main()
        {
            string firstName = "Amanda";
            string middleName = "Louise";
            string lastName = "Jonson";
            decimal balance = 25146.87m;
            string bankName = "Societe Generale";
            string iban = "BG35 TTBB 9400 1525 7671 73";
            long cardNum1 = 154787487564897;
            long cardNum2 = 123456789154785;
            long cardNum3 = 564789414575234;

            Console.WriteLine("First name: " + firstName + "\nMiddle name: " + middleName + "\nLast name: " + lastName + 
                "\nBalance: " + balance + "\nBank name: " + bankName + "\nIBAN: " + iban + 
                "\nCard number 1: " + cardNum1 + "\nCard number 2: " + cardNum2 + "\nCard number 3: " + cardNum3);
        }
    }

