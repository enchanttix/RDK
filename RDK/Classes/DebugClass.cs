using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RDK.Classes
{
    public class DebugClass
    {
        /// <summary>
        /// Вывод отладочной информации в файл
        /// </summary>
        /// <param name="s">Текст для записи в файл</param>
        public static void diagWrite(string s)
        {
            TextWriterTraceListener tr = new TextWriterTraceListener(File.AppendText("Diagnostic.txt"));
            Debug.Listeners.Add(tr);
            Trace.Listeners.Add(tr);
            Debug.WriteLine(s);
            Trace.WriteLine(s);
            Debug.Flush();
            tr.Close();
        }

    }
}
