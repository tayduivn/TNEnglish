using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TN.Core.Control
{
    public class StringControl
    {
        public static string ToHyphen(string str, int n)
        {
            var s = new StringBuilder(str);
            int ran, ran2, ran3;
            if (s.Length >= 5)
            {
                if(n==2)
                n = new Random().Next(2, 3);
                else
                {
                    n = new Random().Next(2, n+1);
                    
                }
                ran = new Random().Next(0, s.Length);
                if (n == 2)
                {
                    do
                    {
                        ran2 = new Random().Next(0, s.Length);
                    } while (ran == ran2);
                    s.Replace(s[ran], '-');
                    s.Replace(s[ran2], '-');
                }
                else if(n ==3)
                {

                    do
                    {
                        ran2 = new Random().Next(0, s.Length );
                        ran3 = new Random().Next(0, s.Length);
                    } while (ran == ran2 || ran == ran3 || ran2 == ran3);
                    s.Replace(s[ran], '-');
                    s.Replace(s[ran2], '-');
                    s.Replace(s[ran3], '-');

                }
                else
                {
                    int ran4;
                    do
                    {
                        ran2 = new Random().Next(0, s.Length );
                        ran3 = new Random().Next(0, s.Length );
                        ran4 = new Random().Next(0, s.Length);
                    } while (ran == ran2 || ran == ran3 || ran2 == ran3 || ran == ran4|| ran2==ran4||ran3==ran4);
                    s.Replace(s[ran], '-');
                    s.Replace(s[ran2], '-');
                    s.Replace(s[ran3], '-');
                    s.Replace(s[ran4], '-');

                }
            }else if (s.Length > 3)
            {
               


                ran = new Random().Next(0, s.Length);
                if (n == 2)
                {
                    do
                    {
                        ran2 = new Random().Next(0, s.Length );
                    } while (ran == ran2);
                    s.Replace(s[ran], '-');
                    s.Replace(s[ran2], '-');
                }
                else
                {
                    
                        do
                        {
                            ran2 = new Random().Next(0, s.Length );
                            ran3 = new Random().Next(0, s.Length );
                        } while (ran == ran2 || ran == ran3 || ran2 == ran3);
                        s.Replace(s[ran], '-');
                        s.Replace(s[ran2], '-');
                        s.Replace(s[ran3], '-');
                    
                }
            }
            else if(str.Length <= 3)
            {

                n = new Random().Next(2, n + 1);


                ran = new Random().Next(0, s.Length);
                if (n <= 2)
                {
                    s.Replace(s[ran], '-');
                }
                else 
                {
                    do
                    {
                        ran2 = new Random().Next(0, s.Length);
                    } while (ran == ran2);
                    s.Replace(s[ran], '-');
                    s.Replace(s[ran2], '-');
                }
               
            }
           
            return s.ToString();
        }

        public static string ToHyphen(string str,bool check)
        {
            string re = "";
            if (check)
            {
                int ran, ran2;
                if (str.Length > 2)
                {
                    ran = new Random().Next(0, str.Length - 1);
                    var c = str.Substring(ran,1);
                    if (str.Length >= 3 && str.Length <= 6)
                    {
                        for (var i = 0; i < str.Length; i++)
                        {
                            if (i == ran)
                            {
                                re += c;
                            }
                            else
                            {
                                re += "-";
                            }
                        }
                    }
                    else if (str.Length > 6)
                    {

                        int n = new Random().Next(0, 1);
                        if (n == 1)
                        {
                            do
                            {
                                ran2 = new Random().Next(0, str.Length - 1);
                            } while (ran == ran2);
                            var b = str.Substring(ran2, 1);
                            for (var i = 0; i < str.Length; i++)
                            {

                                if (i == ran)
                                {
                                    re += c;
                                }
                                else if (i == ran2)
                                    re += b;
                                else
                                {
                                    re += "-";
                                }
                            }
                        }
                        else
                        {
                            for (var i = 0; i < str.Length; i++)
                            {

                                if (i == ran)
                                {
                                    re += c;
                                }
                                else
                                {
                                    re += "-";
                                }
                            }
                        }
                    }
                }
                else
                {

                    for (var i = 0; i < str.Length; i++)
                    {
                        re += "-";
                    }
                }
           
           
            }
            else
            {
                for (var i = 0; i < str.Length; i++)
                {
                    re += "-";
                }
            }
           


            return re;
        }
    }
}
