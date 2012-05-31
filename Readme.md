About this project
===
The objective of this project is to plug the gaps in behaviour between the old .NET Reflection API and the new API
included in WinRT. Whilst it's possible to get most of the information out of the WinRT API, a number of important
methods have not been included.

The structure of the API is a set of extension methods on Type. 

The caveat to using it is that there are a number of missing properties on the various types. These have been replaced
with methods. Therefore for compatibility, you have to change the originating library to use a "reverse shim" that
maps the methods to a property. These can be found in the ReverseTypeExtender type.

This project is structured as two separate solutions - one for .NET 3.5 and one for WinRT - the idea being that
we can confirm the same test suite performs identically against the shim and against the original API.

Using this project
---
Copy the TypeExtender.cs project into your assembly and compile.
