// QSHA256 v1.0 (c) 2022 Sensei (aka 'Q')
// Reads stdin and returns SHA256 hash.
//
// Alternative to: certutil -hashfile <file> SHA256
//
// Usage:
// QSHA256 <text.txt
// QSHA256 <index.html >sha256.txt
//
// Compilation:
// %SYSTEMROOT%\Microsoft.NET\Framework\v3.5\csc QSHA256.cs

using System;
using System.IO;
using System.Security.Cryptography;

public static class QSHA256 {
  public static void Main( string [] args ) {
     Stream source = Console.OpenStandardInput();
     System.Security.Cryptography.SHA256 sha256 = System.Security.Cryptography.SHA256.Create();
     byte [] result = sha256.ComputeHash( source );
     if( result != null ) {
       for( int i = 0; i < result.Length; i++ ) {
          Console.Write( "{0:X2}", result[i] );
       }
       Console.WriteLine();
     }
  }
}
