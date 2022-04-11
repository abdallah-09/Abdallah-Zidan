using System;

public class Zkaty
{
    public static void Main(string[] args)
    {
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


      
        
        Console.WriteLine("\t\tZKATY");
        Console.WriteLine("\ttypes");
        Console.WriteLine("press 1 for crops");
        Console.WriteLine("press 2 for cach");
        Console.WriteLine("press 3 for silver or gold ");
    loop1:
        Console.Write("\nwhat is your type?    ");
        typee=Convert.ToInt32(Console.ReadLine());
        if (typee==1)
                   {
                    
                    Console.WriteLine("If you water it by Rains press 1 ");
                    Console.WriteLine("If you water it  Manully press 2 ");
                    Console.Write("How do you water it?       ");
                    typefc=Convert.ToInt32(Console.ReadLine());
                         if(typefc==1)
                        {
                         
                          Console.Write("how many kilos do you have?  ");
                          kr=Convert.ToInt32(Console.ReadLine());
                          if (kr<612)
                             {
                             Console.WriteLine("You dont have to pay Zakah");
                             goto loop1;
                             }else
                             {
                                result=(float)(10/kr*100) ;
                                Console.WriteLine("10/{0}*100={1}",kr,result);
                                goto loop1;
                             }
                             }else if (typefc==2)
                              {
                              
                               Console.Write("how many kilos do you have?    ");
                               km=Convert.ToInt32(Console.ReadLine());
                               goto loop1;
                             if (km<612)
                              {
                              Console.WriteLine("You dont have to pay Zakah");
                              goto loop1;
                             }else
                                 {
                              result=(float)(5/km*100) ;
                              Console.WriteLine("5/{0}*100={1}",km,result);
                              goto loop1;
                            }
                              }

        } else if(typee==2)
                         {
                           Console.WriteLine("*note* cach must be more than {0} ",gold);
                           Console.Write("How much do you have?     ");
                           cach=Convert.ToInt32(Console.ReadLine());
                           if (cach<gold)
                            {
                             Console.WriteLine("You dont have to pay Zakah");
                             goto loop1;
                            }else
                                 {
                                   result=(float)(cach/gold*100);
                                   Console.WriteLine("{0}/{1}*100={2}",cach,gold,result);
                                   goto loop1;
                                 }
            
        }else if (typee==3)
                        {
                            Console.Write("How many grams do you have?       ");
                            silver=Convert.ToInt32(Console.ReadLine());
                            if (silver<gold)
                        {
                           Console.WriteLine("You dont have to pay Zakah");
                           goto loop1;
                              }
                                 else
                                       {
                                         result=(float)(silver/gold*100);
                                          Console.WriteLine("{0}/{1}*100={2}",silver,gold,result);
                                          goto loop1;
                                           }
             
        }  else
               { 
                 Console.WriteLine("\n\n\t ERROR ... please try agin"); 
                 
                 goto loop1;
            
                 Console.Read();
                }
    }
}
