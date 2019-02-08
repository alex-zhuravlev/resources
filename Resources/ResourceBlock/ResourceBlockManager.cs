using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Resources.Core;
using System.Windows.Forms;

namespace Resources
{
    public class ResourceBlockManager : ItmSingleton
    {
        private class ResourceRecord
        {
            public int Id { get; set; } = -1;
            public ResourceBlock ResourceBlock { get; set; } = null;
            public ResourceForm ResourceForm { get; set; } = null;
        }

        private List<ResourceRecord> m_aRecords = new List<ResourceRecord>();

        private static int m_iIdCounter = 0;

        public ResourceBlockManager() { }

        public void InitInstance() { }

        public void AddRecord(ResourceBlock block, ResourceForm form)
        {
            ResourceRecord newRecord = new ResourceRecord();
            newRecord.Id = m_iIdCounter++;
            newRecord.ResourceBlock = block;
            newRecord.ResourceForm = form;

            m_aRecords.Add(newRecord);
        }

        public void RemoveRecord(ResourceBlock block)
        {
            int iIndex = -1;
            for (int i = 0; i < m_aRecords.Count; i++)
            {
                if (m_aRecords[i].ResourceBlock == block)
                {
                    iIndex = i;
                    break;
                }
            }
            if (iIndex >= 0)
            {
                m_aRecords.RemoveAt(iIndex);
            }
        }

        public void RemoveRecord(ResourceForm form)
        {
            int iIndex = -1;
            for (int i = 0; i < m_aRecords.Count; i++)
            {
                if (m_aRecords[i].ResourceForm == form)
                {
                    iIndex = i;
                    break;
                }
            }
            if (iIndex >= 0)
            {
                m_aRecords.RemoveAt(iIndex);
            }
        }

        public void RemoveRecordAt(int iIndex)
        {
            ResourceRecord record = m_aRecords[iIndex];
            record.ResourceForm.OnClose = null; // Do not delete twice
            record.ResourceForm.Close();

            m_aRecords.RemoveAt(iIndex);

            GC.Collect();
        }

        public void Clear()
        {
            foreach (ResourceRecord record in m_aRecords)
            {
                record.ResourceForm.OnClose = null; // Do not delete twice
                record.ResourceForm.Close();
            }
            m_aRecords.Clear();

            GC.Collect();
        }

        public List<string> GetTextListForBox()
        {
            List<string> aList = new List<string>();
            foreach (ResourceRecord record in m_aRecords)
            {
                aList.Add(record.ResourceBlock.GetFullDescription());
            }
            return aList;
        }

        public ResourceBlock GetResourceBlock(int iIndex)
        {
            return m_aRecords[iIndex].ResourceBlock;
        }

        public ResourceBlock GetResourceBlock(ResourceForm form)
        {
            for (int i = 0; i < m_aRecords.Count; i++)
            {
                if (m_aRecords[i].ResourceForm == form)
                    return m_aRecords[i].ResourceBlock;
            }
            return null;
        }
    }
}
