namespace JenkinsConsoleApp.Core.Helper
{
    public class Helper : IHelper
    {
        public bool IsEmpty(string value)
        {
            return (string.IsNullOrWhiteSpace(value)) ? true : false;
        }
    }
}
