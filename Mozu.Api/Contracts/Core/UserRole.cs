
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Codezu.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;


namespace Mozu.Api.Contracts.Core
{
		///
		///	Properties of a role assigned to a user for a defined scope.
		///
		public class UserRole
		{
			public UserScope AssignedInScope { get; set; }

			public AuditInfo AuditInfo { get; set; }

			public int RoleId { get; set; }

			public string RoleName { get; set; }

			public string UserId { get; set; }

		}

}