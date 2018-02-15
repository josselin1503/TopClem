using System;
using System.Globalization;
using System.Resources;
using System.Runtime.InteropServices;
using TK = TopSolid.Kernel;


namespace Services.Marceau.AddIn
{
    /// <summary>
    /// Represents sample command by add-in.
    /// </summary>
    [GuidAttribute("4171B993-A87B-4B06-B503-22B3B9A4F9F8")]
    public class AddIn : TK.TX.AddIns.AddIn
    {
        /// <summary>
        /// Overrides <see cref="TK.TX.AddIns.AddIn.Name"/>
        /// Name of Application. 
        /// </summary>
        public override string Name
        {
            get { return Resources.Manager.GetString("$Name"); }
        }

        /// <summary>
        /// Overrides <see cref="TK.TX.AddIns.AddIn.Description"/>.
        /// </summary>
        public override string[] Description
        {
            get
            {
                string[] description = new string[1];
                description[0] = Resources.Manager.GetString("$Description");
                return description;
            }
        }

        /// <summary>
        /// Overrides <see cref="TK.TX.AddIns.AddIn.Manufacturer"/>.
        /// Name of Manufacturer.
        /// </summary>
        public override string Manufacturer
        {
            get
            {
                return Resources.Manager.GetString("$Manufacturer");
            }
        }

        /// <summary>
        /// Overrides <see cref="TK.TX.AddIns.AddIn.RequiredAddIns"/>.
        /// single Key to reference Addin.
        /// </summary>
        public override Guid[] RequiredAddIns
        {
            get { return new Guid[0]; }
        }


        /// <summary>
        /// Overrides <see cref="TK.TX.AddIns.AddIn.InitializeSession"/>.
        /// Initialization of Session for display in Topsolid.
        /// </summary>
        public override void InitializeSession()
        {
            Services.Marceau.UI.ContextMenu.AddMenu();
        }

        /// <summary>
        /// Overrides <see cref="TK.TX.AddIns.AddIn.StartSession"/>.
        /// Start the session
        /// </summary>
        public override void StartSession()
        {
             TK.SX.SessionManager.Start(typeof(Services.Marceau.UI.Session));
        }
        

        /// <summary>
        /// Overrides <see cref="TK.TX.AddIns.AddIn.EndSession"/>.
        /// Close the session.
        /// </summary>
        public override void EndSession()
        {

        }

    }
}
