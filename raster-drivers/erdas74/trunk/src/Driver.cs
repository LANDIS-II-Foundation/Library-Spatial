using Wisc.Flel.GeospatialModeling.Grids;
using Wisc.Flel.GeospatialModeling.RasterIO;

namespace Wisc.Flel.GeospatialModeling.RasterDrivers.Erdas74
{
    public class Driver : IDriver
    {
        static string[] extensions = { "gis","lan" };
        
        //---------------------------------------------------------------------

        /// <summary>
        ///         
        /// </summary>
        public string[] Formats
        {
            get { return extensions; }
        }

        //---------------------------------------------------------------------

        /// <summary>
        ///         
        /// </summary>
        public IInputRaster<T> OpenRaster<T>(string path)
            where T : IPixel, new()
        {
            return new InputRaster<T>(path);
        }

        //---------------------------------------------------------------------

        /// <summary>
        ///         
        /// </summary>
        public IOutputRaster<T> CreateRaster<T>(string     path,
                                                Dimensions dimensions,
                                                IMetadata  metadata)
            where T : IPixel, new()
        {
            return new OutputRaster<T>(path, dimensions, metadata);
        }
    }
}
