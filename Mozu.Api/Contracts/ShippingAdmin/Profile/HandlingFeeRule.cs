
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
using Mozu.Api.Contracts.ShippingAdmin;

namespace Mozu.Api.Contracts.ShippingAdmin.Profile
{
		///
		///	Mozu.ShippingAdmin.Contracts.Profile.HandlingFeeRule ApiType DOCUMENT_HERE 
		///
		public class HandlingFeeRule
		{
			///
			///Specifies to what the handling fee rule applies.
			///
			public string AppliesTo { get; set; }

			///
			///Basic audit info about the object, including date, time, and user account. This data may be captured when creating, updating, and removing data.
			///
			public AuditInfo AuditInfo { get; set; }

			///
			///Unique identifier of the source property, such as a catalog, discount, order, or email template.For a product field it will be the name of the field.For a category ID, must be a positive integer not greater than 2000000. By default,  auto-generates a category ID when categories are created. If you want to specify an ID during creation (which preserves category link relationships when migrating tenant data from one sandbox to another), you must also include the  query string in the endpoint. For example, . Then, use the  property to specify the desired category ID.For a product attribute it will be the Attribute FQN.For a document, the ID must be specified as a 32 character, case-insensitive, alphanumeric string. You can specify the ID as 32 sequential characters or as groups separated by dashes in the format 8-4-4-4-12. For example, or.For email templates, the ID must be one of the following values:///
			///
			public string Id { get; set; }

			///
			///The unique codes of any product rules associated with the handling fee.
			///
			public List<string> ProductTargetRuleCodes { get; set; }

			///
			///The numeric order of objects, used by a vocabulary value defined for an extensible attribute, images, and categories.
			///
			public int Sequence { get; set; }

			///
			///An array of service type details that are associated with the handling fee.
			///
			public List<ServiceType> ServiceTypes { get; set; }

			///
			///The unique codes of any shipping target rules associated with the handling fee.
			///
			public List<string> ShippingTargetRuleCodes { get; set; }

			///
			///The value of a property, used by numerous objects within  including facets, attributes, products, localized content, metadata, capabilities ( and third-party), location inventory adjustment, and more. The value may be a string, integer, or double. Validation may be run against the entered and saved values depending on the object type.
			///
			public decimal Value { get; set; }

			///
			///An attribute value type is either predefined vocabulary by the admin during attribute set up or user-defined with an appropriate type (AdminEntered or ShopperEntered depending on the user). These types are used by products and attributes. The difference between predefined values versus manually entered values is such that the first choice is a set of options to choose from. AdminEntered and ShopperEntered are values that are entered rather than system-supplied and are not stored in the database, but captured during a live commerce operations such as during an order.
			///
			public string ValueType { get; set; }

		}

}