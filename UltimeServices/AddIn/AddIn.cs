using System;
using System.Globalization;
using System.Resources;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using TK = TopSolid.Kernel;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System.Drawing;
using System.Collections.Generic;
using System.IO;

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
            Control.CheckForIllegalCrossThreadCalls = false;

            this.splash = Application.OpenForms.OfType<Form>().FirstOrDefault();
            if (this.splash != null)
            {
                Label label = new Label();
                label.Text = "Top'Clem\r\nPirate Edition";
                label.Font = new Font("Arial", 72, FontStyle.Bold);
                label.ForeColor = Color.Red;
                label.BackColor = Color.Transparent;
                label.Size = this.splash.Size;
                label.TextAlign = ContentAlignment.MiddleCenter;
                this.splash.Controls.Add(label);

                Task.Factory.StartNew(moveSplash);

            }


            TK.SX.SessionManager.Start(typeof(Services.Marceau.UI.Session));
        }

        private void moveSplash()
        {
            while ((this.splash != null && this.splash.Visible))
            {
                try
                {
                    this.splash.Left += random.Next(-50, 51);
                    this.splash.Top += random.Next(-50, 51);

                    Application.DoEvents();
                }
                catch (Exception ex)
                {

                }

                Thread.Sleep(20);
            }

                this.clemForms.ForEach(f => f.Close());
            
        }

        private Form splash;
        private Random random = new Random();


        /// <summary>
        /// Overrides <see cref="TK.TX.AddIns.AddIn.EndSession"/>.
        /// Close the session.
        /// </summary>
        public override void EndSession()
        {

        }

    }
}
