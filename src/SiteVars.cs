using Landis.Library.UniversalCohorts;
using Landis.SpatialModeling;

namespace Landis.Library.BiomassHarvest
{
    /// <summary>
    /// The library's site variables
    /// </summary>
    public static class SiteVars
    {
        private static ISiteVar<int> cohortsPartiallyDamaged;

        //---------------------------------------------------------------------
        /// <summary>
        /// Site variable with biomass cohorts
        /// </summary>
        public static ISiteVar<SiteCohorts> Cohorts { get; private set; }
        //---------------------------------------------------------------------
        /// <summary>
        /// Site variable counting cohorts partially damaged (not removed)
        /// </summary>
        public static ISiteVar<int> CohortsPartiallyDamaged
        {
            get
            {
                return cohortsPartiallyDamaged;
            }
            set
            {
                cohortsPartiallyDamaged = value;
            }
        }

        //---------------------------------------------------------------------

        /// <summary>
        /// Initializes the site variables.
        /// </summary>
        public static void Initialize()
        {
            Cohorts = Model.Core.GetSiteVar<SiteCohorts>("Succession.UniversalCohorts");
        }
    }
}
