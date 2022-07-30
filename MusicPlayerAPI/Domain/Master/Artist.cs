// ***********************************************
//	<copyright file="Artist.cs" company="Personal">
//		Copyright (c) 2022 Personal
//	</copyright>
// ***********************************************

namespace Domain.Master
{
	using System.ComponentModel.DataAnnotations;
	using Domain.Common;

	/// <summary>
	/// Artist entity class
	/// </summary>
	public class Artist : BaseEntity<int>
	{
		/// <summary>
		/// Artist name
		/// </summary>
		[Required]
		public string Name { get; set; }

		/// <summary>
		/// Artist Date of birth
		/// </summary>
		[Required]
		public DateTime DOB { get; set; }

		/// <summary>
		/// Artist bio
		/// </summary>
		[Required]
		public string Bio { get; set; }

		/// <summary>
		/// Single artist can sing multiple songs
		/// </summary>
		public List<Song> Songs { get; set; }
	}
}
