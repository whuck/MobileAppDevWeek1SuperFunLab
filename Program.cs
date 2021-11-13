using System;
using System.Collections;
namespace csharp
{
    class Program
    {
        private readonly static FileOutput _outFile = new FileOutput("animals.txt");
        private readonly static FileInput _inFile = new FileInput("animals.txt");
        static void Main(string[] args)
        {
            FileOutput _fileOut = new FileOutput("animals.txt");
            //_fileInput.FileClose();
            //_fileOut.FileClose();
            ArrayList zoo = new ArrayList();
            zoo.Add(new Dog(true, "Bean"));
            zoo.Add(new Cat(9, "Charlie"));
            zoo.Add(new Teacher(44, "Stacy Read"));
            
           // _fileOut.FileOpen();
            //_inFile.FileClose();
            foreach(ITalkable thing in zoo) {
              PrintOut(thing);
              _fileOut.FileWrite(thing.GetName() + " | " + thing.Talk());
            }
            //_fileOut.FileClose();
            
            //_fileInput.FileRead();
            // _fileInput.FileClose();
            // _fileInput.FileClose();
            // FileInput inData = new FileInput("animals.txt");
            // string line;
            // while ((line = inData.FileReadLine()) != null) {
            //     Console.WriteLine(line);
            // }

        }
        public static void PrintOut(ITalkable p) {
           // _outFile.FileOpen();
            Console.WriteLine(p.GetName() + " says=" + p.Talk());
            //_outFile.FileWrite(p.GetName() + " | " + p.Talk());
            //_outFile.FileClose();
        }
    }
}
