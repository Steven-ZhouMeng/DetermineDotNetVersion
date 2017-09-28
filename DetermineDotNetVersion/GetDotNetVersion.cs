// ***********************************************************************
// <copyright file="GetDotNetVersion.cs" company="Schneider Electric Software, LLC">
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
    using Microsoft.Win32;

    /// <summary>
    /// The class to get DotNet framework version.
    /// </summary>
    public class GetDotNetVersion
    {
        /// <summary>
        /// Subkey of .Net Framework.
        /// </summary>
        private const string Subkey = @"SOFTWARE\Microsoft\NET Framework Setup\NDP\v4\Full\";

        /// <summary>
        /// Get value from registry.
        /// </summary>
        public static void Get45PlusFromRegistry()
        {
            using (RegistryKey ndpKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry32).OpenSubKey(Subkey))
            {
                if (ndpKey != null && ndpKey.GetValue("Release") != null)
                {
                    Console.WriteLine(".NET Framework Version: " + CheckFor45PlusVersion((int)ndpKey.GetValue("Release")));
                    if (ndpKey.GetValue("Version") != null)
                    {
                        Console.WriteLine(".NET Framework Full Version: " + ndpKey.GetValue("Version"));
                    }
                }
                else
                {
                    Console.WriteLine(".NET Framework Version 4.5 or later is not detected in current environment.");
                }
            }
        }

        /// <summary>
        /// Check DotNet framework version.
        /// </summary>
        /// <param name="releaseKey">The release key.</param>
        /// <returns>return DotNet framework version.</returns>
        private static string CheckFor45PlusVersion(int releaseKey)
        {
            // Checking the version using >= will enable forward compatibility.
            if (releaseKey >= 460798)
            {
                return "4.7 or later";
            }

            if (releaseKey >= 394802)
            {
                return "4.6.2";
            }

            if (releaseKey >= 394254)
            {
                return "4.6.1";
            }

            if (releaseKey >= 393295)
            {
                return "4.6";
            }

            if (releaseKey >= 379893)
            {
                return "4.5.2";
            }

            if (releaseKey >= 378675)
            {
                return "4.5.1";
            }

            if (releaseKey >= 378389)
            {
                return "4.5";
            }

            // This code should never execute. A non-null release key should mean that 4.5 or later is installed.
            return "No 4.5 or later version detected";
        }
    }
}