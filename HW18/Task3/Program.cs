using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Notebook notebook = new Notebook("Paper notebook", "Mark", 12.50);
            notebook.ShowNotebookInfo();
        }
    }
}
