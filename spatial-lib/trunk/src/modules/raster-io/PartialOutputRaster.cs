// Copyright 2005-2006 University of Wisconsin
// Author: James Domingo, UW-Madison, Forest Landscape Ecology Lab

using Wisc.Flel.GeospatialModeling.Grids;

namespace Wisc.Flel.GeospatialModeling.RasterIO
{
    public static class PartialOutputRaster
    {
        /// <summary>
        /// Signature for methods called with a partial output raster is
        /// closed.
        /// </summary>
        public delegate void CloseEventHandler(string     path,
                                               Dimensions dimensions,
                                               int        pixelsWritten);

        //---------------------------------------------------------------------

        /// <summary>
        /// The event when a partial output raster is called.
        /// </summary>
        public static event CloseEventHandler CloseEvent;

        //---------------------------------------------------------------------

        /// <summary>
        /// Called when a partial output raster is closed.
        /// </summary>
        public static void Closed(OutputRaster outputRaster)
        {
            if (CloseEvent != null)
                CloseEvent(outputRaster.Path, outputRaster.Dimensions,
                           outputRaster.PixelsWritten);
        }
    }
}
