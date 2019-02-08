using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Resources
{
    public class RandomResourceBlock : ResourceBlock
    {
        public RandomResourceBlock() { }

        public RandomResourceBlock(int iSize)
        {
            m_iSize = iSize;

            Data = new byte[iSize * MB];

            m_iRepeats = Data.Length;

            Random rand = new Random();
            rand.NextBytes(Data);
        }

        public override string GetFullDescription()
        {
            return String.Format("{0} Mb, {1} item(s). Random data", m_iSize, m_iRepeats);
        }
    }
}
