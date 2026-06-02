using System;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Logging;

namespace Naif.Core.Cache
{
    public static class CacheExtensions
    {
        public static T GetObject<T>(this IMemoryCache memoryCache, string cacheKey, ILogger logger, MemoryCacheEntryOptions cacheOptions, Func<T> refreshCache)
        {
            if (!memoryCache.TryGetValue(cacheKey, out T cachedObject))
            {
                // fetch the value from the source
                cachedObject = refreshCache();

                // store in the cache unless the object is null
                if (cachedObject != null)
                {
                    memoryCache.Set(cacheKey, cachedObject, cacheOptions);
                }
                
                logger.LogInformation($"{cacheKey} updated from source.");
            }
            else
            {
                logger.LogInformation($"{cacheKey} retrieved from cache.");
            }

            return cachedObject;
        }
    }
}