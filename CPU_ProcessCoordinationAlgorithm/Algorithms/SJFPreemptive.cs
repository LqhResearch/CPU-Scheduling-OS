using System.Collections.Generic;

namespace CPU_ProcessCoordinationAlgorithm
{
    class SJFPreemptive
    {
        public static List<Process> processes;

        private static void FindWaitingTime()
        {
            int[] rt = new int[processes.Count];
            for (int i = 0; i < processes.Count; i++)
                rt[i] = processes[i].BurstTime;

            int complete = 0, t = 0, min = int.MaxValue;
            int shortest = 0, finishTime;
            bool check = false;

            while (complete != processes.Count)
            {
                for (int j = 0; j < processes.Count; j++)
                    if ((processes[j].ArrivalTime <= t) && (rt[j] < min) && rt[j] > 0)
                    {
                        min = rt[j];
                        shortest = j;
                        check = true;
                    }

                if (check == false)
                {
                    t++;
                    continue;
                }

                rt[shortest]--;

                min = rt[shortest];
                if (min == 0)
                    min = int.MaxValue;

                if (rt[shortest] == 0)
                {
                    complete++;
                    check = false;
                    finishTime = t + 1;
                    processes[shortest].WaitTime = finishTime - processes[shortest].BurstTime - processes[shortest].ArrivalTime;
                    if (processes[shortest].WaitTime < 0)
                        processes[shortest].WaitTime = 0;
                }
                t++;
            }
        }

        private static void FindTurnAroundTime()
        {
            for (int i = 0; i < processes.Count; i++)
                processes[i].TurnAroundTime = processes[i].BurstTime + processes[i].WaitTime;
        }

        public static void AlgorithmProcessing()
        {
            FindWaitingTime(); // Function to find waiting time of all processes
            FindTurnAroundTime(); // Function to find turn around time for all processes
        }
    }
}