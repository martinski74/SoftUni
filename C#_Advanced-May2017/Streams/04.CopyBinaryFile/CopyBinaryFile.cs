using System;
using System.IO;

namespace _04.CopyBinaryFile
{
    class CopyBinaryFile
    {
        static void Main()
        {
            using(var file = new FileStream("../../pic.png",FileMode.Open))
            {
                using(var newFile = new FileStream("../../result.png",FileMode.Create))
                {
                    var buffer = new byte[4096];
                    var byteCount = file.Read(buffer,0,buffer.Length);

                    while (byteCount != 0)
                    {
                        newFile.Write(buffer,0,byteCount);
                        byteCount = file.Read(buffer, 0, buffer.Length);
                    }
                }
            }
        }
    }
}
