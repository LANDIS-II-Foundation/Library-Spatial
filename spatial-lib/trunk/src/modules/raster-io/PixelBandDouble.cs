// Copyright 2005-2006 University of Wisconsin
// Author: James Domingo, UW-Madison, Forest Landscape Ecology Lab

namespace Wisc.Flel.GeospatialModeling.RasterIO
{
    /// <summary>
    /// A PixelBand with a 64-bit floating-point value.
    /// </summary>
    public class PixelBandDouble
        : PixelBand<double, Edu.Wisc.Forest.Flel.Util.ByteMethods.Double>
    {
        /// <summary>
        /// Initializes a new instance with a default value of 0.
        /// </summary>
        public PixelBandDouble()
            : base()
        {
        }

        //---------------------------------------------------------------------

        /// <summary>
        /// Initializes a new instance with a specific value.
        /// </summary>
        public PixelBandDouble(double initialValue)
            : base(initialValue)
        {
        }
    }
}
