using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resources
{
    public class TextResourceBlock : ResourceBlock
    {
        const int PREVIEW_LENGTH = 10;

        public string ResourceText { get; }

        public TextResourceBlock() { }

        public TextResourceBlock(int iSize, string sText)
        {
            m_iSize = iSize;
            ResourceText = sText;

            Data = new byte[iSize * MB];

            byte[] aData = Encoding.Unicode.GetBytes(sText);
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
            string sPreviewString = ResourceText.Length <= PREVIEW_LENGTH ?
                ResourceText : ResourceText.Substring(0, PREVIEW_LENGTH) + "...";

            return String.Format("{0} Mb, {1} item(s). Text \"{2}\"", m_iSize, m_iRepeats, sPreviewString);
        }
    }
}
