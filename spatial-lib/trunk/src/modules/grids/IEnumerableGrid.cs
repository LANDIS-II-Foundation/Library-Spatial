// Copyright 2004-2006 University of Wisconsin
// Author: James Domingo, UW-Madison, Forest Landscape Ecology Lab

namespace Wisc.Flel.GeospatialModeling.Grids
{
    /// <summary>
    /// A grid that whose cells (elements) can be enumerated.
    /// </summary>
    public interface IEnumerableGrid<TCell>
        : IGrid, System.Collections.Generic.IEnumerable<TCell>
    {
    }
}
