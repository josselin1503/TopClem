using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using TopSolid.Kernel.GR.Documents;
using TopSolid.Kernel.UI.Documents;
using TK = TopSolid.Kernel;

namespace Services.Marceau.UI.BasicMenu
{
    /// <summary>
    /// Implement MenuCommand
    /// </summary>
    [Obfuscation(Exclude = true)]
    public class BasicMenuCommand : TK.WX.Commands.MenuCommand
	{
		// Constructors:

		/// <summary>
		/// Basic Menu Command
		/// </summary>
		public BasicMenuCommand()
		{
            
		}
        

        /// <summary>
        /// Returns true if the command is available, else returns false
        /// BEWARE: this property is called to evaluate the command availability on the GUI. 
        ///         The process must be fast to avoid slowing the TopSolid GUI.
        ///         So try not using Search functions or a loop for example.
        /// </summary>
        protected override bool CanInvoke
        {
            get
            {
                // by default return the parent CanInvoke result 
                return base.CanInvoke;           
            }
        }
        /// <summary>
        /// Tells whether a current document is needed (default: true).
        /// </summary>
        protected override bool NeedsCurrentDocument { get { return false; } }

        /// <summary>
        /// {D255958A-8513-4226-94B9-080D98F904A1}Tells whether the command modifies the current document.
        /// </summary>
        /// <remarks>
        /// {D255958A-8513-4226-94B9-080D98F904A1}The default value is true.
        /// {D255958A-8513-4226-94B9-080D98F904A1}<para>In the base class implementation this property is <c>true</c>, it must be
        /// {D255958A-8513-4226-94B9-080D98F904A1}overridden in the derived command classes that do not modify the current document.</para></remarks>
        protected override bool ModifiesCurrentDocument { get { return false; } }

        /// <summary>
        /// Function executed when the command is called
        /// </summary>
        protected override void Invoke()
        {
            //First, invoke the Invoke() parent methods
            base.Invoke();

            //Then, execute our code
            //...

            Random rd = new Random();
            List<int> values = new List<int>();
            List<int> tmpVal = new List<int>();
            for (int j = 0; j < 100000; j++)
            {
                for (int k = 0; k < 10000; k++)
                {
                    tmpVal.Add(rd.Next());
                }

                values.Add(tmpVal[rd.Next(0,tmpVal.Count -1)]);
            }

            ////In this case, display a MessageBox with a little message
            TopSolid.Kernel.WX.MessageBox.Show(Resources.Manager.GetString("CommandMessage"));

            //Crash TopSolid !
            IntPtr ptr = new IntPtr(123);
            Marshal.StructureToPtr(123, ptr, true);
        }
      
    }
}
