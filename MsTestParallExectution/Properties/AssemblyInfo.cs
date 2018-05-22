using System.Reflection;
using System.Runtime.InteropServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;

[assembly: AssemblyTitle("MsTestParallExectution")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("EPAM Systems")]
[assembly: AssemblyProduct("MsTestParallExectution")]
[assembly: AssemblyCopyright("Copyright © EPAM Systems 2018")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

[assembly: ComVisible(false)]

[assembly: Guid("c2ecce79-66d4-474e-bb78-ad2408dd0fb0")]

// [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyFileVersion("1.0.0.0")]
[assembly: Parallelize(Workers = 4, Scope = ExecutionScope.MethodLevel)]