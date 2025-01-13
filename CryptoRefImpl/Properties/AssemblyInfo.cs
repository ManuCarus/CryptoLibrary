/*
   CryptoRefImpl - demonstrates the use of safe cryptographic algorithms within the CryptoLibrary
   Copyright (c) 2012 Manu Carus (mailto:manu.carus@ethical-hacking.de)

   This reference implementation demonstrates how to make use of the CryptoLibrary. 
   CryptoLibrary exposes security functionality to the programmer, such as random number generation, hashing,
   salted hashing, message authentication code, symmetric encryption, asymmetric encryption, hybrid encryption,
   digital signature and in-memory protection.
 
   This program is free software; you can redistribute it and/or modify it under the terms of 
   the GNU General Public License as published by the Free Software Foundation; 
   either version 3 of the License, or (at your option) any later version.

   This program is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
   without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. 
   See the GNU General Public License for more details.

   You should have received a copy of the GNU General Public License along with this program; 
   if not, see <http://www.gnu.org/licenses/>.
*/

using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[assembly: AssemblyCompany("Manu Carus")]
[assembly: AssemblyTitle("CryptoRefImpl")]
[assembly: AssemblyProduct("CryptoRefImpl")]
[assembly: AssemblyCopyright("Copyright (c) 2012 Manu Carus (mailto:manu.carus@ethical-hacking.de)")]

[assembly: AssemblyDescription("This reference implementation demonstrates how to make use of the CryptoLibrary. " + 
                               "CryptoLibrary exposes security functionality to the programmer, such as random number generation, hashing, " +
                               "salted hashing, message authentication code, symmetric encryption, asymmetric encryption, hybrid encryption, " +
                               "digital signature and in-memory protection.")]

[assembly: AssemblyTrademark("Copyright (c) 2012 Manu Carus (mailto:manu.carus@ethical-hacking.de) " +
                             "This program is free software; you can redistribute it and/or modify it under the terms of " +
                             "the GNU General Public License as published by the Free Software Foundation; " +
                             "either version 3 of the License, or (at your option) any later version. " +

                             "This program is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; " +
                             "without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. " +
                             "See the GNU General Public License for more details." +

                             "You should have received a copy of the GNU General Public License along with this program; " +
                            "if not, see <http://www.gnu.org/licenses/>. ")]

[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyFileVersion("1.0.0.0")]

[assembly: CLSCompliant(true)]
[assembly: ComVisible(false)]
