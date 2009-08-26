// Copyright 2004-2006 University of Wisconsin
// Author: James Domingo, UW-Madison, Forest Landscape Ecology Lab

using System.Diagnostics;

namespace Wisc.Flel.GeospatialModeling.Landscapes
{
    public abstract class SiteVar<T>
    {
        private ILandscape landscape;

        //---------------------------------------------------------------------

        public System.Type DataType
        {
            get {
                return typeof(T);
            }
        }

        //---------------------------------------------------------------------

        public ILandscape Landscape
        {
            get {
                return landscape;
            }
        }

        //---------------------------------------------------------------------

        protected SiteVar(ILandscape landscape)
        {
            this.landscape = landscape;
        }

        //---------------------------------------------------------------------

        /// <summary>
        /// Validates that a site refers to the same landscape as the site
        /// variable was created for.
        /// </summary>
        protected void Validate(Site site)
        {
            Trace.Assert(site != null);
            Trace.Assert(site.Landscape == landscape);
        }
    }
}
