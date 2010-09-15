namespace LandisII.Examples.SimpleCore
{
    /// <summary>
    /// Example of core interface passed to LANDIS-II extensions.
    /// </summary>
    public interface ICore : Landis.SpatialModeling.IRasterFactory
    {
        /// <summary>
        /// Current timestep (year).
        /// </summary>
        int CurrentTime
        {
            get;
        }
    }
}
