// Copyright 2005-2006 University of Wisconsin
// Author: James Domingo, UW-Madison, Forest Landscape Ecology Lab

namespace Wisc.Flel.GeospatialModeling.RasterIO
{
    /// <summary>
    /// An individual band value of data type T in a raster pixel.
    /// </summary>
    public interface IPixelBandValue<T>
        : IPixelBand
    {
        /// <summary>
        /// The band's value.
        /// </summary>
        T Value
        {
            get;
            set;
        }
    }
}
