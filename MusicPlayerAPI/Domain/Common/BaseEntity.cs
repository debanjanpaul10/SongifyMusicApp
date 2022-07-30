// ***********************************************
//	<copyright file="BaseEntity.cs" company="Personal">
//		Copyright (c) 2022 Personal
//	</copyright>
// ***********************************************

namespace Domain.Common
{
	using System.ComponentModel.DataAnnotations;

	/// <summary>
	/// Base Entity containing the Id that is common for all entities
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public abstract class BaseEntity<T>
	{
		/// <summary>
		/// Id field
		/// </summary>
		[Required]
		public virtual T Id { get; set; }
	}
}
