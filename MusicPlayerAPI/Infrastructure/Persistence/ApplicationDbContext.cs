// ***********************************************
//	<copyright file="ApplicationDbContext.cs" company="Personal">
//		Copyright (c) 2022 Personal
//	</copyright>
// ***********************************************

namespace Infrastructure.Persistence
{
	using Application.Common.Contracts;
	using Domain.Master;
	using Microsoft.EntityFrameworkCore;

	/// <summary>
	/// ApplicationDbContext class to create migrations and table in database
	/// </summary>
	public class ApplicationDbContext : DbContext, IApplicationDbContext
	{
		/// <summary>
		/// Initialize constructor for <see cref="ApplicationDbContext"/>
		/// </summary>
		/// <param name="options">EntityFrameworkCore options passed</param>
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
			: base(options)
		{

		}

		#region DbSet
		public DbSet<Artist> Artists { get; set; }
		public DbSet<Song> Songs { get; set; }
		public DbSet<User> Users { get; set; }
		#endregion
	}
}
