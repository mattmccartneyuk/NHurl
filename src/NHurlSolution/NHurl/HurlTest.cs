namespace NHurl;

[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
public class HurlTest(string hurlFilePath) : Attribute
{
    public string HurlFilePath { get; set; } = hurlFilePath;
}