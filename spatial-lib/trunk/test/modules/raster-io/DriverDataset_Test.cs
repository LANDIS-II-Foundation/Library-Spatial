// Copyright 2005-2006 University of Wisconsin
// Author: James Domingo, UW-Madison, Forest Landscape Ecology Lab

using Edu.Wisc.Forest.Flel.Util;
using NUnit.Framework;
using System.Collections.Generic;
using System.IO;
using Wisc.Flel.GeospatialModeling.RasterIO;

namespace Wisc.Flel.Test.GeospatialModeling.RasterIO
{
    [TestFixture]
    public class DriverDataset_Test
    {
        [Test]
        public void Erdas74()
        {
            string path = Data.MakeInputPath("Erdas74.xml");
            DriverDataset dataset = new DriverDataset(path);

            IList<DriverInfo> gisDrivers = dataset.GetDrivers(".gis");
            Assert.IsNotNull(gisDrivers);
            Assert.AreEqual(1, gisDrivers.Count);
            AssertIsErdas74Driver(gisDrivers[0]);

            IList<DriverInfo> lanDrivers = dataset.GetDrivers(".lan");
            Assert.IsNotNull(lanDrivers);
            Assert.AreEqual(1, lanDrivers.Count);
            AssertIsErdas74Driver(lanDrivers[0]);
        }

        //---------------------------------------------------------------------

        private void AssertIsErdas74Driver(DriverInfo driver)
        {
            Assert.IsNotNull(driver);
            Assert.AreEqual("Erdas 7.4", driver.Name);
            Assert.AreEqual("Wisc.Flel.GeospatialModeling.RasterIO.Drivers.Erdas74.Driver,Wisc.Flel.GeospatialModeling.RasterIO.Drivers.Erdas74",
                            driver.ImplementationName);
            Assert.AreEqual(FileAccess.ReadWrite, driver[".gis"]);
            Assert.AreEqual(FileAccess.ReadWrite, driver[".lan"]);
        }
    }
}
