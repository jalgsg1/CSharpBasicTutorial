// using System.IO;

namespace FileSystemReadExample {
  
  class ReadDir {
    public void listOfDirectoriesAndFiles(string folderPath = "Tutorial examples/FileSystemExample/dirExample") {
      IEnumerable<string> listOfDirectories = Directory.EnumerateDirectories(folderPath);
      foreach (string dir in listOfDirectories) {
        Console.WriteLine(dir);
      }

      Console.WriteLine("\nShowing example Files in a directory");
      IEnumerable<string> files = Directory.EnumerateFiles(folderPath);
      foreach (string file in files) {
          Console.WriteLine(file);
      }

      // Find all *.txt files in the dirExample folder and its subfolders
      // Outputs:
      // stores/totals.txt
      // stores/201/inventory.txt
      Console.WriteLine("\nShowing all .txt files directory or subDirectories");
      IEnumerable<string> allFilesInAllFolders = Directory.EnumerateFiles(folderPath, "*.txt", SearchOption.AllDirectories);
      foreach (string file in allFilesInAllFolders) {
          Console.WriteLine(file);
      }
     
    }
  }
}


