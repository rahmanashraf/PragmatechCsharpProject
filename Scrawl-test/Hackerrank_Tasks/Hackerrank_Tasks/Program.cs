using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

namespace Hackerrank_Tasks
{

    internal class Program
    {
        static void Main(string[] args)
        {
            //string alpha = "abcdefghijklmnopqrstuvwxyz";
            string s = "Serhan";
            int x = 3;
            int upperstart = 65;
            int upperend = 90;
            int lowerstart = 97;
            int lowerend = 122;


            //char a = Convert.ToChar(lowerend);
            string tazasoz = String.Empty;

            for (int i = 0; i < s.Length; i++)
            {
                for (int upperchar = upperstart; upperchar < upperend; upperchar++)
                {
                    if (Convert.ToChar(upperchar)==s[i])
                    {
                        tazasoz += Convert.ToChar(upperchar+x);
                    }

                }
                for (int lowerchar = lowerstart; lowerchar < lowerend; lowerchar++)
                {
                    if (Convert.ToChar(lowerchar) == s[i])
                    {
                        tazasoz += Convert.ToChar(lowerchar + x);
                    }
                }
            }

            

            Console.WriteLine(tazasoz);
            Console.ReadLine();

        }
    }
}
