namespace WebApi.Cache
{
    public class ConnectionHelper
    {
        static ConnectionHelper()
        {
            lazyConnection = new Lazy<ConnectionMultiplexer>(() =>
            {
                return ConnectionMultiplexer.Connect(ConfigurationManager.AppSetting["RedisURL"]);
            });
        }

        private static Lazy<ConnectionMultiplexer> lazyConnection;

        public static ConnectionMultiplexer Connection
        {
            get
            {
                return lazyConnection.Value;
            }
        }
    }
}
