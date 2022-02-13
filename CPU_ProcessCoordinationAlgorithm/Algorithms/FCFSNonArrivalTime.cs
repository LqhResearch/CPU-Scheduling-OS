using System.Collections.Generic;

namespace CPU_ProcessCoordinationAlgorithm
{
    class FCFSNonArrivalTime
    {
        public static List<Process> processes;

        private static void FindWaitingTime()
        {
            processes[0].WaitTime = 0;
            for (int i = 1; i < processes.Count; i++)
                processes[i].WaitTime = processes[i - 1].BurstTime + processes[i - 1].WaitTime;
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
        }
    }
}
