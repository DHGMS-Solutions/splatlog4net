namespace Splat.Log4Net
{
    public static class Helpers
    {
        public static void UseLog4Net()
        {
            var funcLogManager = new FuncLogManager(type =>
            {
                var actualLogger = log4net.LogManager.GetLogger(type);
                return new Log4NetSplatLogger(actualLogger);
            });

            Locator.CurrentMutable.RegisterConstant(funcLogManager, typeof(ILogManager));
        }
    }
}
