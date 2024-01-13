﻿// <copyright file="MyrmecExtentionsTest.cs" company="Rocket Robin">
// Copyright (c) Rocket Robin. All rights reserved.
// Licensed under the Apache v2 license. See LICENSE file in the project root for full license information.
// </copyright>

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Myrmec.net8;
using System.Collections.Generic;
using System.Linq;

namespace Myrmec.Test
{
  [TestClass]
    public class MyrmecExtentionsTest
    {
        [TestMethod]
        public void ComplexFileTypeTest()
        {
            List<Metadata> list = new List<Metadata>();
            Record record = new Record()
            {
                Extentions = "a,b,c",
                Hex = "0x11 0x22 ?? ?? ?? 0x33",
                Offset = 2
            };

            list.Add(record);
            var data = new byte[]
            {
                0x11, 0x11, 0x11, 0x22, 0xff, 0xdd, 0x1d, 0x33
            };
            var result = list.First().Match(data);

            Assert.IsTrue(result);
        }
    }
}
