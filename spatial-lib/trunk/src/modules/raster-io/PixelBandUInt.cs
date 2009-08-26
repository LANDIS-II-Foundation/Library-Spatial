// Copyright 2005-2006 University of Wisconsin
// Author: James Domingo, UW-Madison, Forest Landscape Ecology Lab

namespace Wisc.Flel.GeospatialModeling.RasterIO
{
    /// <summary>
    /// A PixelBand with an unsigned 32-bit integer value.
    /// </summary>
    public class PixelBandUInt
        : PixelBand<uint, Edu.Wisc.Forest.Flel.Util.ByteMethods.UInt>
    {
        /// <summary>
        /// Initializes a new instance with a default value of 0.
        /// </summary>
        public PixelBandUInt()
            : base()
        {
        }

        //---------------------------------------------------------------------

        /// <summary>
        /// Initializes a new instance with a specific value.
        /// </summary>
        public PixelBandUInt(uint initialValue)
            : base(initialValue)
        {
        }
    }
}
