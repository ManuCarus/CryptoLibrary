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
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml;

namespace CryptoLibrary.Controller
{
    public class Formatter
    {
        public static string BinaryToHex(byte[] data)
        {
            string dataHex = BitConverter.ToString(data).ToLower().Replace('-', ':');
            return dataHex;
        }

        public static byte[] HexToBinary(string dataHex)
        {
            dataHex = dataHex.Replace(":", "");
            byte[] rawData = HexadecimalStringToByteArray(dataHex);
            return rawData;
        }

        public static byte[] HexadecimalStringToByteArray(string hexadecimalString)
        {
            MemoryStream memoryStream = new MemoryStream(hexadecimalString.Length / 2);

            int pos = 0;
            while (pos < hexadecimalString.Length)
            {
                string hexadecimalDigits = hexadecimalString.Substring(pos, 2);
                byte hexadecimalContent = Byte.Parse(hexadecimalDigits, NumberStyles.HexNumber);
                memoryStream.WriteByte(hexadecimalContent);
                pos += 2;
            }

            byte[] data = memoryStream.ToArray();
            return data;
        }

        public static string FormatXmlKey(string xmlKey)
        {
            StringReader stringReader = null;
            XmlTextReader xmlTextReader = null;
            XmlWriter xmlWriter = null;
            StringBuilder formattedXml = new StringBuilder();

            try
            {
                stringReader = new StringReader(xmlKey);
                xmlTextReader = new XmlTextReader(stringReader);

                XmlWriterSettings xmlWriterSettings = new XmlWriterSettings();
                xmlWriterSettings.Indent = true;
                xmlWriterSettings.IndentChars = " ";

                xmlWriter = XmlWriter.Create(formattedXml, xmlWriterSettings);
                xmlWriter.WriteNode(xmlTextReader, false);
                xmlWriter.Flush();
            }
            finally
            {
                if (stringReader != null) stringReader.Close();
                if (xmlTextReader != null) xmlTextReader.Close();
                if (xmlWriter != null) xmlWriter.Close();
            }

            return formattedXml.ToString();
        }

    }
}
