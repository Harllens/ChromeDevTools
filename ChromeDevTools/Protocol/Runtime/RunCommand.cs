using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Runtime
{
	/// <summary>
	/// Tells inspected instance(worker or page) that it can run in case it was started paused.
	/// </summary>
	[Command(ProtocolName.Runtime.Run)]
	public class RunCommand
	{
	}
}
