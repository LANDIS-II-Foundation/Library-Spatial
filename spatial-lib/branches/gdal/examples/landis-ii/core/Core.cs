using Landis.SpatialModeling;
using System;

namespace LandisII.Examples
{
    public class Core : LandisII.Examples.SimpleCore.ICore
    {
        public Core()
        {
        }

#region ICore members
        public int CurrentTime
        {
            get {
                return 0;
            }
        }

        public IInputRaster<TPixel> OpenRaster<TPixel>(string path)
            where TPixel : Pixel, new()
        {
            throw new NotImplementedException();
        }

        public IOutputRaster<TPixel> CreateRaster<TPixel>(string     path,
                                                          Dimensions dimensions)
            where TPixel : Pixel, new()
        {
            throw new NotImplementedException();
        }
#endregion
    }
}
