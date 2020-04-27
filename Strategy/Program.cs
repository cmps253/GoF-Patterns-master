namespace CMPS253.GoFPatterns.Behavioral.Strategy
{
    public class MainApp
    {
        static void Main()
        {
            SortedList studentRecords = new SortedList();

            studentRecords.Add("Joe");
            studentRecords.Add("Ted");
            studentRecords.Add("Sally");
            studentRecords.Add("Joan");
            studentRecords.Add("Jimmy");

            studentRecords.SetSortStrategy(new QuickSort());
            studentRecords.Sort();

            studentRecords.SetSortStrategy(new ShellSort());
            studentRecords.Sort();

            studentRecords.SetSortStrategy(new MergeSort());
            studentRecords.Sort();
        }
    }
}