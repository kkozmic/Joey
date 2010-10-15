// Copyright (C) 2010, Krzysztof Kozmic 
// 
// Permission is hereby granted, free of charge, to any person obtaining a 
// copy of this software and associated documentation files (the "Software"), 
// to deal in the Software without restriction, including without limitation 
// the rights to use, copy, modify, merge, publish, distribute, sublicense, 
// and/or sell copies of the Software, and to permit persons to whom the 
// Software is furnished to do so, subject to the following conditions: 
// 
// The above copyright notice and this permission notice shall be included in 
// all copies or substantial portions of the Software. 
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR 
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, 
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.  IN NO EVENT SHALL 
// THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER 
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING 
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER 
// DEALINGS IN THE SOFTWARE. 

namespace Joey
{
	using System;
	using System.Collections.Generic;

	using Xunit.Sdk;

	public class ScenarioRunner : ITestClassCommand
	{
		public object ObjectUnderTest
		{
			get { throw new NotImplementedException(); }
		}

		public ITypeInfo TypeUnderTest
		{
			get { throw new NotImplementedException(); }
			set { throw new NotImplementedException(); }
		}

		public int ChooseNextTest(ICollection<IMethodInfo> testsLeftToRun)
		{
			throw new NotImplementedException();
		}

		public Exception ClassFinish()
		{
			throw new NotImplementedException();
		}

		public Exception ClassStart()
		{
			throw new NotImplementedException();
		}

		public IEnumerable<ITestCommand> EnumerateTestCommands(IMethodInfo testMethod)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<IMethodInfo> EnumerateTestMethods()
		{
			throw new NotImplementedException();
		}

		public bool IsTestMethod(IMethodInfo testMethod)
		{
			throw new NotImplementedException();
		}
	}
}