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
            _inner = innerLogger ?? throw new ArgumentNullException(nameof(innerLogger));
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
            _inner.Debug(string.Format(formatProvider, "{0}", value));
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
            _inner.DebugFormat(message, args);
        }

        public void Debug<TArgument>(IFormatProvider formatProvider, string message, TArgument argument)
        {
            _inner.DebugFormat(formatProvider, message, argument);
        }

        public void Debug<TArgument>(string message, TArgument argument)
        {
            _inner.DebugFormat(message, argument);
        }

        public void Debug<TArgument1, TArgument2>(IFormatProvider formatProvider, string message, TArgument1 argument1,
                                                  TArgument2 argument2)
        {
            _inner.DebugFormat(formatProvider, message, argument1, argument2);
        }

        public void Debug<TArgument1, TArgument2>(string message, TArgument1 argument1, TArgument2 argument2)
        {
            _inner.DebugFormat(message, argument1, argument2);
        }

        public void Debug<TArgument1, TArgument2, TArgument3>(IFormatProvider formatProvider, string message, TArgument1 argument1,
                                                              TArgument2 argument2, TArgument3 argument3)
        {
            _inner.DebugFormat(formatProvider, message, argument1, argument2, argument3);
        }

        public void Debug<TArgument1, TArgument2, TArgument3>(string message, TArgument1 argument1, TArgument2 argument2,
                                                              TArgument3 argument3)
        {
            _inner.DebugFormat(message, argument1, argument2, argument3);
        }

        public void Info<T>(T value)
        {
            _inner.Info(value);
        }

        public void Info<T>(IFormatProvider formatProvider, T value)
        {
            _inner.InfoFormat(formatProvider, "{0}", value);
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
            _inner.InfoFormat(message, args);
        }

        public void Info<TArgument>(IFormatProvider formatProvider, string message, TArgument argument)
        {
            _inner.InfoFormat(formatProvider, message, argument);
        }

        public void Info<TArgument>(string message, TArgument argument)
        {
            _inner.InfoFormat(message, argument);
        }

        public void Info<TArgument1, TArgument2>(IFormatProvider formatProvider, string message, TArgument1 argument1,
                                                 TArgument2 argument2)
        {
            _inner.InfoFormat(formatProvider, message, argument1, argument2);
        }

        public void Info<TArgument1, TArgument2>(string message, TArgument1 argument1, TArgument2 argument2)
        {
            _inner.InfoFormat(message, argument1, argument2);
        }

        public void Info<TArgument1, TArgument2, TArgument3>(IFormatProvider formatProvider, string message, TArgument1 argument1,
                                                             TArgument2 argument2, TArgument3 argument3)
        {
            _inner.InfoFormat(formatProvider, message, argument1, argument2, argument3);
        }

        public void Info<TArgument1, TArgument2, TArgument3>(string message, TArgument1 argument1, TArgument2 argument2,
                                                             TArgument3 argument3)
        {
            _inner.InfoFormat(message, argument1, argument2, argument3);
        }

        public void Warn<T>(T value)
        {
            _inner.Warn(value);
        }

        public void Warn<T>(IFormatProvider formatProvider, T value)
        {
            _inner.WarnFormat(formatProvider, "{0}", value);
        }

        public void WarnException(string message, Exception exception)
        {
            _inner.Warn(message, exception);
        }

        public void Warn(IFormatProvider formatProvider, string message, params object[] args)
        {
            _inner.WarnFormat(formatProvider, message, args);
        }

        public void Warn(string message)
        {
            _inner.Warn(message);
        }

        public void Warn(string message, params object[] args)
        {
            _inner.WarnFormat(message, args);
        }

        public void Warn<TArgument>(IFormatProvider formatProvider, string message, TArgument argument)
        {
            _inner.WarnFormat(formatProvider, message, argument);
        }

        public void Warn<TArgument>(string message, TArgument argument)
        {
            _inner.WarnFormat(message, argument);
        }

        public void Warn<TArgument1, TArgument2>(IFormatProvider formatProvider, string message, TArgument1 argument1,
                                                 TArgument2 argument2)
        {
            _inner.WarnFormat(formatProvider, message, argument1, argument2);
        }

        public void Warn<TArgument1, TArgument2>(string message, TArgument1 argument1, TArgument2 argument2)
        {
            _inner.WarnFormat(message, argument1, argument2);
        }

        public void Warn<TArgument1, TArgument2, TArgument3>(IFormatProvider formatProvider, string message, TArgument1 argument1,
                                                             TArgument2 argument2, TArgument3 argument3)
        {
            _inner.WarnFormat(formatProvider, message, argument1, argument2, argument3);
        }

        public void Warn<TArgument1, TArgument2, TArgument3>(string message, TArgument1 argument1, TArgument2 argument2,
                                                             TArgument3 argument3)
        {
            _inner.WarnFormat(message, argument1, argument2, argument3);
        }

        public void Error<T>(T value)
        {
            _inner.Error(value);
        }

        public void Error<T>(IFormatProvider formatProvider, T value)
        {
            _inner.ErrorFormat(formatProvider, "{0}", value);
        }

        public void ErrorException(string message, Exception exception)
        {
            _inner.Error(message, exception);
        }

        public void Error(IFormatProvider formatProvider, string message, params object[] args)
        {
            _inner.ErrorFormat(formatProvider, message, args);
        }

        public void Error(string message)
        {
            _inner.Error(message);
        }

        public void Error(string message, params object[] args)
        {
            _inner.ErrorFormat(message, args);
        }

        public void Error<TArgument>(IFormatProvider formatProvider, string message, TArgument argument)
        {
            _inner.ErrorFormat(formatProvider, message, argument);
        }

        public void Error<TArgument>(string message, TArgument argument)
        {
            _inner.ErrorFormat(message, argument);
        }

        public void Error<TArgument1, TArgument2>(IFormatProvider formatProvider, string message, TArgument1 argument1,
                                                  TArgument2 argument2)
        {
            _inner.ErrorFormat(formatProvider, message, argument1, argument2);
        }

        public void Error<TArgument1, TArgument2>(string message, TArgument1 argument1, TArgument2 argument2)
        {
            _inner.ErrorFormat(message, argument1, argument2);
        }

        public void Error<TArgument1, TArgument2, TArgument3>(IFormatProvider formatProvider, string message, TArgument1 argument1,
                                                              TArgument2 argument2, TArgument3 argument3)
        {
            _inner.ErrorFormat(formatProvider, message, argument1, argument2, argument3);
        }

        public void Error<TArgument1, TArgument2, TArgument3>(string message, TArgument1 argument1, TArgument2 argument2,
                                                              TArgument3 argument3)
        {
            _inner.ErrorFormat(message, argument1, argument2, argument3);
        }

        public void Fatal<T>(T value)
        {
            _inner.Fatal(value);
        }

        public void Fatal<T>(IFormatProvider formatProvider, T value)
        {
            _inner.FatalFormat(formatProvider, "{0}", value);
        }

        public void FatalException(string message, Exception exception)
        {
            _inner.Fatal(message, exception);
        }

        public void Fatal(IFormatProvider formatProvider, string message, params object[] args)
        {
            _inner.FatalFormat(formatProvider, message, args);
        }

        public void Fatal(string message)
        {
            _inner.Fatal(message);
        }

        public void Fatal(string message, params object[] args)
        {
            _inner.FatalFormat(message, args);
        }

        public void Fatal<TArgument>(IFormatProvider formatProvider, string message, TArgument argument)
        {
            _inner.FatalFormat(formatProvider, message, argument);
        }

        public void Fatal<TArgument>(string message, TArgument argument)
        {
            _inner.FatalFormat(message, argument);
        }

        public void Fatal<TArgument1, TArgument2>(IFormatProvider formatProvider, string message, TArgument1 argument1,
                                                  TArgument2 argument2)
        {
            _inner.FatalFormat(formatProvider, message, argument1, argument2);
        }

        public void Fatal<TArgument1, TArgument2>(string message, TArgument1 argument1, TArgument2 argument2)
        {
            _inner.FatalFormat(message, argument1, argument2);
        }

        public void Fatal<TArgument1, TArgument2, TArgument3>(IFormatProvider formatProvider, string message, TArgument1 argument1,
                                                              TArgument2 argument2, TArgument3 argument3)
        {
            _inner.FatalFormat(formatProvider, message, argument1, argument2, argument3);
        }

        public void Fatal<TArgument1, TArgument2, TArgument3>(string message, TArgument1 argument1, TArgument2 argument2,
                                                              TArgument3 argument3)
        {
            _inner.FatalFormat(message, argument1, argument2, argument3);
        }
    }
}
