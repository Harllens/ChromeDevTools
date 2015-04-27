using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Database
{
	/// <summary>
	/// Database error.
	/// </summary>
	public class Error
	{
		/// <summary>
		/// Gets or sets Error message.
		/// </summary>
		public string Message { get; set; }
		/// <summary>
		/// Gets or sets Error code.
		/// </summary>
		public long Code { get; set; }
	}
}
