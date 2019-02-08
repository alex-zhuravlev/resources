using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Resources
{
    public class ColorResourceBlock : ResourceBlock
    {
        public int ResourceColor { get; }

        public ColorResourceBlock() { }


        public ColorResourceBlock(int iSize, int iColor)
        {
            m_iSize = iSize;
            ResourceColor = iColor;

            Data = new byte[iSize * MB];

            byte[] aData = BitConverter.GetBytes(iColor);
            m_iRepeats = Data.Length / aData.Length;
            for (int i = 0; i < m_iRepeats; i++)
            {
                Buffer.BlockCopy(aData, 0, Data, i * aData.Length, aData.Length);
            }

            int treshold = Data.Length % aData.Length;
            for (int i = Data.Length - treshold; i < Data.Length; i++)
            {
                Data[i] = 0;
            }
        }

        public override string GetFullDescription()
        {
            return String.Format("{0} Mb, {1} item(s). Color \"{2}\"", m_iSize, m_iRepeats, Color.FromArgb(ResourceColor).Name);
        }
    }
}
