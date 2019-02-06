using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Resources
{
    class ResourceBlock
    {
        enum DataType
        {
            Text,
            Color,
            Random
        }

        public const int MB = 1048576;

        private byte[] m_aData;
        private DataType m_eType;
        private string m_sConsoleString;

        public byte[] Data
        {
            get { return m_aData; }
        }

        public string ConsoleString
        {
            get { return m_sConsoleString; }
        }

        public ResourceBlock() { }

        public ResourceBlock(int iSize)
        {
            m_aData = new byte[iSize * MB];

            Random rand = new Random();
            rand.NextBytes(m_aData);

            m_eType = DataType.Random;

            m_sConsoleString = String.Format("Random bytes. {0} item(s)", m_aData.Length);
        }

        public ResourceBlock(int iSize, string sText)
        {
            m_aData = new byte[iSize * MB];

            byte[] aData = Encoding.Unicode.GetBytes(sText);
            for (int i = 0; i < m_aData.Length / aData.Length; i++)
            {
                Buffer.BlockCopy(aData, 0, m_aData, i * aData.Length, aData.Length);
            }
            
            int treshold = m_aData.Length % aData.Length;
            for (int i = m_aData.Length - treshold; i < m_aData.Length; i++)
            {
                m_aData[i] = 0;
            }

            m_eType = DataType.Text;

            m_sConsoleString = String.Format("Text \"{0}\". {1} item(s)", sText, m_aData.Length / aData.Length);
        }

        public ResourceBlock(int iSize, int iColor)
        {
            m_aData = new byte[iSize * MB];

            byte[] aData = BitConverter.GetBytes(iColor);
            for (int i = 0; i < m_aData.Length / aData.Length; i++)
            {
                Buffer.BlockCopy(aData, 0, m_aData, i * aData.Length, aData.Length);
            }

            int treshold = m_aData.Length % aData.Length;
            for (int i = m_aData.Length - treshold; i < m_aData.Length; i++)
            {
                m_aData[i] = 0;
            }

            m_eType = DataType.Color;

            // Color.FromArgb(iColor).ToString()
            m_sConsoleString = String.Format("Color \"{0}\". {1} item(s)", Color.FromArgb(iColor).Name, m_aData.Length / aData.Length);
        }

        public override string ToString()
        {
            return String.Format("{0} MB - {1}", m_aData.Length / MB, m_eType.ToString());
        }
    }
}
