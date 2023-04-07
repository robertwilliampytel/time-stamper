using System;
using System.Collections;


namespace TimeStamper_Namespace
{
  class TimeStamper
  {
    private readonly DateTime     timestamp;
    private readonly List<string> sources;
    
    
    public DateTime TimeStamp   { get { return this.timestamp; } }
    public List<string> Sources { get { return this.sources; } }
    
    
    public TimeStamper()
    {
      this.timestamp = DateTime.Now;
      this.sources   = new List<string>(){"Unknown Source - Not initialized with any sources. This is default."};
    }
    
    
    public TimeStamper(List<string> sources)
    {
      this.timestamp = DateTime.Now;
      this.sources   = sources;
    }
    
    
    public void WriteLineTimeStamp()
    {
      Console.WriteLine(this.timestamp.ToString("dddd, MMMM dd (yyyy): HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture));
    }
    
    
    public void WriteLineSourcesOnePerLine()
    {
      foreach(string source in this.sources)
      Console.WriteLine(source);
    }
    
    
    public void WriteLineTimeStampAndSourcesOnePerLine()
    {
      this.WriteLineTimeStamp();
      this.WriteLineSourcesOnePerLine();
    }
  }
}
