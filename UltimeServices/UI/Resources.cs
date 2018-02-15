using TopSolid.Kernel.SX.Resources;

namespace Services.Marceau.UI
{
    /// <summary>
    /// Sample Command AddIn
    /// </summary>
    public static class Resources
    {
        /// <summary>
        /// Create an instance of ResourceManager.
        /// </summary>
        private static ResourceManager instance = null;

        /// <summary>
        /// Container of project resources. 
        /// </summary>
        public static ResourceManager Manager
        {
            get
            {
                if (instance == null)
                {
                    instance = new ResourceManager(typeof(Resources));
                }
                return instance;
            }
        }

        
    }
}
