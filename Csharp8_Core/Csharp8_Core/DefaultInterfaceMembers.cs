using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    
    enum LogLevel
    {
        Debug,
        Info,
        Error
    }

    interface ILogger
    {
        void Log(LogLevel level, string message);

        void Log(Exception ex) => Log(LogLevel.Error, $"Exception {ex.Message}"); // New overload
    }

    class Logger : ILogger
    {
        public void Log(LogLevel level, string message)
        {
            Console.WriteLine(message);
        }
    }

    public class DefaultInterfaceMembers
    {

        void UseLogger()
        {
            ILogger logger = new Logger();

            try
            {
                throw new Exception("Test");
            }
            catch (Exception e)
            {
                logger.Log(e);
            }
            
        }

    }
    
}
