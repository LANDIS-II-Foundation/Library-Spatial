// Copyright 2004-2006 University of Wisconsin
// Author: James Domingo, UW-Madison, Forest Landscape Ecology Lab

namespace Wisc.Flel.GeospatialModeling.Grids
{
    /// <summary>
    /// Methods for traversing locations in a grid in row-major order.
    /// </summary>
    public static class RowMajor
    {
        /// <summary>
        /// Gets the next location in row-major order.
        /// </summary>
        /// <param name="columns">
        /// The number of columns in the grid being traversed.
        /// </param>
        public static Location Next(Location location,
                                    int      columns)
        {
            if (location.Column < columns) {
                return new Location(location.Row, location.Column + 1);
            }
            else {
                return new Location(location.Row + 1, 1);
            }
        }
    }
}
