using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_project
{
    public class MobilePhones
    {
        public static void Main()
        {
            int input;
            Console.WriteLine("1. OPPO \n 2. SAMSUNG \n 3.ALL");
            input= Convert.ToInt32( Console.ReadLine());

            switch (input)
            {
                case 1:
                    {
                        oppo oppoObj = new oppo();

                        string InputOppoModelName = null;

                        Console.WriteLine("Enter Oppo Mobile model  :");

                        InputOppoModelName = Console.ReadLine();

                        oppoObj.SetModels(InputOppoModelName);

                        Console.WriteLine("Oppo Mobile model is :" + InputOppoModelName);

                        break;

                    }

                case 2:
                    {
                        samsung samsungObj = new samsung();

                        string InputSamModelName = null;

                        Console.WriteLine("Enter Samsung Mobile model  :");

                        InputSamModelName = Console.ReadLine();

                        samsungObj.SetModels(InputSamModelName);

                        Console.WriteLine("Samsung Mobile model is :" + InputSamModelName);

                        break;
                    }

                case 3:
                    {
                        MobilePhoneModel mobilePhoneModelObj = new MobilePhoneModel(); 
                        
                        string InputMobilePhoneModelName = null;
                       
                        Console.WriteLine("Enter oppo and samsung Model :");
                        
                        InputMobilePhoneModelName = Console.ReadLine();

                        Console.WriteLine("oppo and samsung Model is :" + InputMobilePhoneModelName);

                        break;

                    }

                default :
                    {
                        Console.WriteLine("Invalid Input");
                    }

            }
            
        }
    }
}
