namespace Wisc.Flel.GeospatialModeling.RasterDrivers.Erdas74
{
	/// <summary>
	/// Types of projections.
	/// </summary>
	/// <remarks>
	/// Reference: Document "Using ERDAS Ver. 7.X Files Within IMAGINE",
	/// section "PRO Files - Projection Parameters".
	/// </remarks>
	public enum Projections
	{
		UTM = 1,
		StatePlane = 2,
		AlbersConicalEqualArea = 3,
		LambertConformalConic = 4,
		Mercator = 5,
		PolarStereographic = 6,
		Polyconic = 7,
		EquidistantConic = 8,
		TransverseMercator = 9,
		Stereographic = 10,
		LambertAzimuthalEqualArea = 11,
		AzimuthalEquidistant = 12,
		Gnomonic = 13,
		Orthographic = 14,
		GeneralVerticalNearSidePerspective = 15,
		Sinusoidal = 16,
		Equirectangular = 17,
		MillerCylindrical = 18,
		VanDerGrinten = 19,
		ObliqueMercator = 20
	}
}
