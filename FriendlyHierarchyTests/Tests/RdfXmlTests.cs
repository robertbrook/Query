﻿// MIT License
//
// Copyright (c) 2019 UK Parliament
//
// Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

namespace FriendlyHierarchyTests
{
    using FriendlyHierarchy;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using VDS.RDF;
    using VDS.RDF.Parsing;
    using VDS.RDF.Writing;

    [TestClass]
    [TestCategory("LocalOnly")]
    [TestCategory("FriendlyHierarchy")]
    public class RdfXmlTests
    {
        [TestMethod]
        [DynamicData(nameof(RdfXmlTestSuiteHelper.TestCases), typeof(RdfXmlTestSuiteHelper))]
        public void RdfXmlTestSuite(string name)
        {
            RdfXmlTestSuiteHelper.GetGraphs(name, out IGraph action, out IGraph expected);

            // If default readers don't agree they're equal, there's nothing to test
            if (!expected.Equals(action))
            {
                Assert.Inconclusive();
            }

            var actual = new Graph();
            actual.LoadFromString(
                StringWriter.Write(action, new FriendlyRdfXmlWriter()),
                new RdfXmlParser());

            Assert.AreEqual(expected, actual);
        }
    }
}