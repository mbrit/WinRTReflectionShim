//
// WinRT Reflector Shim - a library to assist in porting frameworks from .NET to WinRT.
//
// Copyright (c) 2012 Matthew Baxter-Reynolds 2012 (@mbrit)
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace System.Reflection.Tests
{
	[TestClass]
	public class TypeExtenderTests
	{
		[TestMethod]
		public void TestGetMethodDefaultFlagsPublicInstance()
		{
			// default flags should return public instance and public static...
			Assert.IsNotNull(typeof(TypeExtenderFoo).GetMethod("PublicInstanceMethod"));
		}

		[TestMethod]
		public void TestGetMethodDefaultFlagsPublicStatic()
		{
			Assert.IsNotNull(typeof(TypeExtenderFoo).GetMethod("PublicStaticMethod"));
		}

		[TestMethod]
		public void TestGetMethodDefaultFlagsProtectedInstance()
		{
			Assert.IsNull(typeof(TypeExtenderFoo).GetMethod("ProtectedInstanceMethod"));
		}

		[TestMethod]
		public void TestGetMethodDefaultFlagsPrivateInstance()
		{
			Assert.IsNull(typeof(TypeExtenderFoo).GetMethod("PrivateInstanceMethod"));
		}

		[TestMethod]
		public void TestGetMethodDefaultFlagsProtectedStatic()
		{
			Assert.IsNull(typeof(TypeExtenderFoo).GetMethod("ProtectedStaticMethod"));
		}

		[TestMethod]
		public void TestGetMethodDefaultFlagsPrivateStatic()
		{
			Assert.IsNull(typeof(TypeExtenderFoo).GetMethod("PrivateStaticMethod"));
		}

		[TestMethod]
		public void TestGetPropertyDefaultFlagsPublicInstance()
		{
			// default flags should return public instance and public static...
			Assert.IsNotNull(typeof(TypeExtenderFoo).GetProperty("PublicInstanceProperty"));
		}

		[TestMethod]
		public void TestGetPropertyDefaultFlagsPublicStatic()
		{
			Assert.IsNotNull(typeof(TypeExtenderFoo).GetProperty("PublicStaticProperty"));
		}

		[TestMethod]
		public void TestGetPropertyDefaultFlagsProtectedInstance()
		{
			Assert.IsNull(typeof(TypeExtenderFoo).GetProperty("ProtectedInstanceProperty"));
		}

		[TestMethod]
		public void TestGetPropertyDefaultFlagsPrivateInstance()
		{
			Assert.IsNull(typeof(TypeExtenderFoo).GetProperty("PrivateInstanceProperty"));
		}

		[TestMethod]
		public void TestGetPropertyDefaultFlagsProtectedStatic()
		{
			Assert.IsNull(typeof(TypeExtenderFoo).GetProperty("ProtectedStaticProperty"));
		}

		[TestMethod]
		public void TestGetPropertyDefaultFlagsPrivateStatic()
		{
			Assert.IsNull(typeof(TypeExtenderFoo).GetProperty("PrivateStaticProperty"));
		}

		[TestMethod]
		public void TestGetFieldDefaultFlagsPublicInstance()
		{
			// default flags should return public instance and public static...
			Assert.IsNotNull(typeof(TypeExtenderFoo).GetField("PublicInstanceField"));
		}

		[TestMethod]
		public void TestGetFieldDefaultFlagsPublicStatic()
		{
			Assert.IsNotNull(typeof(TypeExtenderFoo).GetField("PublicStaticField"));
		}

		[TestMethod]
		public void TestGetFieldDefaultFlagsProtectedInstance()
		{
			Assert.IsNull(typeof(TypeExtenderFoo).GetField("ProtectedInstanceField"));
		}

		[TestMethod]
		public void TestGetFieldDefaultFlagsPrivateInstance()
		{
			Assert.IsNull(typeof(TypeExtenderFoo).GetField("PrivateInstanceField"));
		}

		[TestMethod]
		public void TestGetFieldDefaultFlagsProtectedStatic()
		{
			Assert.IsNull(typeof(TypeExtenderFoo).GetField("ProtectedStaticField"));
		}

		[TestMethod]
		public void TestGetFieldDefaultFlagsPrivateStatic()
		{
			Assert.IsNull(typeof(TypeExtenderFoo).GetField("PrivateStaticField"));
		}

		[TestMethod]
		public void TestGetEventDefaultFlagsPublicInstance()
		{
			// default flags should return public instance and public static...
			Assert.IsNotNull(typeof(TypeExtenderFoo).GetEvent("PublicInstanceEvent"));
		}

		[TestMethod]
		public void TestGetEventDefaultFlagsPublicStatic()
		{
			Assert.IsNotNull(typeof(TypeExtenderFoo).GetEvent("PublicStaticEvent"));
		}

		[TestMethod]
		public void TestGetEventDefaultFlagsProtectedInstance()
		{
			Assert.IsNull(typeof(TypeExtenderFoo).GetEvent("ProtectedInstanceEvent"));
		}

		[TestMethod]
		public void TestGetEventDefaultFlagsPrivateInstance()
		{
			Assert.IsNull(typeof(TypeExtenderFoo).GetEvent("PrivateInstanceEvent"));
		}

		[TestMethod]
		public void TestGetEventDefaultFlagsProtectedStatic()
		{
			Assert.IsNull(typeof(TypeExtenderFoo).GetEvent("ProtectedStaticEvent"));
		}

		[TestMethod]
		public void TestGetEventDefaultFlagsPrivateStatic()
		{
			Assert.IsNull(typeof(TypeExtenderFoo).GetEvent("PrivateStaticEvent"));
		}

		[TestMethod]
		public void TestGetPublicInstanceMethod()
		{
			Assert.IsNotNull(typeof(TypeExtenderFoo).GetMethod("PublicInstanceMethod", BindingFlags.Public | BindingFlags.Instance));
		}

		[TestMethod]
		public void TestGetProtectedInstanceMethod()
		{
			Assert.IsNotNull(typeof(TypeExtenderFoo).GetMethod("ProtectedInstanceMethod", BindingFlags.NonPublic | BindingFlags.Instance));
		}

		[TestMethod]
		public void TestGetPrivateInstanceMethod()
		{
			Assert.IsNotNull(typeof(TypeExtenderFoo).GetMethod("PrivateInstanceMethod", BindingFlags.NonPublic | BindingFlags.Instance));
		}

		[TestMethod]
		public void TestGetPublicInstanceMethodDoesntMatchStatic()
		{
			Assert.IsNull(typeof(TypeExtenderFoo).GetMethod("PublicInstanceMethod", BindingFlags.Public | BindingFlags.Static));
		}

		[TestMethod]
		public void TestGetProtectedInstanceMethodDoesntMatchStatic()
		{
			Assert.IsNull(typeof(TypeExtenderFoo).GetMethod("ProtectedInstanceMethod", BindingFlags.NonPublic | BindingFlags.Static));
		}

		[TestMethod]
		public void TestGetPrivateInstanceMethodDoesntMatchStatic()
		{
			Assert.IsNull(typeof(TypeExtenderFoo).GetMethod("PrivateInstanceMethod", BindingFlags.NonPublic | BindingFlags.Static));
		}

		[TestMethod]
		public void TestGetPublicStaticMethod()
		{
			Assert.IsNotNull(typeof(TypeExtenderFoo).GetMethod("PublicStaticMethod", BindingFlags.Public | BindingFlags.Static));
		}

		[TestMethod]
		public void TestGetProtectedStaticMethod()
		{
			Assert.IsNotNull(typeof(TypeExtenderFoo).GetMethod("ProtectedStaticMethod", BindingFlags.NonPublic | BindingFlags.Static));
		}

		[TestMethod]
		public void TestGetPrivateStaticMethod()
		{
			Assert.IsNotNull(typeof(TypeExtenderFoo).GetMethod("PrivateStaticMethod", BindingFlags.NonPublic | BindingFlags.Static));
		}

		[TestMethod]
		public void TestGetPublicStaticMethodDoesntMatchStatice()
		{
			Assert.IsNull(typeof(TypeExtenderFoo).GetMethod("PublicStaticMethod", BindingFlags.Public | BindingFlags.Instance));
		}

		[TestMethod]
		public void TestGetProtectedStaticMethodDoesntMatchStatice()
		{
			Assert.IsNull(typeof(TypeExtenderFoo).GetMethod("ProtectedStaticMethod", BindingFlags.NonPublic | BindingFlags.Instance));
		}

		[TestMethod]
		public void TestGetPrivateStaticMethodDoesntMatchStatice()
		{
			Assert.IsNull(typeof(TypeExtenderFoo).GetMethod("PrivateStaticMethod", BindingFlags.NonPublic | BindingFlags.Instance));
		}

		[TestMethod]
		public void TestGetPublicInstanceProperty()
		{
			Assert.IsNotNull(typeof(TypeExtenderFoo).GetProperty("PublicInstanceProperty", BindingFlags.Public | BindingFlags.Instance));
		}

		[TestMethod]
		public void TestGetProtectedInstanceProperty()
		{
			Assert.IsNotNull(typeof(TypeExtenderFoo).GetProperty("ProtectedInstanceProperty", BindingFlags.NonPublic | BindingFlags.Instance));
		}

		[TestMethod]
		public void TestGetPrivateInstanceProperty()
		{
			Assert.IsNotNull(typeof(TypeExtenderFoo).GetProperty("PrivateInstanceProperty", BindingFlags.NonPublic | BindingFlags.Instance));
		}

		[TestMethod]
		public void TestGetPublicInstancePropertyDoesntMatchStatic()
		{
			Assert.IsNull(typeof(TypeExtenderFoo).GetProperty("PublicInstanceProperty", BindingFlags.Public | BindingFlags.Static));
		}

		[TestMethod]
		public void TestGetProtectedInstancePropertyDoesntMatchStatic()
		{
			Assert.IsNull(typeof(TypeExtenderFoo).GetProperty("ProtectedInstanceProperty", BindingFlags.NonPublic | BindingFlags.Static));
		}

		[TestMethod]
		public void TestGetPrivateInstancePropertyDoesntMatchStatic()
		{
			Assert.IsNull(typeof(TypeExtenderFoo).GetProperty("PrivateInstanceProperty", BindingFlags.NonPublic | BindingFlags.Static));
		}

		[TestMethod]
		public void TestGetPublicStaticProperty()
		{
			Assert.IsNotNull(typeof(TypeExtenderFoo).GetProperty("PublicStaticProperty", BindingFlags.Public | BindingFlags.Static));
		}

		[TestMethod]
		public void TestGetProtectedStaticProperty()
		{
			Assert.IsNotNull(typeof(TypeExtenderFoo).GetProperty("ProtectedStaticProperty", BindingFlags.NonPublic | BindingFlags.Static));
		}

		[TestMethod]
		public void TestGetPrivateStaticProperty()
		{
			Assert.IsNotNull(typeof(TypeExtenderFoo).GetProperty("PrivateStaticProperty", BindingFlags.NonPublic | BindingFlags.Static));
		}

		[TestMethod]
		public void TestGetPublicStaticPropertyDoesntMatchInstance()
		{
			Assert.IsNull(typeof(TypeExtenderFoo).GetProperty("PublicStaticProperty", BindingFlags.Public | BindingFlags.Instance));
		}

		[TestMethod]
		public void TestGetProtectedStaticPropertyDoesntMatchInstance()
		{
			Assert.IsNull(typeof(TypeExtenderFoo).GetProperty("ProtectedStaticProperty", BindingFlags.NonPublic | BindingFlags.Instance));
		}

		[TestMethod]
		public void TestGetPrivateStaticPropertyDoesntMatchInstance()
		{
			Assert.IsNull(typeof(TypeExtenderFoo).GetProperty("PrivateStaticProperty", BindingFlags.NonPublic | BindingFlags.Instance));
		}

		[TestMethod]
		public void TestGetPublicInstanceField()
		{
			Assert.IsNotNull(typeof(TypeExtenderFoo).GetField("PublicInstanceField", BindingFlags.Public | BindingFlags.Instance));
		}

		[TestMethod]
		public void TestGetProtectedInstanceField()
		{
			Assert.IsNotNull(typeof(TypeExtenderFoo).GetField("ProtectedInstanceField", BindingFlags.NonPublic | BindingFlags.Instance));
		}

		[TestMethod]
		public void TestGetPrivateInstanceField()
		{
			Assert.IsNotNull(typeof(TypeExtenderFoo).GetField("PrivateInstanceField", BindingFlags.NonPublic | BindingFlags.Instance));
		}

		[TestMethod]
		public void TestGetPublicInstanceFieldDoesntMatchStatic()
		{
			Assert.IsNull(typeof(TypeExtenderFoo).GetField("PublicInstanceField", BindingFlags.Public | BindingFlags.Static));
		}

		[TestMethod]
		public void TestGetProtectedInstanceFieldDoesntMatchStatic()
		{
			Assert.IsNull(typeof(TypeExtenderFoo).GetField("ProtectedInstanceField", BindingFlags.NonPublic | BindingFlags.Static));
		}

		[TestMethod]
		public void TestGetPrivateInstanceFieldDoesntMatchStatic()
		{
			Assert.IsNull(typeof(TypeExtenderFoo).GetField("PrivateInstanceField", BindingFlags.NonPublic | BindingFlags.Static));
		}

		[TestMethod]
		public void TestGetPublicStaticField()
		{
			Assert.IsNotNull(typeof(TypeExtenderFoo).GetField("PublicStaticField", BindingFlags.Public | BindingFlags.Static));
		}

		[TestMethod]
		public void TestGetProtectedStaticField()
		{
			Assert.IsNotNull(typeof(TypeExtenderFoo).GetField("ProtectedStaticField", BindingFlags.NonPublic | BindingFlags.Static));
		}

		[TestMethod]
		public void TestGetPrivateStaticField()
		{
			Assert.IsNotNull(typeof(TypeExtenderFoo).GetField("PrivateStaticField", BindingFlags.NonPublic | BindingFlags.Static));
		}

		[TestMethod]
		public void TestGetPublicStaticFieldDoesntMatchInstance()
		{
			Assert.IsNull(typeof(TypeExtenderFoo).GetField("PublicStaticField", BindingFlags.Public | BindingFlags.Instance));
		}

		[TestMethod]
		public void TestGetProtectedStaticFieldDoesntMatchInstance()
		{
			Assert.IsNull(typeof(TypeExtenderFoo).GetField("ProtectedStaticField", BindingFlags.NonPublic | BindingFlags.Instance));
		}

		[TestMethod]
		public void TestGetPrivateStaticFieldDoesntMatchInstance()
		{
			Assert.IsNull(typeof(TypeExtenderFoo).GetField("PrivateStaticField", BindingFlags.NonPublic | BindingFlags.Instance));
		}

		[TestMethod]
		public void TestGetPublicInstanceEvent()
		{
			Assert.IsNotNull(typeof(TypeExtenderFoo).GetEvent("PublicInstanceEvent", BindingFlags.Public | BindingFlags.Instance));
		}

		[TestMethod]
		public void TestGetProtectedInstanceEvent()
		{
			Assert.IsNotNull(typeof(TypeExtenderFoo).GetEvent("ProtectedInstanceEvent", BindingFlags.NonPublic | BindingFlags.Instance));
		}

		[TestMethod]
		public void TestGetPrivateInstanceEvent()
		{
			Assert.IsNotNull(typeof(TypeExtenderFoo).GetEvent("PrivateInstanceEvent", BindingFlags.NonPublic | BindingFlags.Instance));
		}

		[TestMethod]
		public void TestGetPublicInstanceEventDoesntMatchStatic()
		{
			Assert.IsNull(typeof(TypeExtenderFoo).GetEvent("PublicInstanceEvent", BindingFlags.Public | BindingFlags.Static));
		}

		[TestMethod]
		public void TestGetProtectedInstanceEventDoesntMatchStatic()
		{
			Assert.IsNull(typeof(TypeExtenderFoo).GetEvent("ProtectedInstanceEvent", BindingFlags.NonPublic | BindingFlags.Static));
		}

		[TestMethod]
		public void TestGetPrivateInstanceEventDoesntMatchStatic()
		{
			Assert.IsNull(typeof(TypeExtenderFoo).GetEvent("PrivateInstanceEvent", BindingFlags.NonPublic | BindingFlags.Static));
		}

		[TestMethod]
		public void TestGetPublicStaticEvent()
		{
			Assert.IsNotNull(typeof(TypeExtenderFoo).GetEvent("PublicStaticEvent", BindingFlags.Public | BindingFlags.Static));
		}

		[TestMethod]
		public void TestGetProtectedStaticEvent()
		{
			Assert.IsNotNull(typeof(TypeExtenderFoo).GetEvent("ProtectedStaticEvent", BindingFlags.NonPublic | BindingFlags.Static));
		}

		[TestMethod]
		public void TestGetPrivateStaticEvent()
		{
			Assert.IsNotNull(typeof(TypeExtenderFoo).GetEvent("PrivateStaticEvent", BindingFlags.NonPublic | BindingFlags.Static));
		}

		[TestMethod]
		public void TestGetPublicStaticEventDoesntMatchInstance()
		{
			Assert.IsNull(typeof(TypeExtenderFoo).GetEvent("PublicStaticEvent", BindingFlags.Public | BindingFlags.Instance));
		}

		[TestMethod]
		public void TestGetProtectedStaticEventDoesntMatchInstance()
		{
			Assert.IsNull(typeof(TypeExtenderFoo).GetEvent("ProtectedStaticEvent", BindingFlags.NonPublic | BindingFlags.Instance));
		}

		[TestMethod]
		public void TestGetPrivateStaticEventDoesntMatchInstance()
		{
			Assert.IsNull(typeof(TypeExtenderFoo).GetEvent("PrivateStaticEvent", BindingFlags.NonPublic | BindingFlags.Instance));
		}

		[TestMethod]
		public void TestGetMethodMissing()
		{
			Assert.IsNull(typeof(TypeExtenderFoo).GetMethod("xxx"));
		}

		[TestMethod]
		public void TestGetPropertyMissing()
		{
			Assert.IsNull(typeof(TypeExtenderFoo).GetProperty("xxx"));
		}

		[TestMethod]
		public void TestGetFieldMissing()
		{
			Assert.IsNull(typeof(TypeExtenderFoo).GetField("xxx"));
		}

		[TestMethod]
		public void TestGetEventMissing()
		{
			Assert.IsNull(typeof(TypeExtenderFoo).GetEvent("xxx"));
		}

		[TestMethod]
		public void TestGetMethodsPublicInstance()
		{
			var methods = typeof(TypeExtenderFoo).GetMethods(BindingFlags.Public | BindingFlags.Instance);

			Assert.IsNotNull(methods.Where(v => v.Name == "PublicInstanceMethod").FirstOrDefault());

			Assert.IsNull(methods.Where(v => v.Name == "ProtectedInstanceMethod").FirstOrDefault());
			Assert.IsNull(methods.Where(v => v.Name == "PrivateInstanceMethod").FirstOrDefault());
			Assert.IsNull(methods.Where(v => v.Name == "PublicStaticMethod").FirstOrDefault());
			Assert.IsNull(methods.Where(v => v.Name == "ProtectedStaticMethod").FirstOrDefault());
			Assert.IsNull(methods.Where(v => v.Name == "PrivateStaticMethod").FirstOrDefault());
		}

		[TestMethod]
		public void TestGetMethodsNonPublicInstance()
		{
			var methods = typeof(TypeExtenderFoo).GetMethods(BindingFlags.NonPublic | BindingFlags.Instance);

			Assert.IsNotNull(methods.Where(v => v.Name == "ProtectedInstanceMethod").FirstOrDefault());
			Assert.IsNotNull(methods.Where(v => v.Name == "PrivateInstanceMethod").FirstOrDefault());

			Assert.IsNull(methods.Where(v => v.Name == "PublicInstanceMethod").FirstOrDefault());
			Assert.IsNull(methods.Where(v => v.Name == "PublicStaticMethod").FirstOrDefault());
			Assert.IsNull(methods.Where(v => v.Name == "ProtectedStaticMethod").FirstOrDefault());
			Assert.IsNull(methods.Where(v => v.Name == "PrivateStaticMethod").FirstOrDefault());
		}

		[TestMethod]
		public void TestGetPropertiesPublicInstance()
		{
			var properties = typeof(TypeExtenderFoo).GetProperties(BindingFlags.Public | BindingFlags.Instance);

			Assert.IsNotNull(properties.Where(v => v.Name == "PublicInstanceProperty").FirstOrDefault());

			Assert.IsNull(properties.Where(v => v.Name == "ProtectedInstanceProperty").FirstOrDefault());
			Assert.IsNull(properties.Where(v => v.Name == "PrivateInstanceProperty").FirstOrDefault());
			Assert.IsNull(properties.Where(v => v.Name == "PublicStaticProperty").FirstOrDefault());
			Assert.IsNull(properties.Where(v => v.Name == "ProtectedStaticProperty").FirstOrDefault());
			Assert.IsNull(properties.Where(v => v.Name == "PrivateStaticProperty").FirstOrDefault());
		}

		[TestMethod]
		public void TestGetPropertiessNonPublicInstance()
		{
			var properties = typeof(TypeExtenderFoo).GetProperties(BindingFlags.NonPublic | BindingFlags.Instance);

			Assert.IsNotNull(properties.Where(v => v.Name == "ProtectedInstanceProperty").FirstOrDefault());
			Assert.IsNotNull(properties.Where(v => v.Name == "PrivateInstanceProperty").FirstOrDefault());

			Assert.IsNull(properties.Where(v => v.Name == "PublicInstanceProperty").FirstOrDefault());
			Assert.IsNull(properties.Where(v => v.Name == "PublicStaticProperty").FirstOrDefault());
			Assert.IsNull(properties.Where(v => v.Name == "ProtectedStaticProperty").FirstOrDefault());
			Assert.IsNull(properties.Where(v => v.Name == "PrivateStaticProperty").FirstOrDefault());
		}

		[TestMethod]
		public void TestGetFieldsPublicInstance()
		{
			var fields = typeof(TypeExtenderFoo).GetFields(BindingFlags.Public | BindingFlags.Instance);

			Assert.IsNotNull(fields.Where(v => v.Name == "PublicInstanceField").FirstOrDefault());

			Assert.IsNull(fields.Where(v => v.Name == "ProtectedInstanceField").FirstOrDefault());
			Assert.IsNull(fields.Where(v => v.Name == "PrivateInstanceField").FirstOrDefault());
			Assert.IsNull(fields.Where(v => v.Name == "PublicStaticField").FirstOrDefault());
			Assert.IsNull(fields.Where(v => v.Name == "ProtectedStaticField").FirstOrDefault());
			Assert.IsNull(fields.Where(v => v.Name == "PrivateStaticField").FirstOrDefault());
		}

		[TestMethod]
		public void TestGetFieldsPublicNonPublicInstance()
		{
			var fields = typeof(TypeExtenderFoo).GetFields(BindingFlags.NonPublic | BindingFlags.Instance);

			Assert.IsNotNull(fields.Where(v => v.Name == "ProtectedInstanceField").FirstOrDefault());
			Assert.IsNotNull(fields.Where(v => v.Name == "PrivateInstanceField").FirstOrDefault());

			Assert.IsNull(fields.Where(v => v.Name == "PublicInstanceField").FirstOrDefault());
			Assert.IsNull(fields.Where(v => v.Name == "PublicStaticField").FirstOrDefault());
			Assert.IsNull(fields.Where(v => v.Name == "ProtectedStaticField").FirstOrDefault());
			Assert.IsNull(fields.Where(v => v.Name == "PrivateStaticField").FirstOrDefault());
		}

		[TestMethod]
		public void TestGetEventsPublicInstance()
		{
			var evts = typeof(TypeExtenderFoo).GetEvents(BindingFlags.Public | BindingFlags.Instance);

			Assert.IsNotNull(evts.Where(v => v.Name == "PublicInstanceEvent").FirstOrDefault());

			Assert.IsNull(evts.Where(v => v.Name == "ProtectedInstanceEvent").FirstOrDefault());
			Assert.IsNull(evts.Where(v => v.Name == "PrivateInstanceEvent").FirstOrDefault());
			Assert.IsNull(evts.Where(v => v.Name == "PublicStaticEvent").FirstOrDefault());
			Assert.IsNull(evts.Where(v => v.Name == "ProtectedStaticEvent").FirstOrDefault());
			Assert.IsNull(evts.Where(v => v.Name == "PrivateStaticEvent").FirstOrDefault());
		}

		[TestMethod]
		public void TestGetEventsPublicNonPublicInstance()
		{
			var evts = typeof(TypeExtenderFoo).GetEvents(BindingFlags.NonPublic | BindingFlags.Instance);

			Assert.IsNotNull(evts.Where(v => v.Name == "ProtectedInstanceEvent").FirstOrDefault());
			Assert.IsNotNull(evts.Where(v => v.Name == "PrivateInstanceEvent").FirstOrDefault());

			Assert.IsNull(evts.Where(v => v.Name == "PublicInstanceEvent").FirstOrDefault());
			Assert.IsNull(evts.Where(v => v.Name == "PublicStaticEvent").FirstOrDefault());
			Assert.IsNull(evts.Where(v => v.Name == "ProtectedStaticEvent").FirstOrDefault());
			Assert.IsNull(evts.Where(v => v.Name == "PrivateStaticEvent").FirstOrDefault());
		}

		[TestMethod]
		public void TestGetMethodsPublicStatic()
		{
			var methods = typeof(TypeExtenderFoo).GetMethods(BindingFlags.Public | BindingFlags.Static);

			Assert.IsNotNull(methods.Where(v => v.Name == "PublicStaticMethod").FirstOrDefault());

			Assert.IsNull(methods.Where(v => v.Name == "ProtectedStaticMethod").FirstOrDefault());
			Assert.IsNull(methods.Where(v => v.Name == "PrivateStaticMethod").FirstOrDefault());
			Assert.IsNull(methods.Where(v => v.Name == "PublicInstanceMethod").FirstOrDefault());
			Assert.IsNull(methods.Where(v => v.Name == "ProtectedInstanceMethod").FirstOrDefault());
			Assert.IsNull(methods.Where(v => v.Name == "PrivateInstanceMethod").FirstOrDefault());
		}

		[TestMethod]
		public void TestGetMethodsNonPublicStatic()
		{
			var methods = typeof(TypeExtenderFoo).GetMethods(BindingFlags.NonPublic | BindingFlags.Static);

			Assert.IsNotNull(methods.Where(v => v.Name == "ProtectedStaticMethod").FirstOrDefault());
			Assert.IsNotNull(methods.Where(v => v.Name == "PrivateStaticMethod").FirstOrDefault());

			Assert.IsNull(methods.Where(v => v.Name == "PublicStaticMethod").FirstOrDefault());
			Assert.IsNull(methods.Where(v => v.Name == "PublicInstanceMethod").FirstOrDefault());
			Assert.IsNull(methods.Where(v => v.Name == "ProtectedInstanceMethod").FirstOrDefault());
			Assert.IsNull(methods.Where(v => v.Name == "PrivateInstanceMethod").FirstOrDefault());
		}

		[TestMethod]
		public void TestGetPropertiesPublicStatic()
		{
			var properties = typeof(TypeExtenderFoo).GetProperties(BindingFlags.Public | BindingFlags.Static);

			Assert.IsNotNull(properties.Where(v => v.Name == "PublicStaticProperty").FirstOrDefault());

			Assert.IsNull(properties.Where(v => v.Name == "ProtectedStaticProperty").FirstOrDefault());
			Assert.IsNull(properties.Where(v => v.Name == "PrivateStaticProperty").FirstOrDefault());
			Assert.IsNull(properties.Where(v => v.Name == "PublicInstanceProperty").FirstOrDefault());
			Assert.IsNull(properties.Where(v => v.Name == "ProtectedInstanceProperty").FirstOrDefault());
			Assert.IsNull(properties.Where(v => v.Name == "PrivateInstanceProperty").FirstOrDefault());
		}

		[TestMethod]
		public void TestGetPropertiessNonPublicStatic()
		{
			var properties = typeof(TypeExtenderFoo).GetProperties(BindingFlags.NonPublic | BindingFlags.Static);

			Assert.IsNotNull(properties.Where(v => v.Name == "ProtectedStaticProperty").FirstOrDefault());
			Assert.IsNotNull(properties.Where(v => v.Name == "PrivateStaticProperty").FirstOrDefault());

			Assert.IsNull(properties.Where(v => v.Name == "PublicStaticProperty").FirstOrDefault());
			Assert.IsNull(properties.Where(v => v.Name == "PublicInstanceProperty").FirstOrDefault());
			Assert.IsNull(properties.Where(v => v.Name == "ProtectedInstanceProperty").FirstOrDefault());
			Assert.IsNull(properties.Where(v => v.Name == "PrivateInstanceProperty").FirstOrDefault());
		}

		[TestMethod]
		public void TestGetFieldsPublicStatic()
		{
			var fields = typeof(TypeExtenderFoo).GetFields(BindingFlags.Public | BindingFlags.Static);

			Assert.IsNotNull(fields.Where(v => v.Name == "PublicStaticField").FirstOrDefault());

			Assert.IsNull(fields.Where(v => v.Name == "ProtectedStaticField").FirstOrDefault());
			Assert.IsNull(fields.Where(v => v.Name == "PrivateStaticField").FirstOrDefault());
			Assert.IsNull(fields.Where(v => v.Name == "PublicInstanceField").FirstOrDefault());
			Assert.IsNull(fields.Where(v => v.Name == "ProtectedInstanceField").FirstOrDefault());
			Assert.IsNull(fields.Where(v => v.Name == "PrivateInstanceField").FirstOrDefault());
		}

		[TestMethod]
		public void TestGetFieldsPublicNonPublicStatic()
		{
			var fields = typeof(TypeExtenderFoo).GetFields(BindingFlags.NonPublic | BindingFlags.Static);

			Assert.IsNotNull(fields.Where(v => v.Name == "ProtectedStaticField").FirstOrDefault());
			Assert.IsNotNull(fields.Where(v => v.Name == "PrivateStaticField").FirstOrDefault());

			Assert.IsNull(fields.Where(v => v.Name == "PublicStaticField").FirstOrDefault());
			Assert.IsNull(fields.Where(v => v.Name == "PublicInstanceField").FirstOrDefault());
			Assert.IsNull(fields.Where(v => v.Name == "ProtectedInstanceField").FirstOrDefault());
			Assert.IsNull(fields.Where(v => v.Name == "PrivateInstanceField").FirstOrDefault());
		}

		[TestMethod]
		public void TestGetEventsPublicStatic()
		{
			var evts = typeof(TypeExtenderFoo).GetEvents(BindingFlags.Public | BindingFlags.Static);

			Assert.IsNotNull(evts.Where(v => v.Name == "PublicStaticEvent").FirstOrDefault());

			Assert.IsNull(evts.Where(v => v.Name == "ProtectedStaticEvent").FirstOrDefault());
			Assert.IsNull(evts.Where(v => v.Name == "PrivateStaticEvent").FirstOrDefault());
			Assert.IsNull(evts.Where(v => v.Name == "PublicInstanceEvent").FirstOrDefault());
			Assert.IsNull(evts.Where(v => v.Name == "ProtectedInstanceEvent").FirstOrDefault());
			Assert.IsNull(evts.Where(v => v.Name == "PrivateInstanceEvent").FirstOrDefault());
		}

		[TestMethod]
		public void TestGetEventsPublicNonPublicStatic()
		{
			var evts = typeof(TypeExtenderFoo).GetEvents(BindingFlags.NonPublic | BindingFlags.Static);

			Assert.IsNotNull(evts.Where(v => v.Name == "ProtectedStaticEvent").FirstOrDefault());
			Assert.IsNotNull(evts.Where(v => v.Name == "PrivateStaticEvent").FirstOrDefault());

			Assert.IsNull(evts.Where(v => v.Name == "PublicStaticEvent").FirstOrDefault());
			Assert.IsNull(evts.Where(v => v.Name == "PublicInstanceEvent").FirstOrDefault());
			Assert.IsNull(evts.Where(v => v.Name == "ProtectedInstanceEvent").FirstOrDefault());
			Assert.IsNull(evts.Where(v => v.Name == "PrivateInstanceEvent").FirstOrDefault());
		}

		[TestMethod]
		public void TestGetConstructorPublic()
		{
			var constructor = typeof(TypeExtenderFoo).GetConstructor(new Type[] {});
			Assert.IsNotNull(constructor);
		}

		[TestMethod]
		public void TestGetConstructorPublicNonPublic()
		{
			var constructor = typeof(TypeExtenderFoo).GetConstructor(BindingFlags.NonPublic | BindingFlags.Instance, null, new Type[] { }, null);
			Assert.IsNull(constructor);
		}

		[TestMethod]
		public void TestGetConstructorMatchProtected()
		{
			var constructor = typeof(TypeExtenderFoo).GetConstructor(BindingFlags.NonPublic | BindingFlags.Instance, null, new Type[] { typeof(float) }, null);
			Assert.IsNotNull(constructor);
		}

		[TestMethod]
		public void TestGetConstructorMatchProtectedFails()
		{
			var constructor = typeof(TypeExtenderFoo).GetConstructor(BindingFlags.Public | BindingFlags.Instance, null, new Type[] { typeof(float) }, null);
			Assert.IsNull(constructor);
		}

		[TestMethod]
		public void TestGetConstructorMatchPrivate()
		{
			var constructor = typeof(TypeExtenderFoo).GetConstructor(BindingFlags.NonPublic | BindingFlags.Instance, null, new Type[] { typeof(double) }, null);
			Assert.IsNotNull(constructor);
		}

		[TestMethod]
		public void TestGetConstructorMatchPrivateFails()
		{
			var constructor = typeof(TypeExtenderFoo).GetConstructor(BindingFlags.Public | BindingFlags.Instance, null, new Type[] { typeof(double) }, null);
			Assert.IsNull(constructor);
		}

		[TestMethod]
		public void TestGetConstructorMatchMultiple()
		{
			var constructor = typeof(TypeExtenderFoo).GetConstructor(BindingFlags.NonPublic | BindingFlags.Instance, null,
				new Type[] { typeof(float), typeof(double), typeof(string) }, null);
			Assert.IsNotNull(constructor);
		}

		[TestMethod]
		public void TestGetConstructorMatchMultipleFails()
		{
			var constructor = typeof(TypeExtenderFoo).GetConstructor(BindingFlags.Public | BindingFlags.Instance, null,
				new Type[] { typeof(int), typeof(double), typeof(string) }, null);
			Assert.IsNull(constructor);
		}

		[TestMethod]
		public void TestPropertyGetterPublicReadWrite()
		{
			var prop = typeof(TypeExtenderFooProps).GetProperty("PublicReadWrite");

			Assert.IsNotNull(prop.GetGetMethod());
			Assert.IsNotNull(prop.GetSetMethod());
		}

		[TestMethod]
		public void TestPropertyGetterNonPublicReadWrite()
		{
			var prop = typeof(TypeExtenderFooProps).GetProperty("NonPublicReadWrite", BindingFlags.NonPublic | BindingFlags.Instance);

			Assert.IsNull(prop.GetGetMethod());
			Assert.IsNull(prop.GetSetMethod());
		}

		[TestMethod]
		public void TestPropertyGetterPublicReadOnly()
		{
			var prop = typeof(TypeExtenderFooProps).GetProperty("PublicReadOnly");

			Assert.IsNotNull(prop.GetGetMethod());
			Assert.IsNull(prop.GetSetMethod());
		}

		[TestMethod]
		public void TestPropertyGetterNonPublicReadOnly()
		{
			var prop = typeof(TypeExtenderFooProps).GetProperty("NonPublicReadOnly", BindingFlags.NonPublic | BindingFlags.Instance);

			Assert.IsNull(prop.GetGetMethod());
			Assert.IsNull(prop.GetSetMethod());
		}

		[TestMethod]
		public void TestPropertyGetterPublicWriteOnlyOnly()
		{
			var prop = typeof(TypeExtenderFooProps).GetProperty("PublicWriteOnly");

			Assert.IsNull(prop.GetGetMethod());
			Assert.IsNotNull(prop.GetSetMethod());
		}

		[TestMethod]
		public void TestPropertyGetterNonPublicWriteOnlyOnly()
		{
			var prop = typeof(TypeExtenderFooProps).GetProperty("NonPublicWriteOnly", BindingFlags.NonPublic | BindingFlags.Instance);

			Assert.IsNull(prop.GetGetMethod());
			Assert.IsNull(prop.GetSetMethod());
		}

		[TestMethod]
		public void TestPropertyGetterPublicReadWriteArgs()
		{
			var prop = typeof(TypeExtenderFooProps).GetProperty("PublicReadWrite");

			Assert.IsNotNull(prop.GetGetMethod(true));
			Assert.IsNotNull(prop.GetSetMethod(true));
		}

		[TestMethod]
		public void TestPropertyGetterNonPublicReadWriteArgs()
		{
			var prop = typeof(TypeExtenderFooProps).GetProperty("NonPublicReadWrite", BindingFlags.NonPublic | BindingFlags.Instance);

			Assert.IsNotNull(prop.GetGetMethod(true));
			Assert.IsNotNull(prop.GetSetMethod(true));
		}

		[TestMethod]
		public void TestPropertyGetterPublicReadOnlyArgs()
		{
			var prop = typeof(TypeExtenderFooProps).GetProperty("PublicReadOnly");

			Assert.IsNotNull(prop.GetGetMethod(true));
			Assert.IsNull(prop.GetSetMethod(true));
		}

		[TestMethod]
		public void TestPropertyGetterNonPublicReadOnlyArgs()
		{
			var prop = typeof(TypeExtenderFooProps).GetProperty("NonPublicReadOnly", BindingFlags.NonPublic | BindingFlags.Instance);

			Assert.IsNotNull(prop.GetGetMethod(true));
			Assert.IsNull(prop.GetSetMethod(true));
		}

		[TestMethod]
		public void TestPropertyGetterPublicWriteOnlyOnlyArgs()
		{
			var prop = typeof(TypeExtenderFooProps).GetProperty("PublicWriteOnly");

			Assert.IsNull(prop.GetGetMethod(true));
			Assert.IsNotNull(prop.GetSetMethod(true));
		}

		[TestMethod]
		public void TestPropertyGetterNonPublicWriteOnlyOnlyArgs()
		{
			var prop = typeof(TypeExtenderFooProps).GetProperty("NonPublicWriteOnly", BindingFlags.NonPublic | BindingFlags.Instance);

			Assert.IsNull(prop.GetGetMethod(true));
			Assert.IsNotNull(prop.GetSetMethod(true));
		}

		[TestMethod]
		[Ignore]
		public void TestGetInterface()
		{
			//var iface = typeof(TypeExtenderFooInterfaces).GetInterface(typeof(IFoo));
			//Assert.IsNotNull(iface);
			throw new NotImplementedException("This operation has not been implemented.");
		}

		[TestMethod]
		[Ignore]
		public void TestGetInterfaceMissing()
		{
			//var iface = typeof(TypeExtenderFooInterfaces).GetInterface(typeof(IFoo3));
			//Assert.IsNull(iface);
			throw new NotImplementedException("This operation has not been implemented.");
		}

		[TestMethod]
		public void TestGetInterfaceByName()
		{
			var iface = typeof(TypeExtenderFooInterfaces).GetInterface("System.Reflection.Tests.IFoo");
			Assert.AreEqual(typeof(IFoo), iface);
		}

		[TestMethod]
		public void TestGetInterfaceByNamePartial()
		{
			var iface = typeof(TypeExtenderFooInterfaces).GetInterface("IFoo");
			Assert.AreEqual(typeof(IFoo), iface);
		}

		[TestMethod]
		public void TestGetInterfaceByNameMissing()
		{
			var iface = typeof(TypeExtenderFooInterfaces).GetInterface("System.Reflection.Tests.IFoo3");
			Assert.IsNull(iface);
		}

		[TestMethod]
		public void TestGetInterfaceByNameCaseInsensitive()
		{
			var iface = typeof(TypeExtenderFooInterfaces).GetInterface("ifoo", true);
			Assert.AreEqual(typeof(IFoo), iface);
		}

		[TestMethod]
		[Ignore]
		public void TestGetInterfaceInherited()
		{
			//var iface = typeof(TypeExtenderFooInterfaces2).GetInterface(typeof(IFoo2));
			//Assert.IsNotNull(iface);
			throw new NotImplementedException("This operation has not been implemented.");
		}

		[TestMethod]
		public void TestGetInterfaceInheritedByName()
		{
			var iface = typeof(TypeExtenderFooInterfaces).GetInterface("System.Reflection.Tests.IFoo2");
			Assert.IsNotNull(iface);
		}

		[TestMethod]
		public void TestEventMethodsPublic()
		{
			var evt = typeof(TypeExtenderFoo).GetEvent("PublicInstanceEvent");

			Assert.IsNotNull(evt.GetAddMethod());
			Assert.IsNotNull(evt.GetRemoveMethod());
		}

		[TestMethod]
		public void TestEventMethodsNonPublic()
		{
			var evt = typeof(TypeExtenderFoo).GetEvent("PrivateInstanceEvent", BindingFlags.Instance | BindingFlags.NonPublic);

			Assert.IsNull(evt.GetAddMethod());
			Assert.IsNull(evt.GetRemoveMethod());
		}

		[TestMethod]
		public void TestEventMethodsNonPublicExplicit()
		{
			var evt = typeof(TypeExtenderFoo).GetEvent("PrivateInstanceEvent", BindingFlags.Instance | BindingFlags.NonPublic);

			Assert.IsNotNull(evt.GetAddMethod(true));
			Assert.IsNotNull(evt.GetRemoveMethod(true));
		}

		[TestMethod]
		public void TestMethodMatchParametersPublicInstance()
		{
			var method = typeof(TypeExtenderFoo).GetMethod("FixWarnings", new Type[] { typeof(string), typeof(int) });
			Assert.IsNotNull(method);
		}

		[TestMethod]
		public void TestMethodMatchParametersNonPublicInstance()
		{
			var method = typeof(TypeExtenderFoo).GetMethod("FixWarningsNonPublic", new Type[] { typeof(string), typeof(int), typeof(decimal) });
			Assert.IsNull(method);
		}

		[TestMethod]
		public void TestMethodMatchParametersPublicStatic()
		{
			var method = typeof(TypeExtenderFoo).GetMethod("FixWarningsStatic", new Type[] { typeof(string), typeof(int) });
			Assert.IsNotNull(method);
		}

		[TestMethod]
		public void TestMethodMatchParametersNonPublicStatic()
		{
			var method = typeof(TypeExtenderFoo).GetMethod("FixWarningsStaticNonPublic", new Type[] { typeof(string), typeof(int), typeof(decimal) });
			Assert.IsNull(method);
		}

		[TestMethod]
		public void TestMethodMatchParametersFail()
		{
			var method = typeof(TypeExtenderFoo).GetMethod("FixWarnings", new Type[] { typeof(string), typeof(int), typeof(object) });
			Assert.IsNull(method);
		}

		[TestMethod]
		public void TestGetMethodNoFlattenHierarchyImplicit()
		{
			// flatten hierarchy only applies to statics...
			var method = typeof(TypeExtenderFooSubClass).GetMethod("FixWarningsStatic");
			Assert.IsNull(method);
		}

		[TestMethod]
		public void TestGetMethodNoFlattenHierarchyExplicit()
		{
			// flatten hierarchy only applies to statics...
			var method = typeof(TypeExtenderFooSubClass).GetMethod("FixWarningsStatic", BindingFlags.Public | BindingFlags.Static);
			Assert.IsNull(method);
		}

		[TestMethod]
		public void TestGetMethodFlattenHierarchy()
		{
			var method = typeof(TypeExtenderFooSubClass).GetMethod("FixWarningsStatic", BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy);
			Assert.IsNotNull(method);
		}

		[TestMethod()]
		public void TestConstructorsDoNotIncludeBaseClasses()
		{
			var ctrs = typeof(TypeExtenderFooSubClass).GetConstructors();
			Assert.AreEqual(1, ctrs.Length);
			Assert.AreEqual(typeof(DateTime), ctrs[0].GetParameters()[0].ParameterType);
		}
	}
}
