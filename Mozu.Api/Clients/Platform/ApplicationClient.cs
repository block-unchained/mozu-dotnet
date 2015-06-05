
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

namespace Mozu.Api.Clients.Platform
{
	/// <summary>
	/// platform/developer related resources. DOCUMENT_HERE 
	/// </summary>
	public partial class ApplicationClient 	{
		
		/// <summary>
		/// platform-developer Get GetAppPackageNames description DOCUMENT_HERE 
		/// </summary>
		/// <param name="applicationKey"></param>
		/// <param name="responseFields">A list or array of fields returned for a call. These fields may be customized and may be used for various types of data calls in Mozu. For example, responseFields are returned for retrieving or updating attributes, carts, and messages in Mozu.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.AppDev.PackageNamesCollection"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetAppPackageNames( applicationKey,  responseFields);
		///   var packageNamesCollectionClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.AppDev.PackageNamesCollection> GetAppPackageNamesClient(string applicationKey, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Platform.ApplicationUrl.GetAppPackageNamesUrl(applicationKey, responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.AppDev.PackageNamesCollection>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// platform-developer Get GetAppVersions description DOCUMENT_HERE 
		/// </summary>
		/// <param name="nsAndAppId"></param>
		/// <param name="responseFields">A list or array of fields returned for a call. These fields may be customized and may be used for various types of data calls in Mozu. For example, responseFields are returned for retrieving or updating attributes, carts, and messages in Mozu.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.AppDev.ApplicationVersionsCollection"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetAppVersions( nsAndAppId,  responseFields);
		///   var applicationVersionsCollectionClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.AppDev.ApplicationVersionsCollection> GetAppVersionsClient(string nsAndAppId, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Platform.ApplicationUrl.GetAppVersionsUrl(nsAndAppId, responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.AppDev.ApplicationVersionsCollection>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// platform-developer Get GetPackageFileMetadata description DOCUMENT_HERE 
		/// </summary>
		/// <param name="applicationKey"></param>
		/// <param name="filepath"></param>
		/// <param name="responseFields">A list or array of fields returned for a call. These fields may be customized and may be used for various types of data calls in Mozu. For example, responseFields are returned for retrieving or updating attributes, carts, and messages in Mozu.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.AppDev.FileMetadata"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetPackageFileMetadata( applicationKey,  filepath,  responseFields);
		///   var fileMetadataClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.AppDev.FileMetadata> GetPackageFileMetadataClient(string applicationKey, string filepath, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Platform.ApplicationUrl.GetPackageFileMetadataUrl(applicationKey, filepath, responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.AppDev.FileMetadata>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// platform-developer Get GetPackageMetadata description DOCUMENT_HERE 
		/// </summary>
		/// <param name="applicationKey"></param>
		/// <param name="responseFields">A list or array of fields returned for a call. These fields may be customized and may be used for various types of data calls in Mozu. For example, responseFields are returned for retrieving or updating attributes, carts, and messages in Mozu.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.AppDev.FolderMetadata"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetPackageMetadata( applicationKey,  responseFields);
		///   var folderMetadataClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.AppDev.FolderMetadata> GetPackageMetadataClient(string applicationKey, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Platform.ApplicationUrl.GetPackageMetadataUrl(applicationKey, responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.AppDev.FolderMetadata>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// platform-developer Post UpsertPackageFile description DOCUMENT_HERE 
		/// </summary>
		/// <param name="applicationKey"></param>
		/// <param name="filepath"></param>
		/// <param name="lastModifiedTime"></param>
		/// <param name="responseFields">A list or array of fields returned for a call. These fields may be customized and may be used for various types of data calls in Mozu. For example, responseFields are returned for retrieving or updating attributes, carts, and messages in Mozu.</param>
		/// <param name="stream">Data stream that delivers information. Used to input and output data.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.AppDev.FileMetadata"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=UpsertPackageFile( stream,  applicationKey,  filepath,  lastModifiedTime,  responseFields,  contentType);
		///   var fileMetadataClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.AppDev.FileMetadata> UpsertPackageFileClient(System.IO.Stream stream, string applicationKey, string filepath, string lastModifiedTime =  null, string responseFields =  null, String  contentType= null)
		{
			var url = Mozu.Api.Urls.Platform.ApplicationUrl.UpsertPackageFileUrl(applicationKey, filepath, lastModifiedTime, responseFields);
			const string verb = "POST";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.AppDev.FileMetadata>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody(stream)									.WithHeader(Headers.CONTENT_TYPE ,contentType)
;
			return mozuClient;

		}

		/// <summary>
		/// platform-developer Post RenamePackageFile description DOCUMENT_HERE 
		/// </summary>
		/// <param name="applicationKey"></param>
		/// <param name="responseFields">A list or array of fields returned for a call. These fields may be customized and may be used for various types of data calls in Mozu. For example, responseFields are returned for retrieving or updating attributes, carts, and messages in Mozu.</param>
		/// <param name="renameInfo">Information required to update the name of a file in a package, which consists of the original name and the new name.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.AppDev.FileMetadata"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=RenamePackageFile( renameInfo,  applicationKey,  responseFields);
		///   var fileMetadataClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.AppDev.FileMetadata> RenamePackageFileClient(Mozu.Api.Contracts.AppDev.RenameInfo renameInfo, string applicationKey, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Platform.ApplicationUrl.RenamePackageFileUrl(applicationKey, responseFields);
			const string verb = "POST";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.AppDev.FileMetadata>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.AppDev.RenameInfo>(renameInfo);
			return mozuClient;

		}

		/// <summary>
		/// platform-developer Delete DeletePackageFile description DOCUMENT_HERE 
		/// </summary>
		/// <param name="applicationKey"></param>
		/// <param name="filepath"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=DeletePackageFile( applicationKey,  filepath);
		///mozuClient.WithBaseAddress(url).Execute();
		/// </code>
		/// </example>
		public static MozuClient DeletePackageFileClient(string applicationKey, string filepath)
		{
			var url = Mozu.Api.Urls.Platform.ApplicationUrl.DeletePackageFileUrl(applicationKey, filepath);
			const string verb = "DELETE";
			var mozuClient = new MozuClient()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}


	}

}


