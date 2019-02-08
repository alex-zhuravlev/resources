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
                    newBlock = new TextResourceBlock(iSizeMB, textBox_text.Text);

                    TextResourceForm textForm = new TextResourceForm();
                    textForm.ResourceBlock = newBlock;
                    textForm.Show();
                    break;

                case 1: // Color
                    colorDialog.ShowDialog();
                    newBlock = new ColorResourceBlock(iSizeMB, colorDialog.Color.ToArgb());

                    ColorResourceForm colorForm = new ColorResourceForm();
                    colorForm.ResourceBlock = newBlock;
                    colorForm.Show();
                    break;

                case 2: // Random
                    newBlock = new RandomResourceBlock(iSizeMB);

                    RandomResourceForm randomForm = new RandomResourceForm();
                    randomForm.ResourceBlock = newBlock;
                    randomForm.Show();
                    break;

                default:
                    MessageBox.Show("Invalid tab selected");
                    return;
            }

            // Cleanup
            textBox_add.Clear();

            // Add
            m_aResourceBlocks.Add(newBlock);
            ConsoleLog(String.Format("Added new resource block: {0}", newBlock.GetFullDescription()));

            UpdateResourcesList();
        }

        private void button_remove_Click(object sender, EventArgs e)
        {
            if (listBox_resources.SelectedIndices.Count == 0) return;

            for (int i = listBox_resources.SelectedIndices.Count - 1; i >= 0; i--)
            {
                int iIndex = listBox_resources.SelectedIndices[i];
                string sConsoleString = m_aResourceBlocks[iIndex].GetFullDescription();

                m_aResourceBlocks.RemoveAt(iIndex);

                ConsoleLog(String.Format("Removed resource block: {0}", sConsoleString));
            }

            GC.Collect();

            UpdateResourcesList();
        }

        private void UpdateResourcesList()
        {
            listBox_resources.Items.Clear();

            for (int i = 0; i < m_aResourceBlocks.Count; i++)
            {
                listBox_resources.Items.Add(String.Format("N{0} - {1}", i + 1, m_aResourceBlocks[i].GetFullDescription()));
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

        private void Resources_Load(object sender, EventArgs e)
        {

        }
    }
}
