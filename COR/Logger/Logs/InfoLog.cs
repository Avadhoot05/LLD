public class InfoLogger : LogProcessor
{
    public InfoLogger(LogProcessor nextLogProcessor) : base(nextLogProcessor)
    {

    }

    public override void log(LOG_TYPE type, string message)
    {
        if(type == LOG_TYPE.INFO)
            Console.WriteLine(message);
        else
            base.log(type, message);
    }


}