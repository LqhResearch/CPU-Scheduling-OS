using System.Collections.Generic;

namespace CPU_ProcessCoordinationAlgorithm
{
    class RoundRobin
    {
        public static List<Process> processes;
        public static int quantum;

        private static void FindWaitingTime()
        {
            int[] remainingBurst = new int[processes.Count];
            for (int i = 0; i < processes.Count; i++)
                remainingBurst[i] = processes[i].BurstTime;
            int t = 0; // Current time
            while (true)
            {
                bool done = true;
                for (int i = 0; i < processes.Count; i++)
                {
                    if (remainingBurst[i] > 0) // If burst time of a process is greater than 0 then only need to process further
                    {
                        done = false; // There is a pending process
                        if (remainingBurst[i] > quantum)
                        {
                            t += quantum; // Increase the value of t, shows how much time a process has been processed
                            remainingBurst[i] -= quantum; // Decrease the burst_time of current process by quantum
                        }
                        else // If burst time is smaller than or equal to quantum. Last cycle for this process
                        {
                            t = t + remainingBurst[i]; // Increase the value of t, shows how much time a process has been processed
                            processes[i].WaitTime = t - processes[i].BurstTime; // Waiting time is current time minus time used by this process
                            remainingBurst[i] = 0;  // As the process gets fully executed make its remaining burst time = 0
                        }
                    }
                }
                if (done == true) // If all processes are done
                    break;
            }
        }

        private static void FindTurnAroundTime()
        {
            for (int i = 0; i < processes.Count; i++)
                processes[i].TurnAroundTime = processes[i].BurstTime + processes[i].WaitTime;
        }

        public static void AlgorithmProcessing()
        {
            FindWaitingTime(); // Function to find waiting time of  all processes
            FindTurnAroundTime(); // Function to find turn around time  for all processes
        }
    }
}
