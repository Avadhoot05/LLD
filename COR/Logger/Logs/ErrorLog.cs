public class ErrorLogger : LogProcessor
{
    public ErrorLogger(LogProcessor nextLogProcessor) : base(nextLogProcessor)
    {

    }

    public override void log(LOG_TYPE type, string message)
    {
        if(type == LOG_TYPE.ERROR)
            Console.WriteLine(message);
        else
            base.log(type, message);
    }


}