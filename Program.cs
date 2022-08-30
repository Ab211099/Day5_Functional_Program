namespace Basic_core_programs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello welcome to Basic Core Programs");
            Console.WriteLine("Enter the program number \n 1.Flip coin \n 2.Leap year" +
                "\n 3. Find Power Of Two \n 4.Harmonic number \n 5.Factors Program \n 6. Calculate Quotient & Reminder \n 7. Swap two numbers");
            int proramCheck = Convert.ToInt32(Console.ReadLine());

            switch (proramCheck)
            {
                case 1:
                    Flip_Coin.GetFlipCoin();
                    break;   
                case 2:
                    Leap_year.FindleapYear();
                    break;
                case 3:
                    Power_of_two.FindPowertwo();
                    break;
                case 4:
                    Harmonic_number.Number();
                    break;
                case 5:
                    Factors.FactorMethod();
                    break;
                case 6:
                    Quotient_reminder.QuoReminder();
                    break;
                case 7:
                    Swap_Two_numbers.SwapNumber();
                    break;

            }
            
        }
    }
}