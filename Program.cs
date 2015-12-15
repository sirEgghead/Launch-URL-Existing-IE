using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SHDocVw;

namespace Launch_URL_Existing_IE
{
    class Program
    {
        static void Main(string[] args)
        {
            ShellWindows ieInstances = new SHDocVw.ShellWindows();
            if (ieInstances.Count > 0)
            {
                System.Collections.IEnumerator enumerator = ieInstances.GetEnumerator();
                enumerator.MoveNext();
                InternetExplorer iExplorer = (InternetExplorer)enumerator.Current;
                iExplorer.Navigate("http://www.losethegame.net", 0x800);
            }
        }
    }
}