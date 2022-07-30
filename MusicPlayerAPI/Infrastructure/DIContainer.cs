// ***********************************************
//	<copyright file="DIContainer.cs" company="Personal">
//		Copyright (c) 2022 Personal
//	</copyright>
// ***********************************************

namespace Infrastructure
{
	using Application.Common.Contracts;
	using Infrastructure.Persistence;
	using Microsoft.EntityFrameworkCore;
	using Microsoft.Extensions.Configuration;
	using Microsoft.Extensions.DependencyInjection;

	/// <summary>
	/// Dependency injection class
	/// </summary>
	public static class DIContainer
	{
		/// <summary>
		/// Adding the reference to database with the help of connection string to create migrations
		/// </summary>
		/// <param name="services">IServiceCollection class init</param>
		/// <param name="configuration">IConfiguration class init</param>
		/// <returns>IServiceCollection variable services</returns>
		public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
		{
			services.AddDbContext<ApplicationDbContext>(options =>
				options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"),
				b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)), ServiceLifetime.Transient
			);

			services.AddScoped<IApplicationDbContext>(provider => provider.GetService<ApplicationDbContext>());
			return services;
		}
	}
}
