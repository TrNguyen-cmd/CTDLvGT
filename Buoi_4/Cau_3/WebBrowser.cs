using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cau_3
{
    internal class WebBrowser
    {
        public WebBrowser() { }
        public Stack<string> history { get; set; }
        public void Visit(string url)
        {
            history.Push(url);
            Console.WriteLine($"Đang truy cập vào website: {history.Peek()}");
            Console.ReadKey();
        }
        public void Back()
        {
            history.Pop();
            if (history.Count() != 0)
            {
                Console.WriteLine("Trang trước đó truy cập: "+history.Peek());
            }
            else Console.WriteLine("Không có trang trước đó");
        }
        public void CurrentUrl()
        {
            if(history.Count() != 0)
            {
                Console.WriteLine("Trang đang truy cập là: "+history.Peek());
            }
            else Console.WriteLine("Hiện tại k truy cập trang nào");
            Console.ReadKey();
        }
    }
}
