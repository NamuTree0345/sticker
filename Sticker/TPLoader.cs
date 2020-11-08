using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sticker
{
    class TPLoader
    {
        string zip;

        public TPLoader(string zip)
        {
            this.zip = zip;
        }

        public void ExtractZip(string zip)
        {
            ZipFile.ExtractToDirectory(zip, )
        }
    }
}
