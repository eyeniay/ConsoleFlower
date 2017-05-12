using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÇiçekSepeti
{
    class ContentList
    {
        List<Content> contents = new List<Content>();
        int price;
        string smallSize;


        public ContentList(string smallSize, int price, List<Content> contents)
        {
            this.smallSize = smallSize;
            this.price = price;
            this.contents = contents;
        }


        public override string ToString()
        {
            String content = null;
            foreach (Content contentPart in contents)
            {
                content = content  + contentPart.ToString() + " + ";
            }
            content = content.Substring(0, content.Length - 3);  // en sona eklenen + işaretinin silinmesi

            return string.Format("{0}" + Environment.NewLine +
                                  "  İçerik: {1}" + Environment.NewLine +
                                  "  Fiyat: {2} TL", smallSize,content,price);
        }

        

}
}
