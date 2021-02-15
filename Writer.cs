using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace synchronous_recording
{
    public class Writer
    {
        public void func(List<string> temp)
        {
            using (StreamWriter sw = new StreamWriter("temp.txt", false, System.Text.Encoding.UTF8))
            {
                for (int i = 0; i < temp.Count; i++)
                {
                    sw.WriteLine(temp[i]);
                }
            }
        }
    }
}
