using TopSolid.Kernel.SX.Resources;

namespace Services.Marceau.AddIn
{
    /// <summary>
    /// Sample Resource AddIn
    /// </summary>
    public static class Resources
	{
		/// <summary>
		/// Instance of ResourceManager.
		/// </summary>
		private static ResourceManager instance = null;

		/// <summary>
		/// Getter
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
