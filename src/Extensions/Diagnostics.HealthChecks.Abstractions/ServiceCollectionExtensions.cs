// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license.

using System.Net;
using System.Net.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using Microsoft.Extensions.ObjectPool;
using Microsoft.Omex.Extensions.Diagnostics.HealthChecks.Abstractions;

namespace Microsoft.Omex.Extensions.Diagnostics.HealthChecks.Abstractions
{
	/// <summary>
	/// Extension to add Omex dependencies to IServiceCollection
	/// </summary>
	public static class ServiceCollectionExtensions
	{
		/// <summary>
		/// Register publisher using Dependency Injection
		/// </summary>
		public static IServiceCollection AddHealthCheckPublisher<TPublisher>(this IServiceCollection serviceCollection)
			where TPublisher : class, IHealthCheckPublisher
		{
			serviceCollection.TryAddEnumerable(ServiceDescriptor.Singleton<IHealthCheckPublisher, TPublisher>());
			return serviceCollection;
		}
	}
}
