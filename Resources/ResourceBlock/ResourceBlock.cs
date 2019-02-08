using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resources
{
    public abstract class ResourceBlock
    {
        public const int MB = 1048576;

        public byte[] Data { get; protected set; }

        protected int m_iSize = 0; // in MB
        protected int m_iRepeats = 0;

        public ResourceBlock() { }

        public virtual string GetShortDescription()
        {
            return String.Format("{0} Mb, {1} item(s)", m_iSize, m_iRepeats);
        }

        public abstract string GetFullDescription();
    }
}
