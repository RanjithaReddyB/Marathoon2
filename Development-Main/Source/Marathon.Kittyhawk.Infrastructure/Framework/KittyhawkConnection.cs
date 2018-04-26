using AMS.ConnectionStrings.Services;
using CacheManager.Core;
using Marathon.Kittyhawk.Services;

namespace Marathon.Kittyhawk.Infrastructure.Framework
{
	public class KittyhawkConnection
	{
		private static ICacheManager<object> cache;

		public static string ConnectionString
		{
			get
			{
				if (cache == null)
				{
					cache = CacheFactory.Build(cacheName: "KittyhawkCache", settings: settings =>
					{
						settings.WithSystemRuntimeCacheHandle();
					});
				}

				var connection = cache.Get(key: "KittyhawkConnection") as string;

				if (connection == null)
				{
                    connection = new ConnStringService().GetConnStringAsObjectAsync($"Kittyhawk-{Environments.Environment}").Result.ConnectionString;
					cache.Add(key: "KittyhawkConnection", value: connection);
				}

				return connection;
			}
		}
	}
}
