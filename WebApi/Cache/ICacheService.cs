namespace WebApi.Cache;

public interface ICacheService
{
    /// <summary>
    /// Get Data using key
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="key"></param>
    /// <returns></returns>
    T GetData<T>(string key);

    /// <summary> 
    /// Set Data with Value and Expiration Time of Key
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="key"></param>
    /// <param name="value"></param>
    /// <param name="expirationTime"></param>
    /// <returns></returns>
    bool SetData<T>(string key, T value, DateTimeOffset expirationTime);

    /// <summary>
    /// Remove Data 
    /// </summary>
    /// <param name="key"></param>
    /// <returns></returns>
    object RemoveData(string key);

    //Distributed cache yapısı için
    /*
    byte[] Get(string key);
    Task<byte[]> GetAsync(string key, CancellationToken token = default(CancellationToken));

    void Set(string key, byte[] value, DistributedCacheEntryOptions options);
    Task SetAsync(string key, byte[] value, DistributedCacheEntryOptions options, CancellationToken token = default(CancellationToken));

    void Refresh(string key);
    Task RefreshAsync(string key, CancellationToken token = default(CancellationToken));

    void Remove(string key);
    Task RemoveAsync(string key, CancellationToken token = default(CancellationToken));
    */

}
