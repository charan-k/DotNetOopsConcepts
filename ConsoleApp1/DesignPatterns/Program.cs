using SingletonDemo;

namespace DesignPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Single Ton Design Pattern

            Singleton fromTeachaer = Singleton.GetInstance;
            fromTeachaer.PrintDetails("From Teacher");
            Singleton fromStudent = Singleton.GetInstance;
            fromStudent.PrintDetails("From Student");
            Console.ReadLine();

            #endregion

            #region Factory Design Pattern

            //Generally we will get the Card Type from UI.
            //Here we are hardcoded the card type
            string cardType = "MoneyBack";
            CreditCard? cardDetails = null;
            //Based of the CreditCard Type we are creating the
            //appropriate type instance using if else condition
            switch (cardType)
            {
                case "MoneyBack":
                    cardDetails = new MoneyBack();
                    break;
                case "Titanium":
                    cardDetails = new Titanium();
                    break;
                case "Platinum":
                    cardDetails = new Platinum();
                    break;
            }
            if (cardDetails != null)
            {
                Console.WriteLine("CardType : " + cardDetails.GetCardType());
                Console.WriteLine("CreditLimit : " + cardDetails.GetCreditLimit());
                Console.WriteLine("AnnualCharge :" + cardDetails.GetAnnualCharge());
            }
            else
            {
                Console.Write("Invalid Card Type");
            }
            Console.ReadLine();
            #endregion
        }
    }
}