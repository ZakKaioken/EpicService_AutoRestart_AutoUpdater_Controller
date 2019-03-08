using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Project_T
{
	class Program
	{
		static void Main()
		{
			string datasite = @""; //link to serverside config file. (127.0.0.1/configfile.txt)
			string[] data = Setup(datasite); //save all lines of the text file in an array




			bool isActive = false; //this makes sure it's not running when it starts

			while (true) //every 100 miliseconds
			{
				if (isActive) //if its active find all programs and kill them
				{
					List<string> programs = new List<string>(); //make an empty list of programs
					for (int i = 1; i < data.Length; i++) //for every line in the text file other than the first
					{
						programs.Add(data[i]); //add the program to the list of possible programs
					}
					foreach (string program in programs) //for every program
					{
						FindandKillProcesses(program); //find all open versions of it, and kill them.
					}
				}


				data = Setup(datasite); //reload the array
				isActive = IsActive(data[0]); //sets the isactive if the first line is "Kill Them!".
				Thread.Sleep(200); //sleep for 1/5th of a second.

			} //start over

		}



		//takes a full notepad string and cuts it by the line breaks
		static string[] Setup (string datasite)
		{
			string data = GetData(datasite);
			return data.Split('\n');
		}


		//checks if the string given is "Kill Them!"
		static bool IsActive(string q)
		{
			return q.Contains("Kill Them!");
		}


		//connects to the internet and grabs the txt file
		private static string GetData(string datasite) 
		{
			using (var client = new WebClient())
			{
				return client.DownloadString(datasite);
			}
		}

		
		//are there any programs actually running?
		private static bool IsRunning(Process[] processes)
		{
			return !(processes.Length == 0);
		}


		//finds all open files with the name given. if there are programs running, kill all and play an error sound.
		private static void FindandKillProcesses(string programName)
				{
					Process[] processes = Process.GetProcessesByName(programName);
					if (IsRunning(processes))
					{
						KillAll(processes);
						System.Media.SystemSounds.Exclamation.Play();

					}
				}


		//for every process found, kill all of them
		private static void KillAll(Process[] processes)
		{
			foreach (Process p in processes)
			{
				if (p != null) p.Kill();

			}
		}
	}
}
