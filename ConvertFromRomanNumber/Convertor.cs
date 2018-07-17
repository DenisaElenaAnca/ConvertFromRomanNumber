using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertFromRomanNumberTest
{
   public class Convertor
    {
        static void Main(string[] args)
        {
            var crtPath = Directory.GetCurrentDirectory();
            Console.WriteLine(crtPath);
            var c = new Convertor();
            var v = c.directConvert("MMMDCCCLXXXVIII");//3888
            Console.WriteLine(v);
            Console.WriteLine(c.directConvert("MCMXCIV"));//1994
            Console.WriteLine(c.directConvert("MMXVIII"));//2018
            Console.WriteLine(c.directConvert("DCXXXIX"));//639
            Console.ReadLine();
        }

        public int directConvert(string rn)
        {
            if (string.IsNullOrEmpty(rn))
            {
                return 0;
            }
            int result = 0;
            for (int i = 0; i < rn.Length; i++)
            {
                switch (rn[i])
                {
                    case 'M':
                        result += 1000;
                        break;
                    case 'D':
                        result += 500;
                        break;
                    case 'C':
                        if (i + 1 < rn.Length && (rn[i + 1] == 'M' || rn[i + 1] == 'D'))
                        {
                            result -= 100;
                        }
                        else
                        {
                            result += 100;
                        }
                        break;
                    case 'L':
                        result += 50;
                        break;
                    case 'X':
                        if (i + 1 < rn.Length && (rn[i + 1] == 'C' || rn[i + 1] == 'L'))
                        {
                            result -= 10;
                        }
                        else
                        {
                            result += 10;
                        }
                        break;
                    case 'V':
                        result += 5;
                        break;
                    case 'I':
                        if (i + 1 < rn.Length && (rn[i + 1] == 'X' || rn[i + 1] == 'V'))
                        {
                            result -= 1;
                        }
                        else
                        {
                            result += 1;
                        }
                        break;
                    default:
                        break;
                }
            }
            return result;
        }

        string[] Split(string a)
        {
            string[] x = new string[4];
            if (a.Length == 0)
            {
                return x;
            }
            else
            {
                for (int i = 0; i < a.Length; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        if ((a[i] == 'M') && (x[1] == ""))
                        {
                            x[0] = x[0] + a[i];
                        }
                        else if ((a[i] == 'M') && (x[1] == "C"))
                        {
                            x[1] = x[1] + a[i];
                        }
                        else if ((a[i] == 'D') && (x[1] == ""))
                        {
                            x[1] = x[1] + a[i];
                        }
                        else if ((a[i] == 'D') && (x[1] == "C"))
                        {
                            x[1] = x[1] + a[i];
                        }                                            //end for D
                        else if ((a[i] == 'C') && (x[1] == ""))
                        {
                            x[1] = x[1] + a[i];
                        }
                        else if ((a[i] == 'C') && (x[1] == "D"))
                        {
                            x[1] = x[1] + a[i];
                        }



                        //if ((a[i] == "C") || (a[i] == "D"))
                        //{
                        //    x[j] = x[j] + a[i];
                        //}



                        //if ((a[i] == "C") || (a[i] == "D"))
                        //    for (int j = 1; j < a.Length; j++)
                        //    {

                        //    }
                    }



                    //    if (a.Contains("M"))
                    //    {
                    //        x[0] = a.Substring(0,a.LastIndexOf("M"));
                    //    }
                    //    if (a.Contains("D"))
                    //    {
                    //    x[1] = a.Substring(a.IndexOf("D"), a.LastIndexOf("D"));
                    //    }
                    //         if (a.Contains("L"))
                    //         {
                    //            x[1] = x[1] + a.Substring(a.IndexOf("D"), a.LastIndexOf("L"));
                    //         }

                    //if (a.Contains("L"))
                    //{
                    //    x[1] = a.Substring(a.IndexOf("L"), a.LastIndexOf("L"));
                    //}
                    //if (a.Contains("L"))
                    //{
                    //    x[1] = x[1] + a.Substring(a.IndexOf("D"), a.LastIndexOf("L"));
                    //}


                }



                return x;
            }
        }
    }
}
