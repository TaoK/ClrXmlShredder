using System;
using System.Collections.Generic;
using System.Text;

namespace ClrXmlShredderTests
{
    class Program
    {
        [System.STAThread]
        static void Main(string[] args)
        {
            NUnit.Gui.AppEntry.Main(new string[] { System.Reflection.Assembly.GetExecutingAssembly().Location });
        }
    }
}
