namespace CPU_ProcessCoordinationAlgorithm
{
    public class Process
    {
        public Process()
        {
            ID = "P0";
            ArrivalTime = 0;
            BurstTime = 0;
            WaitTime = 0;
            TurnAroundTime = 0;
            CompletionTime = 0;
        }

        public Process(string id, int arrivalTime, int burstTime)
        {
            ID = id;
            ArrivalTime = arrivalTime;
            BurstTime = burstTime;
            WaitTime = 0;
            TurnAroundTime = 0;
            CompletionTime = 0;
        }

        public Process(string id, int arrivalTime, int burstTime, int waitTime, int turnAroundTime, int completionTime)
        {
            ID = id;
            ArrivalTime = arrivalTime;
            BurstTime = burstTime;
            WaitTime = waitTime;
            TurnAroundTime = turnAroundTime;
            CompletionTime = completionTime;
        }

        public string ID { get; set; }
        public int ArrivalTime { get; set; }
        public int BurstTime { get; set; }
        public int WaitTime { get; set; }
        public int TurnAroundTime { get; set; }
        public int CompletionTime { get; set; }
    }
}