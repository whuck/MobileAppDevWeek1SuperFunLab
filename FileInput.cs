using System;
using System.IO;
namespace csharp {
  public class FileInput {
    private String _fileName;
    private StreamReader _sr = null;
    public FileInput(string fileName) {
      this._fileName = fileName;
      try {
        this._sr = new StreamReader(_fileName);
      }catch (Exception e) {
        Console.WriteLine("FileInput() file error::"+e.ToString());
      }
    }
    public void FileRead() {
      String line;
      try {
        line = _sr.ReadLine();
        while (line != null)
        {
            Console.WriteLine("\t" + line);
            line = _sr.ReadLine();
        }
      }catch (Exception e) {
        Console.WriteLine("FileInput.FileRead() file error::"+e.ToString());
      }
    }
    public String FileReadLine() {
      try{
        return _sr.ReadLine();
      }catch (Exception e) {
        Console.WriteLine("FileInput.FileReadLine() file error::"+e.ToString());
        return null;
      }
    }
    public void FileClose() {
      if (_sr != null) {
        try {
          _sr.Close();
        }catch (Exception e) {
          Console.WriteLine("FileInput.FileClose() error: " + e.ToString());
        }
      }
    }
    public void FileOpen() {
      try {
        this._sr = new StreamReader(_fileName);
      }catch (Exception e) {
        Console.WriteLine("FileInput().FileOpen() file error::"+e.ToString());
      }
    }
  }
}