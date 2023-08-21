using System.Windows.Automation;
using System.Diagnostics;
using System.Xml.Linq;
using System;

namespace Code_Trather
{
    internal static class Program
    {
        
        public static string studentName = "";
        public static int cwid;
        public static string testID = "";
        public static bool hasUnitTest;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
                        //get processes at start
            Process[] processlist = Process.GetProcesses();
            foreach (Process theprocess in processlist)
            {
                System.Diagnostics.Debug.WriteLine("Process: {0} ID: {1}", theprocess.ProcessName, theprocess.Id);
            }
            LogProcesses(processlist);

            //listen for focus changes
            Automation.AddAutomationFocusChangedEventHandler(OnFocusChangedHandler);

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Login());
        }

        public static async Task LogProcesses(Process[] plist)
        {
            using StreamWriter file = new("ProcessesAtStart.txt");

            foreach (Process p in plist)
            {
                await file.WriteLineAsync(p.ProcessName);
            }
        }

        private static void OnFocusChangedHandler(object src, AutomationFocusChangedEventArgs args)
        {
            System.Diagnostics.Debug.WriteLine("Focus changed at " + DateTime.Now.ToString("HH:mm:ss"));
            AutomationElement? element = src as AutomationElement;
            try
            {
                if (element != null)
                {
                    string name = element.Current.Name;
                    string id = element.Current.AutomationId;
                    int processId = element.Current.ProcessId;
                    using (Process process = Process.GetProcessById(processId))
                    {
                        System.Diagnostics.Debug.WriteLine("  Name: {0}, Id: {1}, Process: {2}", name, id, process.ProcessName);
                        if(process.ProcessName != "Code_Trather")
                        {
                            WriteTo.writeToAttention($"  Name: {name}, Id: {id}, Process: {process.ProcessName}");
                        }
                        
                    }
                }
            }
            // some focus changes have elements with no information, this catches those execptions and logs them as unknowns
            catch (System.Windows.Automation.ElementNotAvailableException)
            {
                System.Diagnostics.Debug.WriteLine("  Name: Unknown, Id: Unknown, Process: Unknown");
                WriteTo.writeToAttention("  Name: Unknown, Id: Unknown, Process: Unknown");
            }
        }
    }
}