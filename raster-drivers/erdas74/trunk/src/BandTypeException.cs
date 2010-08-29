//	Author: Jimm Domingo

using System;

namespace Wisc.Flel.GeospatialModeling.RasterDrivers.Erdas74
{
	/// <summary>
	/// Represents an error with a data type of a pixel band.
	/// </summary>
	internal class BandTypeException
		: ApplicationException
	{
		internal BandTypeException(string          message,
		                           params object[] mesgArgs)
			: base(string.Format(message, mesgArgs))
		{
		}
	}
}
