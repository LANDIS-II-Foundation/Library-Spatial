// Copyright 2005-2006 University of Wisconsin
// Author: James Domingo, UW-Madison, Forest Landscape Ecology Lab

namespace Wisc.Flel.GeospatialModeling.RasterIO
{
    /// <summary>
    /// A PixelBand with a signed 16-bit integer value.
    /// </summary>
    public class PixelBandShort
        : PixelBand<short, Edu.Wisc.Forest.Flel.Util.ByteMethods.Short>
    {
        /// <summary>
        /// Initializes a new instance with a default value of 0.
        /// </summary>
        public PixelBandShort()
            : base()
        {
        }

        //---------------------------------------------------------------------

        /// <summary>
        /// Initializes a new instance with a specific value.
        /// </summary>
        public PixelBandShort(short initialValue)
            : base(initialValue)
        {
        }
    }
}
