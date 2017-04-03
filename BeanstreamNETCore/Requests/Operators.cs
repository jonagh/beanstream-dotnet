﻿// The MIT License (MIT)
//
// Copyright (c) 2014 Beanstream Internet Commerce Corp, Digital River, Inc.
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

/// <summary>
/// Operators used for querying transactions using the Reporting API.
/// </summary>
using System.ComponentModel;
using Newtonsoft.Json;


namespace Beanstream
{
	public enum Operators
	{
		[Description("%3D")]
		Equals, 

		[Description("%3C")]
		LessThan, 

		[Description("%3E")]
		GreaterThan,

		[Description("%3C%3D")]
		LessThanEqual, 

		[Description("%3e%3D")]
		GreaterThanEqual,

		[Description("START%20WITH")]
		StartWith
	}
}

