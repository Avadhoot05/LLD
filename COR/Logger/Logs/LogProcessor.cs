public enum LOG_TYPE {
    INFO, 
    ERROR
}

public abstract class LogProcessor
{
    private LogProcessor nextLogProcessor;
    public LogProcessor(LogProcessor nextLogProcessor)
    {
        this.nextLogProcessor = nextLogProcessor;
    }

    public virtual void log(LOG_TYPE type, string message)
    {   
        if(this.nextLogProcessor != null)
            this.nextLogProcessor.log(type, message);
    }
}