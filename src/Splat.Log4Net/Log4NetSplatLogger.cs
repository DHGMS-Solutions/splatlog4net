namespace Splat.Log4Net
{
    using System;

    using log4net;
    using Splat;

    internal sealed class Log4NetSplatLogger : IFullLogger
    {
        private readonly ILog _inner;

        public Log4NetSplatLogger(ILog innerLogger)
        {
            if (innerLogger == null)
            {
                throw new ArgumentNullException(nameof(innerLogger));
            }

            _inner = innerLogger;
        }

        public void Write(string message, LogLevel logLevel)
        {
            switch (logLevel)
            {
                case LogLevel.Info:
                    Info(message);
                    break;
                case LogLevel.Warn:
                    Warn(message);
                    break;
                case LogLevel.Error:
                    Error(message);
                    break;
                case LogLevel.Fatal:
                    Fatal(message);
                    break;
                //case LogLevel.Debug:
                default:
                    Debug(message);
                    break;
            }
        }

        public LogLevel Level
        {
            get; set;
        }

        public void Debug<T>(T value)
        {
            _inner.Debug(value);
        }

        public void Debug<T>(IFormatProvider formatProvider, T value)
        {
            _inner.Debug(value);
        }

        public void DebugException(string message, Exception exception)
        {
            _inner.Debug(message, exception);
        }

        public void Debug(IFormatProvider formatProvider, string message, params object[] args)
        {
            _inner.DebugFormat(formatProvider, message, args);
        }

        public void Debug(string message)
        {
            _inner.Debug(message);
        }

        public void Debug(string message, params object[] args)
        {
            var argString = string.Join(",", args);

            _inner.Debug(message + " {" + argString + "}");
        }

        public void Debug<TArgument>(IFormatProvider formatProvider, string message, TArgument argument)
        {
            _inner.Debug(message);
        }

        public void Debug<TArgument>(string message, TArgument argument)
        {
            _inner.Debug(message);
        }

        public void Debug<TArgument1, TArgument2>(IFormatProvider formatProvider, string message, TArgument1 argument1,
                                                  TArgument2 argument2)
        {
            _inner.Debug(message);
        }

        public void Debug<TArgument1, TArgument2>(string message, TArgument1 argument1, TArgument2 argument2)
        {
            _inner.Debug(message);
        }

        public void Debug<TArgument1, TArgument2, TArgument3>(IFormatProvider formatProvider, string message, TArgument1 argument1,
                                                              TArgument2 argument2, TArgument3 argument3)
        {
            _inner.Debug(message);
        }

        public void Debug<TArgument1, TArgument2, TArgument3>(string message, TArgument1 argument1, TArgument2 argument2,
                                                              TArgument3 argument3)
        {
            _inner.Debug(message);
        }

        public void Info<T>(T value)
        {
            _inner.Info(value);
        }

        public void Info<T>(IFormatProvider formatProvider, T value)
        {
            _inner.Info(value);
        }

        public void InfoException(string message, Exception exception)
        {
            _inner.Info(message, exception);
        }

        public void Info(IFormatProvider formatProvider, string message, params object[] args)
        {
            _inner.InfoFormat(formatProvider, message, args);
        }

        public void Info(string message)
        {
            _inner.Info(message);
        }

        public void Info(string message, params object[] args)
        {
            _inner.Info(message);
        }

        public void Info<TArgument>(IFormatProvider formatProvider, string message, TArgument argument)
        {
            _inner.Info(message);
        }

        public void Info<TArgument>(string message, TArgument argument)
        {
            _inner.Info(message);
        }

        public void Info<TArgument1, TArgument2>(IFormatProvider formatProvider, string message, TArgument1 argument1,
                                                 TArgument2 argument2)
        {
            _inner.Info(message);
        }

        public void Info<TArgument1, TArgument2>(string message, TArgument1 argument1, TArgument2 argument2)
        {
            _inner.Info(message);
        }

        public void Info<TArgument1, TArgument2, TArgument3>(IFormatProvider formatProvider, string message, TArgument1 argument1,
                                                             TArgument2 argument2, TArgument3 argument3)
        {
            _inner.Info(message);
        }

        public void Info<TArgument1, TArgument2, TArgument3>(string message, TArgument1 argument1, TArgument2 argument2,
                                                             TArgument3 argument3)
        {
            _inner.Info(message);
        }

        public void Warn<T>(T value)
        {
            _inner.Warn(value);
        }

        public void Warn<T>(IFormatProvider formatProvider, T value)
        {
            _inner.Warn(value);
        }

        public void WarnException(string message, Exception exception)
        {
            _inner.Warn(message, exception);
        }

        public void Warn(IFormatProvider formatProvider, string message, params object[] args)
        {
            _inner.Warn(message);
        }

        public void Warn(string message)
        {
            _inner.Warn(message);
        }

        public void Warn(string message, params object[] args)
        {
            _inner.Warn(message);
        }

        public void Warn<TArgument>(IFormatProvider formatProvider, string message, TArgument argument)
        {
            _inner.Warn(message);
        }

        public void Warn<TArgument>(string message, TArgument argument)
        {
            _inner.Warn(message);
        }

        public void Warn<TArgument1, TArgument2>(IFormatProvider formatProvider, string message, TArgument1 argument1,
                                                 TArgument2 argument2)
        {
            _inner.Warn(message);
        }

        public void Warn<TArgument1, TArgument2>(string message, TArgument1 argument1, TArgument2 argument2)
        {
            _inner.Warn(message);
        }

        public void Warn<TArgument1, TArgument2, TArgument3>(IFormatProvider formatProvider, string message, TArgument1 argument1,
                                                             TArgument2 argument2, TArgument3 argument3)
        {
            _inner.Warn(message);
        }

        public void Warn<TArgument1, TArgument2, TArgument3>(string message, TArgument1 argument1, TArgument2 argument2,
                                                             TArgument3 argument3)
        {
            _inner.Warn(message);
        }

        public void Error<T>(T value)
        {
            _inner.Error(value);
        }

        public void Error<T>(IFormatProvider formatProvider, T value)
        {
            _inner.Error(value);
        }

        public void ErrorException(string message, Exception exception)
        {
            _inner.Error(message, exception);
        }

        public void Error(IFormatProvider formatProvider, string message, params object[] args)
        {
            _inner.Error(message);
        }

        public void Error(string message)
        {
            _inner.Error(message);
        }

        public void Error(string message, params object[] args)
        {
            _inner.Error(message);
        }

        public void Error<TArgument>(IFormatProvider formatProvider, string message, TArgument argument)
        {
            _inner.Error(message);
        }

        public void Error<TArgument>(string message, TArgument argument)
        {
            _inner.Error(message);
        }

        public void Error<TArgument1, TArgument2>(IFormatProvider formatProvider, string message, TArgument1 argument1,
                                                  TArgument2 argument2)
        {
            _inner.Error(message);
        }

        public void Error<TArgument1, TArgument2>(string message, TArgument1 argument1, TArgument2 argument2)
        {
            _inner.Error(message);
        }

        public void Error<TArgument1, TArgument2, TArgument3>(IFormatProvider formatProvider, string message, TArgument1 argument1,
                                                              TArgument2 argument2, TArgument3 argument3)
        {
            _inner.Error(message);
        }

        public void Error<TArgument1, TArgument2, TArgument3>(string message, TArgument1 argument1, TArgument2 argument2,
                                                              TArgument3 argument3)
        {
            _inner.Error(message);
        }

        public void Fatal<T>(T value)
        {
            _inner.Fatal(value);
        }

        public void Fatal<T>(IFormatProvider formatProvider, T value)
        {
            _inner.Fatal(value);
        }

        public void FatalException(string message, Exception exception)
        {
            _inner.Fatal(message, exception);
        }

        public void Fatal(IFormatProvider formatProvider, string message, params object[] args)
        {
            _inner.Fatal(message);
        }

        public void Fatal(string message)
        {
            _inner.Fatal(message);
        }

        public void Fatal(string message, params object[] args)
        {
            _inner.Fatal(message);
        }

        public void Fatal<TArgument>(IFormatProvider formatProvider, string message, TArgument argument)
        {
            _inner.Fatal(message);
        }

        public void Fatal<TArgument>(string message, TArgument argument)
        {
            _inner.Fatal(message);
        }

        public void Fatal<TArgument1, TArgument2>(IFormatProvider formatProvider, string message, TArgument1 argument1,
                                                  TArgument2 argument2)
        {
            _inner.Fatal(message);
        }

        public void Fatal<TArgument1, TArgument2>(string message, TArgument1 argument1, TArgument2 argument2)
        {
            _inner.Fatal(message);
        }

        public void Fatal<TArgument1, TArgument2, TArgument3>(IFormatProvider formatProvider, string message, TArgument1 argument1,
                                                              TArgument2 argument2, TArgument3 argument3)
        {
            _inner.Fatal(message);
        }

        public void Fatal<TArgument1, TArgument2, TArgument3>(string message, TArgument1 argument1, TArgument2 argument2,
                                                              TArgument3 argument3)
        {
            _inner.Fatal(message);
        }
    }
}
