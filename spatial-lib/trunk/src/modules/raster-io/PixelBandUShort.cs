// Copyright 2005-2006 University of Wisconsin
// Author: James Domingo, UW-Madison, Forest Landscape Ecology Lab

namespace Wisc.Flel.GeospatialModeling.RasterIO
{
    /// <summary>
    /// A PixelBand with an unsigned 16-bit integer value.
    /// </summary>
    public class PixelBandUShort
        : PixelBand<ushort, Edu.Wisc.Forest.Flel.Util.ByteMethods.UShort>
    {
        /// <summary>
        /// Initializes a new instance with a default value of 0.
        /// </summary>
        public PixelBandUShort()
            : base()
        {
        }

        //---------------------------------------------------------------------

        /// <summary>
        /// Initializes a new instance with a specific value.
        /// </summary>
        public PixelBandUShort(ushort initialValue)
            : base(initialValue)
        {
        }
    }
}
