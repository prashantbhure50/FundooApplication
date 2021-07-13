
using NLog;
using RepositoryLayer.Interface;


namespace RepositoryLayer.Service
{
  public  class Nlog:INlog
    {
        public Logger logger = LogManager.GetCurrentClassLogger();
        public void LogDebug(string input)
        {
            logger.Debug(input);
        }
        public void LogError(string input)
        {
            logger.Error(input);
        }
        public void LogWarn(string input)
        {
            logger.Warn(input);
        }
        public void LogInfo(string input)
        {
            logger.Info(input);
        }
    }
}
