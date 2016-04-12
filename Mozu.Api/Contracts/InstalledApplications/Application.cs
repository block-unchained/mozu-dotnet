
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


namespace Mozu.Api.Contracts.InstalledApplications
{
		///
		///	Properties of an app installed in a tenant.
		///
		public class Application
		{
			///
			///Unique identifier of an app available in your Mozu tenant or within Mozu Dev Center. This ID is unique across all apps installed, initialized, and enabled in the Mozu Admin and those in development through the Dev Center Console.
			///
			public string AppId { get; set; }

			///
			///denotes the Application Key for the app.
			///
			public string AppKey { get; set; }

			///
			///List of capabilities installed in a tenant.
			///
			public List<Capability> Capabilities { get; set; }

			///
			///Indicates if the capability or app is enabled for the tenant/site. If true, the capability/application is enabled for the tenant. System-supplied and read-only.
			///
			public bool? Enabled { get; set; }

			///
			///Indicates if an app is initialized and capable of being enabled in the tenant and site. Apps will need to be installed and configured to become initialized, such as validating credentials and/or API keys with a third-party service. If true, the app is initialized and can be enabled for usage.
			///
			public bool? Initialized { get; set; }

			///
			///Indicates if the installed application is of type extension. If true, the application type is Extension.
			///
			public bool? IsExtension { get; set; }

			///
			///denotes if the Application is certified to use extension
			///
			public bool? IsExtensionCertified { get; set; }

			///
			///The URL defined for the application that represents the configuration website for the capability. This value is used by installed applications or the site.
			///
			public string UiConfigurationUrl { get; set; }

		}

}