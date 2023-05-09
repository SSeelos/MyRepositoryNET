using Serilog;
using Serilog.Configuration;

namespace MyViewModels
{
    public static class SerilogConfig
    {
        public static LoggerConfiguration MyObservableSink(this LoggerSinkConfiguration sinkCfg,
            IFormatProvider format = null)
        {
            return sinkCfg.Sink(new MyObservableSink(format));
        }

        public static void Config()
        {
            Log.Logger = new LoggerConfiguration()
                .WriteTo.MyObservableSink()
                .CreateLogger();
        }
    }
}
