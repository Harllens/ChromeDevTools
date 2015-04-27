using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.DeviceOrientation
{
	/// <summary>
	/// Overrides the Device Orientation.
	/// </summary>
	[Command(ProtocolName.DeviceOrientation.SetDeviceOrientationOverride)]
	public class SetDeviceOrientationOverrideCommand
	{
		/// <summary>
		/// Gets or sets Mock alpha
		/// </summary>
		public double Alpha { get; set; }
		/// <summary>
		/// Gets or sets Mock beta
		/// </summary>
		public double Beta { get; set; }
		/// <summary>
		/// Gets or sets Mock gamma
		/// </summary>
		public double Gamma { get; set; }
	}
}
