using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sticker
{
    public class TexturePack
    {
        public Image idle;
        public Image hello;
        public Image bye;
        public Image walk;
        public Image jump;
        public Image handle;
        public Image hurt;

        public string name;
        public string description;

        public TexturePack(string name, string description, Image idle, Image hello, Image bye, Image walk, Image jump, Image handle, Image hurt)
        {
            this.name = name;
            this.description = description;
            this.idle = idle;
            this.hello = hello;
            this.bye = bye;
            this.walk = walk;
            this.jump = jump;
            this.handle = handle;
            this.hurt = hurt;
        }
    }
}
