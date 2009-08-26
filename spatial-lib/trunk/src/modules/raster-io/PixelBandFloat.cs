// Copyright 2005-2006 University of Wisconsin
// Author: James Domingo, UW-Madison, Forest Landscape Ecology Lab

namespace Wisc.Flel.GeospatialModeling.RasterIO
{
    /// <summary>
    /// A PixelBand with a 32-bit floating-point value.
    /// </summary>
    public class PixelBandFloat
        : PixelBand<float, Edu.Wisc.Forest.Flel.Util.ByteMethods.Float>
    {
        /// <summary>
        /// Initializes a new instance with a default value of 0.
        /// </summary>
        public PixelBandFloat()
            : base()
        {
        }

        //---------------------------------------------------------------------

        /// <summary>
        /// Initializes a new instance with a specific value.
        /// </summary>
        public PixelBandFloat(float initialValue)
            : base(initialValue)
        {
        }
    }
}
