using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÇiçekSepeti
{
    class Bouquet
    {
        public string bouquetName { get; set; }
        public ContentList smallSize { get; set; }
        public ContentList mediumSize { get; set; }
        public ContentList largeSize { get; set; }

        public override string ToString()
        {
            return string.Format("{0}"+ Environment.NewLine+
                                  " {1}" + Environment.NewLine +
                                  " {2}" + Environment.NewLine +
                                  " {3}", bouquetName, smallSize.ToString(),mediumSize.ToString(),largeSize.ToString());
        }

    }
}
