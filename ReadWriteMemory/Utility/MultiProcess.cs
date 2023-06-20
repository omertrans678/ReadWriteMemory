using omertrans156.ReadWriteMemory.Exceptions;
using omertrans156.ReadWriteMemory.Win32;
using System;

namespace omertrans156.ReadWriteMemory.Utility
{
    public class MultiProcess
    {
        public System.Diagnostics.Process[] Processes { get; set; }
        public MultiProcess(object Process, bool stopCheck = false)
        {
            if (Process is int PID)
                UpdateProcess(PID);
            else if (Process is string ProcessName)
                UpdateProcess(ProcessName);
            else if (Process is System.Diagnostics.Process ProcessC)
                UpdateProcess(ProcessC);
            else if (Process is System.Diagnostics.Process[] ProcessArray)
                UpdateProcess(ProcessArray);
            else
                throw new InvalidVariableTypeException();
            if (!stopCheck)
                CheckProcess();
        }

        public void UpdateProcess(string ProcessName)
        {
            if (ProcessName.Contains(".exe"))
                ProcessName = ProcessName.Replace(".exe", "");
            Processes = System.Diagnostics.Process.GetProcessesByName(ProcessName);
        }
        public void UpdateProcess(int ProcessID)
        {
            Processes = new System.Diagnostics.Process[] { System.Diagnostics.Process.GetProcessById(ProcessID) };
        }
        public void UpdateProcess(System.Diagnostics.Process Process)
        {
            Processes = new System.Diagnostics.Process[] { Process };
        }
        public void UpdateProcess(System.Diagnostics.Process[] Process)
        {
            Processes = Process;
        }
        public void CheckProcess()
        {
            foreach (System.Diagnostics.Process proc in Processes)
            {
                if (proc.Id <= 0)
                {
                    throw new InvalidProcessIdException();
                }
                if (proc == null)
                {
                    throw new ProcessNullException();
                }
                /*if (!proc.Responding)
                {
                    throw new ProcessNotRespondingException();
                }*/
                if (Native.OpenProcess(Native.ProcessAccessFlags.All, true, proc.Id) == IntPtr.Zero)
                {
                    throw new OpenProcessFailedException();
                }
            }

        }
        public void Dispose()
        {
            //foreach (var proc in proceses)
            //proc.Close();
        }

    }
}
