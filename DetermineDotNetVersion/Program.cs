// ***********************************************************************
// <copyright file="Program.cs" company="Schneider Electric Software, LLC">
//     Copyright (c) 2016, Schneider Electric Software, LLC, All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
// THIS CODE AND INFORMATION ARE PROVIDED "AS IS" WITHOUT WARRANTY OF ANY
// KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE
// IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
// PARTICULAR PURPOSE.
// ***********************************************************************

namespace DetermineDotNetVersion
{
    using System;

    /// <summary>
    /// The Program class is the entry of the application.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// The main of application.
        /// </summary>
        /// <param name="args">The parameter of main.</param>
        public static void Main(string[] args)
        {
            // Print the version of .net framework in the environment
            GetDotNetVersion.Get45PlusFromRegistry();
            ManualyCheckPrompt();
            Console.ReadKey();
        }

        /// <summary>
        /// Print the steps to check DotNet version manually.
        /// </summary>
        public static void ManualyCheckPrompt()
        {
            Console.WriteLine(string.Empty);
            Console.WriteLine("Manually Checking Steps:");
            Console.WriteLine("1. Open Registry Editor(regedit command).");
            Console.WriteLine(@"2. Locate to Software\Microsoft\NET Framework Setup\NDP\v4\Full subkey under HKEY_LOCAL_MACHINE");
            Console.WriteLine("3. Check value of Release keyword by Decimal, format should like 394271.");
            Console.WriteLine("4:.NET Framework 4.5 - 378389");
            Console.WriteLine("5:.NET Framework 4.5.1 installed with Windows 8.1 - 378675");
            Console.WriteLine("6:.NET Framework 4.5.1 installed on Windows 8, Windows 7 SP1, or Windows Vista SP2 - 378758");
            Console.WriteLine("7:.NET Framework 4.5.2 - 379893");
            Console.WriteLine("8:.NET Framework 4.6 installed with Windows 10 - 393295");
            Console.WriteLine("9:.NET Framework 4.6 installed on all other Windows OS versions - 393297");
            Console.WriteLine("10:.NET Framework 4.6.1 installed on Windows 10 - 394254");
            Console.WriteLine("11:.NET Framework 4.6.1 installed on all other Windows OS versions - 394271");
            Console.WriteLine("12:.NET Framework 4.6.2 installed on Windows 10 Anniversary Update - 394802");
            Console.WriteLine("13:.NET Framework 4.6.2 installed on all other Windows OS versions - 394806");
            Console.WriteLine("14:.NET Framework 4.7 installed on Windows 10 Creators Update - 460798");            
            Console.WriteLine("For more information. Please access https://msdn.microsoft.com/en-us/library/hh925568(v=vs.110).aspx.");
        }
    }
}
