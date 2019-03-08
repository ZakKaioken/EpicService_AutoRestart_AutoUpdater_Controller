using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Tseries
{
	class Program
	{
		static void Main(string[] args)
		{
			//opens the main program and saves it as a varible
			Process epic = Process.Start("EpicService.exe");
			while (true) //loops forever
			{				
				if (epic.HasExited) //if the main program closed for any reason
				{
					epic = Process.Start("EpicService.exe"); //restart it
				}

				Thread.Sleep(1000); //waits one second
			} //starts over
		}
	}
}
