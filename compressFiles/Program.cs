using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace compressFiles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string file = "mitsos.txt";
            CompressionContext CTX = new CompressionContext(new RarCompression());

            CTX.CreateArchive(file);

            CTX.SetStrategy(new ZipCompression());
            CTX.CreateArchive(file);


            //DECOUPLE

        }
    }
}

public interface ICompression
{
    void CompressFolder(string compressedArchiveFileName);
}

// Concrete Strategy A
// The following RarCompression Concrete Strategy implement the Strategy Interface and 
// Implement the CompressFolder Method. 
public class RarCompression : ICompression
{
    public void CompressFolder(string compressedArchiveFileName)
    {
        Console.WriteLine("Folder is compressed using Rar approach: '" + compressedArchiveFileName + ".rar' file is created");
    }
}

// Concrete Strategy B
// The following ZipCompression Concrete Strategy implement the Strategy Interface and 
// Implement the CompressFolder Method. 
public class ZipCompression : ICompression
{
    public void CompressFolder(string compressedArchiveFileName)
    {
        Console.WriteLine("Folder is compressed using zip approach: '" + compressedArchiveFileName + ".zip' file is created");
    }
}

// The Context Provides the interface which is going to be used by the Client.
public class CompressionContext
{
    //-----------------HIGH LEVEL PROGRAMMER SETS STRATEGY -----START
    private ICompression Compression;

   
    public CompressionContext(ICompression Compression)      // Constructor - Dependancy Injection
    {
        
        this.Compression = Compression;
    }

    
    public void SetStrategy(ICompression Compression)       //Mehtod - Dependency Injection
    {
        this.Compression = Compression;
    }

    //-----------------HIGH LEVEL PROGRAMMER SETS STRATEGY -----END
    public void CreateArchive(string compressedArchiveFileName)
    {
        
        Compression.CompressFolder(compressedArchiveFileName);
    }
}