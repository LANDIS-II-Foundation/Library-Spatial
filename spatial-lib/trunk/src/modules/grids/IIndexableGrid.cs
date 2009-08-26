// Copyright 2004-2006 University of Wisconsin
// Author: James Domingo, UW-Madison, Forest Landscape Ecology Lab

namespace Wisc.Flel.GeospatialModeling.Grids
{
    /// <summary>
    /// A grid whose cells can be accessed by their locations.
    /// </summary>
    public interface IIndexableGrid<TCell>
        : IGrid
    {
        TCell this [int row,
                    int column]
        {
            get;
            set;
        }

        //---------------------------------------------------------------------

        TCell this [Location location]
        {
            get;
            set;
        }
    }
}
