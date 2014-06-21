//
// Copyright © 2005 - 2007 Maksim Goleta. All rights reserved.
// GOLETAS PROPRIETARY/CONFIDENTIAL. Use is subject to license terms.
//

//
// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
//

using System;
using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices;
using System.Security.Permissions;

[assembly: AssemblyTitle("Goletas.Collections")]
[assembly: AssemblyProduct("Goletas.Collections")]
[assembly: AssemblyDescription("http://goletas.com")]
[assembly: AssemblyCompany("Maksim Goleta")]
[assembly: AssemblyCopyright("Copyright © 2005 - 2007 Maksim Goleta. All rights reserved.")]
[assembly: AssemblyTrademark("Goletas and the Goletas logo are either registered trademarks or trademarks of Goletas software laboratory in the United States and/or other countries.")]
[assembly: ComVisible(false)]
[assembly: CLSCompliant(true)]

[assembly: SecurityPermission(SecurityAction.RequestMinimum)]


// InternalsVisibleTo

//
// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Revision and Build Numbers 
// by using the '*' as shown below:

[assembly: AssemblyVersion("2007.11.27.*")]

//
// In order to sign your assembly you must specify a key to use. Refer to the 
// Microsoft .NET Framework documentation for more information on assembly signing.
//
// Use the attributes below to control which key is used for signing. 
//
// Notes: 
//   (*) If no key is specified, the assembly is not signed.
//   (*) KeyName refers to a key that has been installed in the Crypto Service
//       Provider (CSP) on your machine. KeyFile refers to a file which contains
//       a key.
//   (*) If the KeyFile and the KeyName values are both specified, the 
//       following processing occurs:
//       (1) If the KeyName can be found in the CSP, that key is used.
//       (2) If the KeyName does not exist and the KeyFile does exist, the key 
//           in the KeyFile is installed into the CSP and used.
//   (*) In order to create a KeyFile, you can use the sn.exe (Strong Name) utility.
//       When specifying the KeyFile, the location of the KeyFile should be
//       relative to the project output directory which is
//       %Project Directory%\obj\<configuration>. For example, if your KeyFile is
//       located in the project directory, you would specify the AssemblyKeyFile 
//       attribute as [assembly: AssemblyKeyFile("..\\..\\mykey.snk")]
//   (*) Delay Signing is an advanced option - see the Microsoft .NET Framework
//       documentation for more information on this.
//

// [assembly: System.Reflection.AssemblyDelaySign(false)]
// [assembly: System.Reflection.AssemblyKeyFile("..\\..\\AssemblyKey.snk")]
// [assembly: System.Reflection.AssemblyKeyName("")]