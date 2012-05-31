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
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace System.Reflection.Tests
{
	internal class TypeExtenderFoo
	{
		public object PublicInstanceProperty { get; set; }
		protected object ProtectedInstanceProperty { get; set; }
		private object PrivateInstanceProperty { get; set; }

		public static object PublicStaticProperty { get; set; }
		protected static object ProtectedStaticProperty { get; set; }
		private static object PrivateStaticProperty { get; set; }

		public object PublicInstanceField;
		protected object ProtectedInstanceField;
		private object PrivateInstanceField;

		public static object PublicStaticField;
		protected static object ProtectedStaticField;
		private static object PrivateStaticField;

		public event EventHandler PublicInstanceEvent;
		protected event EventHandler ProtectedInstanceEvent;
		private event EventHandler PrivateInstanceEvent;

		public static event EventHandler PublicStaticEvent;
		protected static event EventHandler ProtectedStaticEvent;
		private static event EventHandler PrivateStaticEvent;

		public TypeExtenderFoo()
		{
		}

		protected TypeExtenderFoo(float a)
		{
		}

		private TypeExtenderFoo(double b)
		{
		}

		private TypeExtenderFoo(float a, double b, string c)
		{
		}

		public void PublicInstanceMethod()
		{
		}

		protected void ProtectedInstanceMethod()
		{
		}

		private void PrivateInstanceMethod()
		{
		}

		public static void PublicStaticMethod()
		{
		}

		protected static void ProtectedStaticMethod()
		{
		}

		private static void PrivateStaticMethod()
		{
		}

		// @mbrit - 2012-05-31 - this method is to get rid of warnings...
		public void FixWarnings(string a, int b)
		{
			this.PublicInstanceField = null;
			Debug.WriteLine(this.PublicInstanceField);
			this.ProtectedInstanceField = null;
			Debug.WriteLine(this.ProtectedInstanceField);
			this.PrivateInstanceField = null;
			Debug.WriteLine(this.PrivateInstanceField);

			this.PublicInstanceEvent += Sink;
			this.ProtectedInstanceEvent += Sink;
			this.PrivateInstanceEvent += Sink;

			this.PublicInstanceEvent(null, null);
			this.ProtectedInstanceEvent(null, null);
			this.PrivateInstanceEvent(null, null);
		}

		private void FixWarningsNonPublic(string a, int b, decimal c)
		{
		}

		// @mbrit - 2012-05-31 - this method is to get rid of warnings...
		public static void FixWarningsStatic(string a, int b)
		{
			PublicStaticField = null;
			Debug.WriteLine(PublicStaticField);
			ProtectedStaticField = null;
			Debug.WriteLine(ProtectedStaticField);
			PrivateStaticField = null;
			Debug.WriteLine(PrivateStaticField);

			PublicStaticEvent += Sink;
			ProtectedStaticEvent += Sink;
			PrivateStaticEvent += Sink;

			PublicStaticEvent(null, null);
			ProtectedStaticEvent(null, null);
			PrivateStaticEvent(null, null);
		}

		private void FixWarningsStaticNonPublic(string a, int b, decimal c)
		{
		}

		private static void Sink(object sender, EventArgs e)
		{
			throw new NotImplementedException();
		}
	}

	internal class TypeExtenderFooSubClass : TypeExtenderFoo
	{
		public TypeExtenderFooSubClass(DateTime dt)
		{
		}

		public void InSubclass()
		{
		}
	}

	internal class TypeExtenderFooProps
	{
		public object PublicReadWrite { get; set; }
		private object NonPublicReadWrite { get; set; }

		public object PublicReadOnly
		{
			get
			{
				return null;
			}
		}

		private object NonPublicReadOnly
		{
			get
			{
				return null;
			}
		}

		public object PublicWriteOnly
		{
			set
			{
			}
		}

		private object NonPublicWriteOnly
		{
			set
			{
			}
		}
	}

	internal interface IFoo
	{
	}

	internal interface IFoo2
	{
	}

	internal interface IFoo3
	{
	}

	internal class TypeExtenderFooInterfaces : IFoo, IFoo2
	{
	}

	internal class TypeExtenderFooInterfaces2 : TypeExtenderFooInterfaces, IFoo3
	{
	}
}
