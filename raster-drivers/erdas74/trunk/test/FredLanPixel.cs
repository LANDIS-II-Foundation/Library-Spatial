using Edu.Wisc.Forest.Flel.Util;
using Wisc.Flel.GeospatialModeling.RasterIO;
using Wisc.Flel.GeospatialModeling.RasterDrivers.Erdas74;

namespace Wisc.Flel.Test.GeospatialModeling.RasterDrivers.Erdas74
{
    class FredLanPixel : IPixel
    {
        IPixelBand[] bands;

        public FredLanPixel()
        {
            bands = new IPixelBand[2];
            bands[0] = new PixelBandUShort();
            bands[1] = new PixelBandUShort();
        }
        
        public int BandCount {
            get { return 2; }
        }
        
        public IPixelBand this[int index]
        {
            get { return bands[index]; }
        }
    }
}
