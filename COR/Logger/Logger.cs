public class Logger
{
    static LogProcessor logger = new InfoLogger(new ErrorLogger(null));   
    
    public static void Log(string message)
    {
        logger.log(LOG_TYPE.ERROR, message);
    }

    public static void Info(string message)
    {
        logger.log(LOG_TYPE.INFO, message);
    }
}