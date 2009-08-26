// Copyright 2005-2006 University of Wisconsin
// Author: James Domingo, UW-Madison, Forest Landscape Ecology Lab

namespace Wisc.Flel.GeospatialModeling.RasterIO
{
    /// <summary>
    /// A PixelBand with an unsigned 8-bit integer value.
    /// </summary>
    public class PixelBandByte
        : PixelBand<byte, Edu.Wisc.Forest.Flel.Util.ByteMethods.Byte>
    {
        /// <summary>
        /// Initializes a new instance with a default value of 0.
        /// </summary>
        public PixelBandByte()
            : base()
        {
        }

        //---------------------------------------------------------------------

        /// <summary>
        /// Initializes a new instance with a specific value.
        /// </summary>
        public PixelBandByte(byte initialValue)
            : base(initialValue)
        {
        }
    }
}
