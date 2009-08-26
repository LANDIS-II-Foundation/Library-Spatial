// Copyright 2005-2006 University of Wisconsin
// Author: James Domingo, UW-Madison, Forest Landscape Ecology Lab

namespace Wisc.Flel.GeospatialModeling.RasterIO
{
    /// <summary>
    /// A driver for opening raster files for reading and creating new files
    /// for writing.
    /// </summary>
    public interface IDriver
        : IRasterFactory
    {
        /// <summary>
        /// The list of raster formats that this driver recognizes.  A format
        /// is denoted by a filename extension, e.g., ".xyx".
        /// </summary>
        string[] Formats
        {
            get;
        }
    }
}
