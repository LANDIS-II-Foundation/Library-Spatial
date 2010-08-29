//	Author: Jimm Domingo

using System;

namespace Wisc.Flel.GeospatialModeling.RasterDrivers.Erdas74
{
	/// <summary>
	/// Methods for working with band types.
	/// </summary>
	public static class BandType
	{
		public static string GetDescription(TypeCode bandType)
		{
			switch (bandType) {
				case TypeCode.Byte:
					return "8-bit unsigned integers";

				case TypeCode.SByte:
					return "8-bit signed integers";

				case TypeCode.Int16:
					return "16-bit signed integers";

				case TypeCode.UInt16:
					return "16-bit unsigned integers";

				case TypeCode.Int32:
					return "32-bit signed integers";

				case TypeCode.UInt32:
					return "32-bit unsigned integers";

				case TypeCode.Single:
					return "32-bit floating-point numbers";

				case TypeCode.Double:
					return "64-bit floating-point numbers";

				default:
					throw new ArgumentException();
			}
		}

		//---------------------------------------------------------------------

		public static string GetDescription(Type bandType)
		{
			return GetDescription(Type.GetTypeCode(bandType));
		}
	}
}
