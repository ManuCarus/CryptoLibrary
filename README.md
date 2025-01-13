# CryptoLibrary
CryptLibrary exposes security functionality to the programmer, such as random number generation, hashing, salted hashing, message authentication code, symmetric encryption, asymmetric encryption, hybrid encryption, digital signature and in-memory protection. The library is accompanied by a reference implementation for demo purposes.

For demo purposes
-----------------
Unzip the archive, navigate to

    CryptoLibrary/CryptoRefImpl/CryptoRefImpl/bin/debug
    
execute 

    CryptoRefImpl.exe

For developers
--------------
Unzip the archive, navigate to 

    CryptoLibrary/CryptoLibrary
    
open the Visual Studio Solution 

    CryptoLibrary.sln

You can easily import CryptoLibrary.dll from ./bin/Debug into your project. 

The usage of cryptographic algorithms via the encapsulated classes can easily be reviewed by the CryptoRefImpl classes.

Sample for CryptoLibrary.SymmetricController: 
see CryptoRefImpl.MainForm.SymmetricEncryption.cs

Secure Coding!
