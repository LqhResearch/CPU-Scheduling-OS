using System.Collections.Generic;

namespace CPU_ProcessCoordinationAlgorithm
{
    class FCFSArrivalTime
    {
        public static List<Process> processes;

        private static void FindWaitingTime()
        {
            int[] serviceTime = new int[processes.Count];
            serviceTime[0] = 0;
            processes[0].WaitTime = 0;

            for (int i = 1; i < processes.Count; i++)
            {
                serviceTime[i] = serviceTime[i - 1] + processes[i - 1].BurstTime;
                processes[i].WaitTime = serviceTime[i] - processes[i].ArrivalTime;
                if (processes[i].WaitTime < 0)
                    processes[i].WaitTime = 0;
            }
        }

        private static void FindTurnAroundTime()
        {
            for (int i = 0; i < processes.Count; i++)
                processes[i].TurnAroundTime = processes[i].BurstTime + processes[i].WaitTime;
        }

        public static void AlgorithmProcessing()
        {
            FindWaitingTime();
            FindTurnAroundTime();
            for (int i = 0; i < processes.Count; i++)
                processes[i].CompletionTime = processes[i].WaitTime + processes[i].TurnAroundTime;
        }
    }
}
