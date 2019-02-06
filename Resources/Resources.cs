using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resources
{
    public partial class Resources : Form
    {
        private List<ResourceBlock> m_aResourceBlocks = new List<ResourceBlock>();

        public Resources()
        {
            InitializeComponent();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            // Collect data
            int iSizeMB = 0;
            try
            {
                iSizeMB = Convert.ToInt32(textBox_add.Text);
            }
            catch
            {
                MessageBox.Show("Invalid value for resource size");
                return;
            }

            ResourceBlock newBlock = null;
            switch (tabControl_add.SelectedIndex)
            {
                case 0: // Text
                    newBlock = new ResourceBlock(iSizeMB, textBox_text.Text);
                    break;

                case 1: // Color
                    colorDialog.ShowDialog();
                    newBlock = new ResourceBlock(iSizeMB, colorDialog.Color.ToArgb());
                    break;

                case 2: // Random
                    newBlock = new ResourceBlock(iSizeMB);
                    break;

                default:
                    MessageBox.Show("Invalid tab selected");
                    return;
            }

            // MessageBox.Show(System.Text.Encoding.Default.GetString(newBlock.Data));

            // Cleanup
            textBox_add.Clear();

            // Add
            m_aResourceBlocks.Add(newBlock);
            ConsoleLog(String.Format("Added new {0}MB resource block: {1}", iSizeMB, newBlock.ConsoleString));

            UpdateResourcesList();
        }

        private void button_remove_Click(object sender, EventArgs e)
        {
            if (listBox_resources.SelectedIndices.Count == 0) return;

            for (int i = listBox_resources.SelectedIndices.Count - 1; i >= 0; i--)
            {
                int iIndex = listBox_resources.SelectedIndices[i];
                string sConsoleString = m_aResourceBlocks[iIndex].ConsoleString;
                int iSizeMB = m_aResourceBlocks[iIndex].Data.Length / ResourceBlock.MB;

                m_aResourceBlocks.RemoveAt(iIndex);

                ConsoleLog(String.Format("Removed {0}MB resource block: {1}", iSizeMB, sConsoleString));
            }

            GC.Collect();

            UpdateResourcesList();
        }

        private void UpdateResourcesList()
        {
            listBox_resources.Items.Clear();

            int iTotalSize = 0;
            foreach (ResourceBlock block in m_aResourceBlocks)
            {
                iTotalSize += block.Data.Length;
            }

            for (int i = 0; i < m_aResourceBlocks.Count; i++)
            {
                float fSizePercent = (float)m_aResourceBlocks[i].Data.Length / (float)iTotalSize * 100.0f;
                listBox_resources.Items.Add(String.Format("N{0} - {1} - {2:F1}%", i + 1, m_aResourceBlocks[i].ToString(), fSizePercent));
            }
        }

        private void ConsoleLog(string sText)
        {
            textBox_console.AppendText(sText + Environment.NewLine);
        }

        private void button_remove_all_Click(object sender, EventArgs e)
        {
            m_aResourceBlocks.Clear();
            UpdateResourcesList();

            GC.Collect();

            ConsoleLog("Removed all resource blocks.");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button_clear_console_Click(object sender, EventArgs e)
        {
            textBox_console.Clear();
        }
    }
}
