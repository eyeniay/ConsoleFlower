using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÇiçekSepeti
{
    class Content
    {
        string contentName;
        int piece;
        Features features;

        public Content(string contentName, int piece, Features features)
        {
            this.contentName = contentName;
            this.piece = piece;
            this.features = features;
        }

        public override string ToString()
        {
            return string.Format("{0} adet {1}", piece, contentName);
        }


    }
}
