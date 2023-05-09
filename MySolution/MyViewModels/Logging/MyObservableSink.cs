using CommunityToolkit.Mvvm.ComponentModel;
using Serilog.Core;
using Serilog.Events;

namespace MyViewModels
{
    public partial class MyObservableSink : ObservableObject, ILogEventSink
    {
        [ObservableProperty]
        string? log;

        private readonly IFormatProvider? formatProvider;
        public MyObservableSink(IFormatProvider? formatProvider = null)
        {
            this.formatProvider = formatProvider;
        }
        public void Emit(LogEvent logEvent)
        {
            this.Log = logEvent.RenderMessage(formatProvider);
        }
    }
}
