
namespace Utils;

public static class ConsoleMethods
{
    /// <summary>
    /// /// Provides a Yes/No selection on console apps
    /// </summary>
    /// <param name="title">The text to display on the read message</param>
    /// <returns></returns>
    public static bool Confirm(string title)
    {
        ConsoleKey response;
        do
        {
            Console.Write($"{ title } [y/n] ");
            response = Console.ReadKey(false).Key;
            if (response != ConsoleKey.Enter)
            {
                Console.WriteLine();
            }
        } while (response != ConsoleKey.Y && response != ConsoleKey.N);
        return (response == ConsoleKey.Y);
    }

    /// <summary>
    /// Chunks the list
    /// </summary>
    /// <typeparam name="T">List object type</typeparam>
    /// <param name="list">List to be chunked</param>
    /// <param name="nSize">Size of a single chunk</param>
    /// <returns>A list of lists</returns>
    public static IEnumerable<List<T>> SplitList<T>(List<T> list, int nSize = 30)
    {
        for (int i = 0; i < list.Count; i += nSize)
        {
            yield return list.GetRange(i, Math.Min(nSize, list.Count - i));
        }
    }

    /// <summary>
    /// New processor to detail time frame better!
    /// </summary>
    /// <param name="ms"></param>
    /// <returns></returns>
    public static string ConvertStringFromMilliSeconds(long ms)
    {
        TimeSpan t = TimeSpan.FromMilliseconds(ms);
        return string.Format("{0:D2}h:{1:D2}m:{2:D2}s:{3:D3}ms", 
                                t.Hours, 
                                t.Minutes, 
                                t.Seconds, 
                                t.Milliseconds);
    }
}