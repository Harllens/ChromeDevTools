using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Debugger
{
	/// <summary>
	/// Defines pause on exceptions state. Can be set to stop on all exceptions, uncaught exceptions or no exceptions. Initial pause on exceptions state is <code>none</code>.
	/// </summary>
	[Command(ProtocolName.Debugger.SetPauseOnExceptions)]
	public class SetPauseOnExceptionsCommand
	{
		/// <summary>
		/// Gets or sets Pause on exceptions mode.
		/// </summary>
		public string State { get; set; }
	}
}
