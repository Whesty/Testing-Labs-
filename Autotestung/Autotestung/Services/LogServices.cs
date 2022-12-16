
using Microsoft.Extensions.Logging;
using System.Diagnostics;

namespace Autotestung.Services
{
    internal static class LogServices
    {

        private static readonly ILoggerFactory _loggerFactory = new LoggerFactory();
        private static readonly ILogger _logger = _loggerFactory.CreateLogger("CustomCategory");
    }
}




   