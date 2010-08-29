//	Author: Jimm Domingo

using Wisc.Flel.GeospatialModeling.RasterIO;
using System;

namespace Wisc.Flel.GeospatialModeling.RasterDrivers.Erdas74
{
	/// <summary>
	/// A method to write a pixel value of type T for a band into a buffer.
	/// </summary>
	public delegate void WritePixelMethod<T>(T pixelValue);

   	//-------------------------------------------------------------------------

	/// <summary>
	/// A band in an output raster.  A band has a buffer to hold a single row
	/// of pixel-band values whose type is TRasterBand.  This buffer is filled
	/// with values from IPixelBand objects which are of type TPixelBand.
	/// </summary>
	public class OutputBand<TPixelBand, TRasterBand>
		: IOutputBand
		where TPixelBand : struct
		where TRasterBand : struct
	{
		private ConvertPixelMethod<TPixelBand, TRasterBand> convertPixel;
		private WritePixelMethod<TRasterBand> writeToBuffer;

		//---------------------------------------------------------------------

		public OutputBand(ConvertPixelMethod<TPixelBand, TRasterBand> convertMethod,
						  WritePixelMethod<TRasterBand>		          writeToBufferMethod)
		{
			this.convertPixel = convertMethod;
			this.writeToBuffer = writeToBufferMethod;
		}

		//---------------------------------------------------------------------

		public void AppendPixel(IPixelBand pixelBand)
		{
			IPixelBandValue<TPixelBand> band = pixelBand as IPixelBandValue<TPixelBand>;
			if (band == null)
				throw new ArgumentException(string.Format("band parameter is not a IPixelBandValue<{0}> object",
														  typeof(TPixelBand).Name));

			writeToBuffer(convertPixel(band.Value));
			// TODO: wrap the statement above in try-catch block in order to
			// check for buffer overflow (not sure which exception is thrown
			// by BinaryWriter with MemoryStream backing store).
		}
	}
}
