
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Codezu.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

using Mozu.Api.Contracts.Core;
using Mozu.Api.Contracts.CommerceRuntime.Commerce;

namespace Mozu.Api.Contracts.CommerceRuntime.Fulfillment
{
		public class DigitalPackage
		{
			public List<string> AvailableActions { get; set; }

			public string Code { get; set; }

			public DateTime? FulfillmentDate { get; set; }

			public string FulfillmentLocationCode { get; set; }

			public string Id { get; set; }

			public string Status { get; set; }

			public AuditInfo AuditInfo { get; set; }

			public List<ChangeMessage> ChangeMessages { get; set; }

			public List<DigitalPackageItem> Items { get; set; }

		}

}