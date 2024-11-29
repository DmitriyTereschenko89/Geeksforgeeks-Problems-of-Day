namespace Job_Sequencing_Problem
{
    internal class Job(int x, int y, int z)
    {
        public int id = x;
        public int profit = z;
        public int deadline = y;
    }
}
