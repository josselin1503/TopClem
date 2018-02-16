using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using TopSolid.Kernel.GR.Documents;
using TopSolid.Kernel.UI.Documents;
using TK = TopSolid.Kernel;

namespace Services.Marceau.UI.PaTAttack
{
    public class TiberiException : ApplicationException
    {
        public TiberiException(string message): base(message,new TiberiException("TiberiInception"))
        {

        }
    }

    /// <summary>
    /// Implement MenuCommand
    /// </summary>
    [Obfuscation(Exclude = true)]
    public class PaTAttackCommand : TK.WX.Commands.MenuCommand
	{
		// Constructors:

		/// <summary>
		/// Basic Menu Command
		/// </summary>
		public PaTAttackCommand()
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

            throw new TiberiException("Commande développée en 10 jours");
            
        }
      
    }
}
