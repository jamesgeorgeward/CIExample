using System;

namespace BLL
{
    public class HelloWorld
    {
        public string Test()
        {
            return DateTime.Now.ToString("dd MMMM yyyy HH:mm:ss");
        }
    }
}
