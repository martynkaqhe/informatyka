using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbe arabska od 1 do 999");
            string x = Console.ReadLine();
            Console.WriteLine(zamianaLiczb(x));
        }
        static string zamianaLiczb(string arabskie)
        {
            
            string rzymskie="";
            int lenght = arabskie.Length;
            switch (lenght)
            {
                case 1:
                    Char firstLetter = arabskie[0];
                    rzymskie+=oneToNine(firstLetter);
                    break;
                case 2:
                    Char firstNumber = arabskie[0];
                    Char secondNumber = arabskie[1];
                    rzymskie += tenToNinety(firstNumber, secondNumber);
                    break;
                case 3:
                    Char firstNumberx = arabskie[0];
                    Char secondNumberx = arabskie[1];
                    Char thirdNumber = arabskie[2];
                    rzymskie += hundreadToThousand(firstNumberx, secondNumberx,thirdNumber);
                    break;
                default:
                    Console.WriteLine("zła liczba");
                    break;

            }
            
            




            return rzymskie;
        }
        static string oneToNine(char letter)
        {
            String number = "";
            switch (letter)
            {
                case '1':
                    number += "I";
                    break;
                case '2':
                    number += "II";
                    break;
                case '3':
                    number += "III";
                    break;
                case '4':
                    number += "IV";
                    break;
                case '5':
                    number += "V";
                    break;
                case '6':
                    number += "VI";
                    break;
                case '7':
                    number += "VII";
                    break;
                case '8':
                    number += "VIII";
                    break;
                case '9':
                    number += "IX";
                    break;

                default:
                    
                    break;

            }
            return number ;
        }
        static string tenToNinety(char firstNumber, char secondNumber)
        {
            String number = "";
            switch (firstNumber)
            {
                
                case '1':
                    number += "X";
                    number += oneToNine(secondNumber);
                    break;
                case '2':
                    number += "XX";
                    number += oneToNine(secondNumber);
                    break;
                case '3':
                    number += "XXX";
                    number += oneToNine(secondNumber);
                    break;
                case '4':
                    number += "XL";
                    number += oneToNine(secondNumber);
                    break;
                case '5':
                    number += "L";
                    number += oneToNine(secondNumber);
                    break;
                case '6':
                    number += "LX";
                    number += oneToNine(secondNumber);
                    break;
                case '7':
                    number += "LXX";
                    number += oneToNine(secondNumber);
                    break;
                case '8':
                    number += "LXXX";
                    number += oneToNine(secondNumber);
                    break;
                case '9':
                    number += "XC";
                    number += oneToNine(secondNumber);
                    break;
                default:
                    
                    break;
            }
            return number;
        }
        static string hundreadToThousand(char firstNumber, char secondNumber,char thirdNumber)
        {
            String number = "";
            switch (firstNumber)
            {

                case '1':
                    number += "C";
                    number += tenToNinety(secondNumber, thirdNumber);

                    break;
                case '2':
                    number += "CC";
                    number += tenToNinety(secondNumber, thirdNumber);
                    break;
                case '3':
                    number += "CCC";
                    number += tenToNinety(secondNumber, thirdNumber);
                    break;
                case '4':
                    number += "CD";
                    number += tenToNinety(secondNumber, thirdNumber);
                    break;
                case '5':
                    number += "D";
                    number += tenToNinety(secondNumber, thirdNumber);
                    break;
                case '6':
                    number += "DC";
                    number += tenToNinety(secondNumber, thirdNumber);
                    break;
                case '7':
                    number += "DCC";
                    number += tenToNinety(secondNumber, thirdNumber);
                    break;
                case '8':
                    number += "DCCC";
                    number += tenToNinety(secondNumber, thirdNumber);
                    break;
                case '9':
                    number += "CM";
                    number += tenToNinety(secondNumber, thirdNumber);
                    break;
                default:

                    break;
            }
            return number;
        }
    }
}
