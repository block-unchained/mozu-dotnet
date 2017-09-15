
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
using Mozu.Api.Security;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using System.Threading;

namespace Mozu.Api.Clients.Commerce.Orders
{
	/// <summary>
	/// Use the shipments resource to manage shipments of collections of packages for an order.
	/// </summary>
	public partial class ShipmentClient 	{
		
		/// <summary>
		/// Retrieves the details of the order shipment specified in the request.
		/// </summary>
		/// <param name="orderId">Unique identifier of the order associated with the shipment to retrieve.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="shipmentId">Unique identifier of the shipment to retrieve.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Fulfillment.Shipment"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetShipment( orderId,  shipmentId,  responseFields);
		///   var shipmentClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Fulfillment.Shipment> GetShipmentClient(string orderId, string shipmentId, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Orders.ShipmentUrl.GetShipmentUrl(orderId, shipmentId, responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.CommerceRuntime.Fulfillment.Shipment>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// Retrieves the available shipping methods applicable to the order. Typically used to display available shipping method options on the checkout page.
		/// </summary>
		/// <param name="draft"></param>
		/// <param name="orderId">Unique identifier of the order for the available shipment methods being retrieved.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{List{<see cref="Mozu.Api.Contracts.CommerceRuntime.Fulfillment.ShippingRate"/>}}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetAvailableShipmentMethods( orderId,  draft);
		///   var shippingRateClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<List<Mozu.Api.Contracts.CommerceRuntime.Fulfillment.ShippingRate>> GetAvailableShipmentMethodsClient(string orderId, bool? draft =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Orders.ShipmentUrl.GetAvailableShipmentMethodsUrl(orderId, draft);
			const string verb = "GET";
			var mozuClient = new MozuClient<List<Mozu.Api.Contracts.CommerceRuntime.Fulfillment.ShippingRate>>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// Creates a shipment from one or more package associated with an order and assign a label and tracking number to an order shipment.
		/// </summary>
		/// <param name="orderId">Unique identifier of the order for this shipment.</param>
		/// <param name="packageIds">List of unique identifiers for each package associated with this shipment. Not all packages must belong to the same shipment.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{List{<see cref="Mozu.Api.Contracts.CommerceRuntime.Fulfillment.Package"/>}}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=CreatePackageShipments( packageIds,  orderId);
		///   var packageClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<List<Mozu.Api.Contracts.CommerceRuntime.Fulfillment.Package>> CreatePackageShipmentsClient(List<string> packageIds, string orderId)
		{
			var url = Mozu.Api.Urls.Commerce.Orders.ShipmentUrl.CreatePackageShipmentsUrl(orderId);
			const string verb = "POST";
			var mozuClient = new MozuClient<List<Mozu.Api.Contracts.CommerceRuntime.Fulfillment.Package>>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody(packageIds);
			return mozuClient;

		}

		/// <summary>
		/// Deletes the shipment specified in the request.
		/// </summary>
		/// <param name="orderId">Unique identifier of the order to cancel shipment.</param>
		/// <param name="shipmentId">Unique identifier of the shipment to cancel.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=DeleteShipment( orderId,  shipmentId);
		///mozuClient.WithBaseAddress(url).Execute();
		/// </code>
		/// </example>
		public static MozuClient DeleteShipmentClient(string orderId, string shipmentId)
		{
			var url = Mozu.Api.Urls.Commerce.Orders.ShipmentUrl.DeleteShipmentUrl(orderId, shipmentId);
			const string verb = "DELETE";
			var mozuClient = new MozuClient()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}


	}

}


