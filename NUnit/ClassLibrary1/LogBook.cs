using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public interface ILogBook
    {
        void Message(string Message);
    }
    public class LogBook : ILogBook
    {
        public void Message(string Message)
        {
            Console.WriteLine(Message);
        }
    }
}
