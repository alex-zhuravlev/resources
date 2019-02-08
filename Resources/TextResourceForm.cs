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
    public partial class TextResourceForm : Form
    {
        const int DATA_PREVIEW_SIZE = 1024;

        public ResourceBlock ResourceBlock { get; set; } = null;

        public TextResourceForm()
        {
            InitializeComponent();
        }

        private void TextResourceForm_Load(object sender, EventArgs e)
        {

        }

        private void TextResourceForm_Shown(object sender, EventArgs e)
        {
            InitWindow();
        }

        private void InitWindow()
        {
            if (ResourceBlock == null) return;

            TextResourceBlock block = (TextResourceBlock)ResourceBlock;

            textBox_summary.Text = block.GetShortDescription();

            textBox_text_resource.Text = block.ResourceText;

            if (block.Data.Length > DATA_PREVIEW_SIZE)
            {
                textBox_resource_data.Text = Encoding.Unicode.GetString(block.Data, 0, DATA_PREVIEW_SIZE) + "...";
            }
            else
            {
                textBox_resource_data.Text = Encoding.Unicode.GetString(block.Data);
            }

            StringBuilder hexBuilder = new StringBuilder(block.Data.Length * 2);
            for (int i = 0; i < block.Data.Length && i < DATA_PREVIEW_SIZE; i++)
                hexBuilder.AppendFormat("{0:x2} ", block.Data[i]);
            textBox_resource_data_hex.Text = hexBuilder.ToString();
        }
    }
}
