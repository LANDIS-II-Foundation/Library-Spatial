// Copyright 2004, 2006 University of Wisconsin
// Author: James Domingo, UW-Madison, Forest Landscape Ecology Lab

namespace Wisc.Flel.GeospatialModeling.Landscapes
{
    internal interface ISiteVarWithData
        : ISiteVariable
    {
        //---------------------------------------------------------------------

        void AllocateData(uint siteCount);

        //---------------------------------------------------------------------

        void ShareData(ISiteVarWithData variable);
    }
}
