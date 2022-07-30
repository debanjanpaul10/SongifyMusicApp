// ***********************************************
//	<copyright file="User.cs" company="Personal">
//		Copyright (c) 2022 Personal
//	</copyright>
// ***********************************************

namespace Domain.Master
{
	using System.ComponentModel.DataAnnotations;
	using Domain.Common;
	
	/// <summary>
	/// User entity class
	/// </summary>
	public class User : BaseEntity<int>
	{
		/// <summary>
		/// User Email Id
		/// </summary>
		[Required]
		public string Email { get; set; }

		/// <summary>
		/// User's name
		/// </summary>
		[Required]
		public string Name { get; set; }
	}
}
