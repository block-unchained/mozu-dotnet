
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


namespace Mozu.Api.Contracts.AppDev
{
		///
		///	Properties for a package for fulfillment and shipment. A package may include one to many products, or a bundle of products.
		///
		public class Package
		{
			///
			///Mozu.AppDev.Contracts.Package apiVersion ApiTypeMember DOCUMENT_HERE 
			///
			public string ApiVersion { get; set; }

			///
			///This will be used by the 3rd party developers to set a URL the intalled applications can call from the Tenant installation/
			///
			public string AppConfigUrl { get; set; }

			///
			///Unique identifier of an app available in your Mozu tenant or within Mozu Dev Center. This ID is unique across all apps installed, initialized, and enabled in the Mozu Admin and those in development through the Dev Center Console.
			///
			public string AppId { get; set; }

			///
			///App Key for the package in question.
			///
			public string AppKey { get; set; }

			///
			///Mozu.AppDev.Contracts.Package applicationAttributes ApiTypeMember DOCUMENT_HERE 
			///
			public List<ApplicationAttribute> ApplicationAttributes { get; set; }

			///
			///List of Application Behaviors that apply to this version of the application.
			///
			public List<ApplicationBehavior> ApplicationBehaviors { get; set; }

			///
			///Mozu.AppDev.Contracts.Package applicationCapabilities ApiTypeMember DOCUMENT_HERE 
			///
			public List<ApplicationCapability> ApplicationCapabilities { get; set; }

			///
			///Mozu.AppDev.Contracts.Package applicationCapabilityTypes ApiTypeMember DOCUMENT_HERE 
			///
			public List<ApplicationCapabilityType> ApplicationCapabilityTypes { get; set; }

			///
			///Mozu.AppDev.Contracts.Package applicationDescription ApiTypeMember DOCUMENT_HERE 
			///
			public string ApplicationDescription { get; set; }

			///
			///Mozu.AppDev.Contracts.Package applicationDetailId ApiTypeMember DOCUMENT_HERE 
			///
			public int? ApplicationDetailId { get; set; }

			///
			///Mozu.AppDev.Contracts.Package applicationEntitlements ApiTypeMember DOCUMENT_HERE 
			///
			public List<ApplicationEntitlement> ApplicationEntitlements { get; set; }

			///
			///Mozu.AppDev.Contracts.Package applicationId ApiTypeMember DOCUMENT_HERE 
			///
			public int ApplicationId { get; set; }

			///
			///Mozu.AppDev.Contracts.Package applicationName ApiTypeMember DOCUMENT_HERE 
			///
			public string ApplicationName { get; set; }

			///
			///This is the DevAccountId that owns the application
			///
			public int ApplicationOwnerDevAccountId { get; set; }

			///
			///Mozu.AppDev.Contracts.Package applicationStatus ApiTypeMember DOCUMENT_HERE 
			///
			public string ApplicationStatus { get; set; }

			///
			///Mozu.AppDev.Contracts.Package applicationStatusId ApiTypeMember DOCUMENT_HERE 
			///
			public int ApplicationStatusId { get; set; }

			///
			///Mozu.AppDev.Contracts.Package applicationStatusName ApiTypeMember DOCUMENT_HERE 
			///
			public string ApplicationStatusName { get; set; }

			///
			///Mozu.AppDev.Contracts.Package applicationSubscriptions ApiTypeMember DOCUMENT_HERE 
			///
			public List<ApplicationSubscription> ApplicationSubscriptions { get; set; }

			///
			///Mozu.AppDev.Contracts.Package applicationTypeId ApiTypeMember DOCUMENT_HERE 
			///
			public int ApplicationTypeId { get; set; }

			///
			///Mozu.AppDev.Contracts.Package applicationTypeName ApiTypeMember DOCUMENT_HERE 
			///
			public string ApplicationTypeName { get; set; }

			///
			///Mozu.AppDev.Contracts.Package appSchemeVersion ApiTypeMember DOCUMENT_HERE 
			///
			public byte AppSchemeVersion { get; set; }

			///
			///Mozu.AppDev.Contracts.Package assetFileCount ApiTypeMember DOCUMENT_HERE 
			///
			public int AssetFileCount { get; set; }

			///
			///Mozu.AppDev.Contracts.Package attributeNamespace ApiTypeMember DOCUMENT_HERE 
			///
			public string AttributeNamespace { get; set; }

			///
			///Mozu.AppDev.Contracts.Package dataNamespace ApiTypeMember DOCUMENT_HERE 
			///
			public string DataNamespace { get; set; }

			///
			///Mozu.AppDev.Contracts.Package hasApplicationVersions ApiTypeMember DOCUMENT_HERE 
			///
			public bool HasApplicationVersions { get; set; }

			///
			///Unique identifier of the source product property. For a product field it will be the name of the field. For a product attribute it will be the Attribute FQN. 
			///
			public int Id { get; set; }

			///
			///Indicates if the object is deleted. If true, the object has been deleted. This may affect associated child members and objects. For example, a deleted master catalog affects all associated catalogs. 
			///
			public bool IsDeleted { get; set; }

			///
			///Indicates if a customer account and associated data is locked. If true, the user account is locked due to multiple failed authentication attempts. The user cannot login until the account is unlocked.
			///
			public bool IsLocked { get; set; }

			///
			///Mozu.AppDev.Contracts.Package isReleasePackage ApiTypeMember DOCUMENT_HERE 
			///
			public bool IsReleasePackage { get; set; }

			///
			///Mozu.AppDev.Contracts.Package legacyNamespace ApiTypeMember DOCUMENT_HERE 
			///
			public string LegacyNamespace { get; set; }

			///
			///Mozu.AppDev.Contracts.Package majorVersion ApiTypeMember DOCUMENT_HERE 
			///
			public int MajorVersion { get; set; }

			///
			///Mozu.AppDev.Contracts.Package minorVersion ApiTypeMember DOCUMENT_HERE 
			///
			public int MinorVersion { get; set; }

			///
			///If applicable, the registered namespace associated with objects, used to generate the fully qualified name. If no namespace is defined, the namespace associated with the tenant is automatically assigned.
			///
			public string Namespace { get; set; }

			///
			///Mozu.AppDev.Contracts.Package namespaceRegistryId ApiTypeMember DOCUMENT_HERE 
			///
			public string NamespaceRegistryId { get; set; }

			///
			///Mozu.AppDev.Contracts.Package packageDescription ApiTypeMember DOCUMENT_HERE 
			///
			public string PackageDescription { get; set; }

			///
			///Mozu.AppDev.Contracts.Package packageGuid ApiTypeMember DOCUMENT_HERE 
			///
			public string PackageGuid { get; set; }

			///
			///Mozu.AppDev.Contracts.Package packageName ApiTypeMember DOCUMENT_HERE 
			///
			public string PackageName { get; set; }

			///
			///The parent theme AppKey if this is a theme and the theme extends a valid, published theme.
			///
			public string ParentThemeAppKey { get; set; }

			///
			///Mozu.AppDev.Contracts.Package parentThemeName ApiTypeMember DOCUMENT_HERE 
			///
			public string ParentThemeName { get; set; }

			///
			///Mozu.AppDev.Contracts.Package publishedParentSemanticVersion ApiTypeMember DOCUMENT_HERE 
			///
			public string PublishedParentSemanticVersion { get; set; }

			///
			///Mozu.AppDev.Contracts.Package publishedParentThemeId ApiTypeMember DOCUMENT_HERE 
			///
			public int? PublishedParentThemeId { get; set; }

			///
			///Mozu.AppDev.Contracts.Package revision ApiTypeMember DOCUMENT_HERE 
			///
			public int Revision { get; set; }

			///
			///Mozu.AppDev.Contracts.Package semanticVersionRange ApiTypeMember DOCUMENT_HERE 
			///
			public string SemanticVersionRange { get; set; }

			///
			///Mozu.AppDev.Contracts.Package sharedSecret ApiTypeMember DOCUMENT_HERE 
			///
			public string SharedSecret { get; set; }

			///
			///Mozu.AppDev.Contracts.Package themeEngineVersion ApiTypeMember DOCUMENT_HERE 
			///
			public string ThemeEngineVersion { get; set; }

			///
			///Whether or not there's a theme update.
			///
			public bool UpdateAvailable { get; set; }

			///
			///The AppKey is a runtime type. This only applies for themes that inherit from another theme. It shows the most current update available.
			///
			public string UpdateParentAppKey { get; set; }

			///
			///This only applies for themes that inherit from another theme. It shows the name of the most current update available.
			///
			public string UpdateParentThemeName { get; set; }

			///
			///This only applies for themes that inherit from another theme. It shows the version of the most current update available.
			///
			public string UpdateParentThemeVersion { get; set; }

			///
			///Unique identifier of the customer account (shopper or system user). System-supplied and read-only. If the shopper user is anonymous, the user ID represents a system-generated user ID string.
			///
			public string UserId { get; set; }

			///
			///List of Statuses that the application can move to during the application lifecycle. This is based on what the current value of the ApplicatinStatusId is.
			///
			public List<int> ValidApplicationStatusIdList { get; set; }

		}

}