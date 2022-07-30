// ***********************************************
//	<copyright file="IApplicationDbContext.cs" company="Personal">
//		Copyright (c) 2022 Personal
//	</copyright>
// ***********************************************

namespace Application.Common.Contracts
{
	using Domain.Master;
	using Microsoft.EntityFrameworkCore;

	/// <summary>
	/// Interface for the Application Db Context
	/// </summary>
	public interface IApplicationDbContext
	{
		DbSet<Artist> Artists { get; set; }
		DbSet<Song> Songs { get; set; }
		DbSet<User> Users { get; set; }
	}
}
