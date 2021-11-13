using System;
using System.IO;
using System.Threading.Tasks;
namespace csharp {
  public class FileOutput {
    private string _fileName;
    private StreamWriter _sw = null;
    public FileOutput(string fileName) {
      this._fileName = fileName;
      try {
        //string[] lines = System.IO.File.ReadAllLines(_fileName);
        this._sw = new StreamWriter(_fileName);
      }catch (Exception e) {
        Console.WriteLine("FileOutput((())) error::"+e.ToString());
      }
    }
    public void FileWrite(string line) {
      try {
        _sw.WriteLine(line);
      }catch (Exception e) {
        Console.WriteLine("FileOutput.FileWrite() error::"+e.ToString());
      }
    }
    public void FileClose() {
      if (_sw != null) {
        try {
          _sw.Close();
        }catch (Exception e) {
          Console.WriteLine("FileOutput.FileClose() error: " + e.ToString());
        }
      }
    }
    public void FileOpen() {
      try {
        this._sw = new StreamWriter(_fileName);
      }catch (Exception e) {
        Console.WriteLine("FileOutput.FileOpen() file error::"+e.ToString());
      }
    }
  }
}

