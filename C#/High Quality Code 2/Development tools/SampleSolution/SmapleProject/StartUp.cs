using log4net;
using log4net.Config;

namespace SmapleProject
{
    using SmapleProject.Models;

    public class StartUp
    {
        private static readonly ILog logger = LogManager.GetLogger(typeof(SampleClass));
        
        public static void Main(string[] args)
        {
            XmlConfigurator.Configure();

            var sample = new SampleClass("sample");
            sample.DoSomeSampleStuff();

            logger.Info("Info logging");
            logger.Debug("Debug message sample");
        }
    }
}
