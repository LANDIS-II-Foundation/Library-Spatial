using Landis.SpatialModeling;
using Landis.SpatialModeling.CoreServices;
using System;

namespace LandisII.Examples
{
    public class Core : LandisII.Examples.SimpleCore.ICore
    {
        private RasterFactory rasterFactory;

        public Core()
        {
            rasterFactory = new RasterFactory();
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
            return rasterFactory.OpenRaster<TPixel>(path);
        }

        public IOutputRaster<TPixel> CreateRaster<TPixel>(string     path,
                                                          Dimensions dimensions)
            where TPixel : Pixel, new()
        {
            return rasterFactory.CreateRaster<TPixel>(path, dimensions);
        }
#endregion
    }
}
