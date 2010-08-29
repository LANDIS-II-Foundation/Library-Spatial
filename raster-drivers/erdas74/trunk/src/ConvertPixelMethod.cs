//	Author: Jimm Domingo

namespace Wisc.Flel.GeospatialModeling.RasterDrivers.Erdas74
{
	/// <summary>
	/// A method to convert a pixel-band value from type TFrom to type TTo.
	/// </summary>
	public delegate TTo ConvertPixelMethod<TFrom, TTo>(TFrom pixel);
}
