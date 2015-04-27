using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.CacheStorage
{
	/// <summary>
	/// Requests data from cache.
	/// </summary>
	[CommandResponse(ProtocolName.CacheStorage.RequestEntries)]
	public class RequestEntriesCommandResponse
	{
		/// <summary>
		/// Gets or sets Array of object store data entries.
		/// </summary>
		public DataEntry[] CacheDataEntries { get; set; }
		/// <summary>
		/// Gets or sets If true, there are more entries to fetch in the given range.
		/// </summary>
		public bool HasMore { get; set; }
	}
}
