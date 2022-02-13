using System;
using System.Collections.Generic;

namespace CPU_ProcessCoordinationAlgorithm
{
    class SJFNonPreemptive
    {
        public static List<Process> processes;
        private static int[,] mat = new int[10, 6];

        private static void ArrangeArrival()
        {
            for (int i = 0; i < processes.Count; i++)
                for (int j = 0; j < processes.Count - i - 1; j++)
                    if (mat[j, 1] > mat[j + 1, 1])
                        for (int k = 0; k < 5; k++)
                        {
                            int temp = mat[j, k];
                            mat[j, k] = mat[j + 1, k];
                            mat[j + 1, k] = temp;
                        }
        }

        private static void CompletionTime()
        {
            int temp, val = -1;
            mat[0, 3] = mat[0, 1] + mat[0, 2];
            mat[0, 5] = mat[0, 3] - mat[0, 1];
            mat[0, 4] = mat[0, 5] - mat[0, 2];

            for (int i = 1; i < processes.Count; i++)
            {
                temp = mat[i - 1, 3];
                int low = mat[i, 2];
                for (int j = i; j < processes.Count; j++)
                {
                    if (temp >= mat[j, 1] && low >= mat[j, 2])
                    {
                        low = mat[j, 2];
                        val = j;
                    }
                }
                mat[val, 3] = temp + mat[val, 2];
                mat[val, 5] = mat[val, 3] - mat[val, 1];
                mat[val, 4] = mat[val, 5] - mat[val, 2];
                for (int k = 0; k < 6; k++)
                {
                    int tem = mat[val, k];
                    mat[val, k] = mat[i, k];
                    mat[i, k] = tem;
                }
            }
        }

        private static void ConvertListToArray()
        {
            for (int i = 0; i < processes.Count; i++)
            {
                mat[i, 0] = Convert.ToInt32(processes[i].ID.Substring(1));
                mat[i, 1] = processes[i].ArrivalTime;
                mat[i, 2] = processes[i].BurstTime;
                mat[i, 3] = processes[i].CompletionTime;
                mat[i, 4] = processes[i].WaitTime;
                mat[i, 5] = processes[i].TurnAroundTime;
            }
        }

        private static void ConvertArrayToList()
        {
            int len = processes.Count;
            processes = new List<Process>(len);

            for (int i = 0; i < len; i++)
                processes.Add(
                    new Process("P" + mat[i, 0], mat[i, 1], mat[i, 2], mat[i, 4], mat[i, 5], mat[i, 3])
                );
        }

        public static List<Process> AlgorithmProcessing()
        {
            ConvertListToArray();
            ArrangeArrival();
            CompletionTime();
            ConvertArrayToList();
            return processes;
        }
    }
}
