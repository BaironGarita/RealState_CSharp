using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;

namespace Controles
{

    /// <summary>
    /// Basado en :
    /// http://www.dotnetperls.com/compress
    /// </summary>
    class Compresor
    {

        public static string Comprimir(string pCadena)
        {

            byte[] raw = Encoding.Unicode.GetBytes(pCadena);
            
            using (MemoryStream memory = new MemoryStream())
            {
                using (GZipStream gzip = new GZipStream(memory, CompressionMode.Compress, true))
                {
                    gzip.Write(raw, 0, raw.Length);
                }
                return Convert.ToBase64String(memory.ToArray());
                
            } 

        }

        public static string Descomprimir(string pCadena)
        {
            // Create a GZIP stream with decompression mode.
            // ... Then create a buffer and write into while reading from the GZIP stream.
 
            byte[] gzip = Convert.FromBase64String(pCadena);

            
            using (GZipStream stream = new GZipStream(new MemoryStream(gzip), CompressionMode.Decompress))
            {
                const int size = 4096;
                byte[] buffer = new byte[size];
                using (MemoryStream memory = new MemoryStream())
                {
                    int count = 0;
                    do
                    {
                        count = stream.Read(buffer, 0, size);
                        if (count > 0)
                        {
                            memory.Write(buffer, 0, count);
                        }
                    }
                    while (count > 0);


                    return Encoding.Unicode.GetString(memory.ToArray());
                }
            }
        }

    }
}
