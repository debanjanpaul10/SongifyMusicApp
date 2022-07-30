// ***********************************************
//	<copyright file="Song.cs" company="Personal">
//		Copyright (c) 2022 Personal
//	</copyright>
// ***********************************************

namespace Domain.Master
{
	using System.ComponentModel.DataAnnotations;
	using Domain.Common;

	/// <summary>
	/// Song entity class
	/// </summary>
	public class Song : BaseEntity<int>
	{
		/// <summary>
		/// Song name
		/// </summary>
		[Required]
		public string Name { get; set; }

		/// <summary>
		/// Song's date of release
		/// </summary>
		[Required]
		public DateTime DateOfRelease { get; set; }

		/// <summary>
		/// Song's cover image url
		/// </summary>
		[Required]
		public string ImageUrl { get; set; }

		/// <summary>
		/// One song can be sung by multiple artists
		/// </summary>
		public List<Artist> Artists { get; set; }
	}
}
