
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

namespace Mozu.Api.Clients.Commerce.Settings.General
{
	/// <summary>
	/// Use the Custom Routes resource to manage your custom route settings. Custom routing allows you to display SEO-friendly URLs on your site that map behind-the-scenes to conventional Mozu resources such as a product page or a search results page. With custom routing, you gain advanced control over the URL structures on your site and can more visibly highlight the products or categories your shoppers are interested in purchasing.To learn more about custom routing, refer to the [Mozu Admin Help](https://www.mozu.com/docs/admin/help/Settings/Configure_Custom_Routing.htm).
	/// </summary>
	public partial class CustomRouteSettingsClient 	{
		
		/// <summary>
		/// Retrieves the custom route settings configured for a site. These are the same settings configured through Mozu Admin in the Custom Routing JSON Editor.
		/// </summary>
		/// <param name="responseFields">A list or array of fields returned for a call. These fields may be customized and may be used for various types of data calls in Mozu. For example, responseFields are returned for retrieving or updating attributes, carts, and messages in Mozu.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.SiteSettings.General.General.Routing.CustomRouteSettings"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetCustomRouteSettings( responseFields);
		///   var customRouteSettingsClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.SiteSettings.General.General.Routing.CustomRouteSettings> GetCustomRouteSettingsClient(string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Settings.General.CustomRouteSettingsUrl.GetCustomRouteSettingsUrl(responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.SiteSettings.General.General.Routing.CustomRouteSettings>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// Create new custom route settings.
		/// </summary>
		/// <param name="responseFields">A list or array of fields returned for a call. These fields may be customized and may be used for various types of data calls in Mozu. For example, responseFields are returned for retrieving or updating attributes, carts, and messages in Mozu.</param>
		/// <param name="settings">Mozu.SiteSettings.General.Contracts.General.Routing.CustomRouteSettings ApiType DOCUMENT_HERE </param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.SiteSettings.General.General.Routing.CustomRouteSettings"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=CreateCustomRouteSettings( settings,  responseFields);
		///   var customRouteSettingsClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.SiteSettings.General.General.Routing.CustomRouteSettings> CreateCustomRouteSettingsClient(Mozu.Api.Contracts.SiteSettings.General.General.Routing.CustomRouteSettings settings, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Settings.General.CustomRouteSettingsUrl.CreateCustomRouteSettingsUrl(responseFields);
			const string verb = "POST";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.SiteSettings.General.General.Routing.CustomRouteSettings>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.SiteSettings.General.General.Routing.CustomRouteSettings>(settings);
			return mozuClient;

		}

		/// <summary>
		/// Updates custom route settings.
		/// </summary>
		/// <param name="responseFields">A list or array of fields returned for a call. These fields may be customized and may be used for various types of data calls in Mozu. For example, responseFields are returned for retrieving or updating attributes, carts, and messages in Mozu.</param>
		/// <param name="settings">Mozu.SiteSettings.General.Contracts.General.Routing.CustomRouteSettings ApiType DOCUMENT_HERE </param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.SiteSettings.General.General.Routing.CustomRouteSettings"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=UpdateCustomRouteSettings( settings,  responseFields);
		///   var customRouteSettingsClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.SiteSettings.General.General.Routing.CustomRouteSettings> UpdateCustomRouteSettingsClient(Mozu.Api.Contracts.SiteSettings.General.General.Routing.CustomRouteSettings settings, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Settings.General.CustomRouteSettingsUrl.UpdateCustomRouteSettingsUrl(responseFields);
			const string verb = "PUT";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.SiteSettings.General.General.Routing.CustomRouteSettings>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.SiteSettings.General.General.Routing.CustomRouteSettings>(settings);
			return mozuClient;

		}

		/// <summary>
		/// Deletes all the custom route settings for a site, returning all routes to their Mozu defaults.
		/// </summary>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=DeleteCustomRouteSettings();
		///mozuClient.WithBaseAddress(url).Execute();
		/// </code>
		/// </example>
		public static MozuClient DeleteCustomRouteSettingsClient()
		{
			var url = Mozu.Api.Urls.Commerce.Settings.General.CustomRouteSettingsUrl.DeleteCustomRouteSettingsUrl();
			const string verb = "DELETE";
			var mozuClient = new MozuClient()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}


	}

}


