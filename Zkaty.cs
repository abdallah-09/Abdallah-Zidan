using System;

public class Zkaty
{
    public static void Main(string[] args) // main metod
    {
        // creating variable
        int typee;
        double crops; 
        double cach;
        double silver;
        double gold=75938; //gold price
        int typefc; 
        double Ma; //manully
        double ra; // rain
        double km; //manully crops
        double kr; //rains crops
        float result;


      
        
        Console.WriteLine("\t\tZKATY");// output massage
        Console.WriteLine("\ttypes"); // output massage
        Console.WriteLine("press 1 for crops"); // output massage
        Console.WriteLine("press 2 for cach"); // output massage
        Console.WriteLine("press 3 for silver or gold "); // output massage
    loop1: // creating loop
        Console.Write("\nwhat is your type?    "); // aske user to input the type he asked for
        typee=Convert.ToInt32(Console.ReadLine()); // save the data in a variable
        if (typee==1) // if condition
                   {
                    
                    Console.WriteLine("If you water it by Rains press 1 ");// output massage
                    Console.WriteLine("If you water it  Manully press 2 ");// output massage
                    Console.Write("How do you water it?       ");// aske user to input the type of how he water it
                    typefc=Convert.ToInt32(Console.ReadLine()); // save the data in a variable
                         if(typefc==1) // if condition
                        {
                         
                          Console.Write("how many kilos do you have?  "); // aske user to input the amount of crops
                          kr=Convert.ToInt32(Console.ReadLine()); // save the data in a variable
                          if (kr<612)
                             {
                             Console.WriteLine("You dont have to pay Zakah");// output massage
                             goto loop1; // back to the loop to use the program again
                             }else
                             {
                                result=(float)(10/kr*100) ; //mathematical operation
                                Console.WriteLine("10/{0}*100={1}",kr,result); // output massage
                                goto loop1;// back to the loop to use the program again
                             }
                             }else if (typefc==2)
                              {
                              
                               Console.Write("how many kilos do you have?    "); // aske user to input the amount of crops
                               km=Convert.ToInt32(Console.ReadLine());// save the data in a variable
                               goto loop1;// back to the loop to use the program again
                             if (km<612)
                              {
                              Console.WriteLine("You dont have to pay Zakah");// output massage
                              goto loop1;// back to the loop to use the program again
                             }else
                                 {
                              result=(float)(5/km*100) ; //mathematical operation
                              Console.WriteLine("5/{0}*100={1}",km,result);// output massage
                              goto loop1;// back to the loop to use the program again
                            }
                              }

        } else if(typee==2)
                         {
                           Console.WriteLine("*note* cach must be more than {0} ",gold);// output massage
                           Console.Write("How much do you have?     ");// aske user to input how much does he have
                           cach=Convert.ToInt32(Console.ReadLine());// save the data in a variable
                           if (cach<gold)
                            {
                             Console.WriteLine("You dont have to pay Zakah");// output massage
                             goto loop1;// back to the loop to use the program again
                            }else
                                 {
                                   result=(float)(cach/gold*100); //mathematical operation
                                   Console.WriteLine("{0}/{1}*100={2}",cach,gold,result);// output massage
                                   goto loop1;// back to the loop to use the program again
                                 }
            
        }else if (typee==3)
                        {
                            Console.Write("How many grams do you have?       "); // aske user to input how much does he have
                            silver=Convert.ToInt32(Console.ReadLine());// save the data in a variable
                            if (silver<gold)
                        {
                           Console.WriteLine("You dont have to pay Zakah");// output massage
                           goto loop1;// back to the loop to use the program again
                              }
                                 else
                                       {
                                         result=(float)(silver/gold*100); //mathematical operation
                                          Console.WriteLine("{0}/{1}*100={2}",silver,gold,result);// output massage
                                          goto loop1;// back to the loop to use the program again
                                           }
             
        }  else
               { 
                 Console.WriteLine("\n\n\t ERROR ... please try agin"); // output massage
                 
                 goto loop1;// back to the loop to use the program again
            
                 Console.Read();
                }
    }
}
