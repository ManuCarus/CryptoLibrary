/*
   CryptoLibrary - implements safe cryptographic algorithms and encapsulates classes for easy use.
   Copyright (c) 2012 Manu Carus (mailto:manu.carus@ethical-hacking.de)

   This library exposes security functionality to the programmer, such as random number generation, hashing, 
   salted hashing, message authentication code, symmetric encryption, asymmetric encryption, hybrid encryption, 
   digital signature and in-memory protection. The library is accompanied by a sophisticated reference implementation, 
   that demonstrates how to make use of the CryptoLibrary.

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
using System.Text;

namespace CryptoLibrary.Controller
{
    public class EncodingController
    {
        // default encoding
        public static string cDefaultEncoding = "Default";

        // mapping
        public static Encoding GetEncodingByName(string encodingName)
        {
            Encoding encoding = null;
            if (encodingName.Equals(cDefaultEncoding)) encoding = Encoding.Default;
            else encoding = Encoding.GetEncoding(encodingName);

            return encoding;
        }
    }
}
