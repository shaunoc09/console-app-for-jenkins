using System;
using System.Collections.Generic;
using System.Text;

namespace JenkinsConsoleApp.Core.Helper
{
    public class Helper
    {
        public bool IsEmpty(string value)
        {
            return (string.IsNullOrWhiteSpace(value)) ? true : false;
        }
    }
}
