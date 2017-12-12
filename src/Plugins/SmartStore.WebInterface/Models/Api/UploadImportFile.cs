﻿using System.Net.Http.Headers;
using System.Runtime.Serialization;

namespace SmartStore.WebInterface.Models.Api
{
	[DataContract]
	public partial class UploadImportFile : UploadFileBase
	{
		public UploadImportFile()
		{
		}

		public UploadImportFile(HttpContentHeaders headers) : base(headers)
		{
		}

		/// <summary>
		/// Whether the file type is supported by the import profile
		/// </summary>
		[DataMember]
		public bool IsSupportedByProfile { get; set; }
	}
}