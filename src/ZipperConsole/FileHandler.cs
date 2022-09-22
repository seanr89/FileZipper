
namespace ZipperConsole;

public static class FileHandler
{
    /// <summary>
    /// Counter check for number of file present
    /// </summary>
    /// <param name="path">folder path to search</param>
    /// <returns></returns>
    public static int getCountOfFilesInFolder(string path)
    {
        int count = 0;
        DirectoryInfo dir = new DirectoryInfo(path);
        foreach(FileInfo fi in dir.GetFiles())
        {
            count++;
        }
        return count;
    }
}