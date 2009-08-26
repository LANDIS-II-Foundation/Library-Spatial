// Copyright 2005-2006 University of Wisconsin
// Author: James Domingo, UW-Madison, Forest Landscape Ecology Lab

using Edu.Wisc.Forest.Flel.Util;
using Wisc.Flel.GeospatialModeling.Grids;

namespace Wisc.Flel.GeospatialModeling.RasterIO
{
    /// <summary>
    /// An error that occurred at a particular pixel in a raster.
    /// </summary>
    public class PixelException
        : MultiLineException
    {
        /// <summary>
        /// Initializes a new instance.
        /// </summary>
        public PixelException(Location        location,
                              string          message,
                              params object[] mesgArgs)
            : base(string.Format("Error at pixel {0}", location),
                   string.Format(message, mesgArgs))
        {
        }
    }
}
