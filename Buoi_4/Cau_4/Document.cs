using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cau_4
{
    internal class Document
    {
        public Document() { }
        public Stack<string> versions { get; set; }
        public string currentContent { get; set; }
        public void Edit(string newContent)
        {
            versions.Push(currentContent);
            currentContent = newContent;
        }
        public void Undo()
        {
            if (versions.Count > 0)
            {
                versions.Pop();
                Console.WriteLine($"Đã trả về phiên bản trước đó");
            }
            else Console.WriteLine("Đây đã là phiên bản cũ nhất");
        }
        public void ViewCurrentVersion()
        {
            Console.Write("Nội dung hiện tại: "+ versions.Peek());
        }
        public void ViewHistory()
        {
            foreach(var version in versions)
            {
                Console.WriteLine(version);
            }
        }

    }
}
