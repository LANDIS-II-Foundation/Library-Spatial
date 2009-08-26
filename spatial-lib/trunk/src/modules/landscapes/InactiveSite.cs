// Copyright 2004-2006 University of Wisconsin
// Author: James Domingo, UW-Madison, Forest Landscape Ecology Lab

namespace Wisc.Flel.GeospatialModeling.Landscapes
{
    public static class InactiveSite
    {
        /// <summary>
        /// The data index assigned to inactive sites.
        /// </summary>
        public const uint DataIndex = 0;

        //---------------------------------------------------------------------

        /// <summary>
        /// Creates a new inactive site on a landscape.
        /// </summary>
        /// <param name="landscape">
        ///  The landscape where the site is located.
        /// </param>
        /// <param name="location">
        ///  The location of the site.
        /// </param>
        internal static Site Create(ILandscape landscape,
                                    Location   location)
        {
            return new Site(landscape, location, DataIndex);
        }

    }
}
