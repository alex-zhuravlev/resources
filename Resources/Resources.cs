using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Resources.Core;

namespace Resources
{
    public partial class Resources : Form
    {
        public delegate void OnChildFormClosed(ResourceForm f);

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
            ResourceForm newForm = null;
            switch (tabControl_add.SelectedIndex)
            {
                case 0: // Text
                    newBlock = new TextResourceBlock(iSizeMB, textBox_text.Text);

                    TextResourceForm textForm = new TextResourceForm();
                    textForm.ResourceBlock = newBlock;
                    textForm.OnClose = OnResourceFormClosed;
                    newForm = textForm;
                    break;

                case 1: // Color
                    colorDialog.ShowDialog();
                    newBlock = new ColorResourceBlock(iSizeMB, colorDialog.Color.ToArgb());

                    ColorResourceForm colorForm = new ColorResourceForm();
                    colorForm.ResourceBlock = newBlock;
                    colorForm.OnClose = OnResourceFormClosed;
                    newForm = colorForm;
                    break;

                case 2: // Random
                    newBlock = new RandomResourceBlock(iSizeMB);

                    RandomResourceForm randomForm = new RandomResourceForm();
                    randomForm.ResourceBlock = newBlock;
                    randomForm.OnClose = OnResourceFormClosed;
                    newForm = randomForm;
                    break;

                default:
                    MessageBox.Show("Invalid tab selected");
                    return;
            }

            // Cleanup
            textBox_add.Clear();

            // Add
            tmSingleton<ResourceBlockManager>.Instance.AddRecord(newBlock, newForm);
            newForm.Show();

            ConsoleLog(String.Format("Added new resource block: {0}", newBlock.GetFullDescription()));

            UpdateResourcesList();
        }

        private void button_remove_Click(object sender, EventArgs e)
        {
            if (listBox_resources.SelectedIndices.Count == 0) return;

            if (listBox_resources.SelectedIndices.Count > 1)
                throw new NotImplementedException();

            int iIndex = listBox_resources.SelectedIndices[0];

            string sConsoleString = tmSingleton<ResourceBlockManager>.Instance.GetResourceBlock(iIndex).GetFullDescription();
            tmSingleton<ResourceBlockManager>.Instance.RemoveRecordAt(iIndex);

            ConsoleLog(String.Format("Removed resource block: {0}", sConsoleString));

            UpdateResourcesList();
        }

        private void OnResourceFormClosed(ResourceForm form)
        {
            ResourceBlock block = tmSingleton<ResourceBlockManager>.Instance.GetResourceBlock(form);
            if (block == null) return;

            string sConsoleString = block.GetFullDescription();
            tmSingleton<ResourceBlockManager>.Instance.RemoveRecord(form);

            ConsoleLog(String.Format("Removed resource block: {0}", sConsoleString));

            UpdateResourcesList();
        }

        private void UpdateResourcesList()
        {
            listBox_resources.Items.Clear();

            List<string> aDescriptions = tmSingleton<ResourceBlockManager>.Instance.GetTextListForBox();

            for (int i = 0; i < aDescriptions.Count; i++)
            {
                listBox_resources.Items.Add(String.Format("N{0} - {1}", i + 1, aDescriptions[i]));
            }
        }

        private void ConsoleLog(string sText)
        {
            textBox_console.AppendText(sText + Environment.NewLine);
        }

        private void button_remove_all_Click(object sender, EventArgs e)
        {
            tmSingleton<ResourceBlockManager>.Instance.Clear();

            UpdateResourcesList();

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
