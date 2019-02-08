namespace Resources
{
    partial class Resources
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_add = new System.Windows.Forms.TextBox();
            this.AddBlock = new System.Windows.Forms.GroupBox();
            this.tabControl_add = new System.Windows.Forms.TabControl();
            this.tabPage_text = new System.Windows.Forms.TabPage();
            this.textBox_text = new System.Windows.Forms.TextBox();
            this.tabPage_color = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage_random = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button_add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox_resources = new System.Windows.Forms.ListBox();
            this.button_remove = new System.Windows.Forms.Button();
            this.button_remove_all = new System.Windows.Forms.Button();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.textBox_console = new System.Windows.Forms.TextBox();
            this.button_clear_console = new System.Windows.Forms.Button();
            this.AddBlock.SuspendLayout();
            this.tabControl_add.SuspendLayout();
            this.tabPage_text.SuspendLayout();
            this.tabPage_color.SuspendLayout();
            this.tabPage_random.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_add
            // 
            this.textBox_add.Location = new System.Drawing.Point(62, 17);
            this.textBox_add.Name = "textBox_add";
            this.textBox_add.Size = new System.Drawing.Size(66, 20);
            this.textBox_add.TabIndex = 0;
            // 
            // AddBlock
            // 
            this.AddBlock.Controls.Add(this.tabControl_add);
            this.AddBlock.Controls.Add(this.label3);
            this.AddBlock.Controls.Add(this.button_add);
            this.AddBlock.Controls.Add(this.label1);
            this.AddBlock.Controls.Add(this.textBox_add);
            this.AddBlock.Location = new System.Drawing.Point(12, 12);
            this.AddBlock.Name = "AddBlock";
            this.AddBlock.Size = new System.Drawing.Size(377, 203);
            this.AddBlock.TabIndex = 2;
            this.AddBlock.TabStop = false;
            this.AddBlock.Text = "Add resource";
            // 
            // tabControl_add
            // 
            this.tabControl_add.Controls.Add(this.tabPage_text);
            this.tabControl_add.Controls.Add(this.tabPage_color);
            this.tabControl_add.Controls.Add(this.tabPage_random);
            this.tabControl_add.Location = new System.Drawing.Point(62, 43);
            this.tabControl_add.Name = "tabControl_add";
            this.tabControl_add.SelectedIndex = 0;
            this.tabControl_add.Size = new System.Drawing.Size(309, 154);
            this.tabControl_add.TabIndex = 7;
            // 
            // tabPage_text
            // 
            this.tabPage_text.Controls.Add(this.textBox_text);
            this.tabPage_text.Location = new System.Drawing.Point(4, 22);
            this.tabPage_text.Name = "tabPage_text";
            this.tabPage_text.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_text.Size = new System.Drawing.Size(301, 128);
            this.tabPage_text.TabIndex = 0;
            this.tabPage_text.Text = "Text";
            this.tabPage_text.UseVisualStyleBackColor = true;
            // 
            // textBox_text
            // 
            this.textBox_text.Location = new System.Drawing.Point(6, 6);
            this.textBox_text.Multiline = true;
            this.textBox_text.Name = "textBox_text";
            this.textBox_text.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_text.Size = new System.Drawing.Size(289, 116);
            this.textBox_text.TabIndex = 1;
            // 
            // tabPage_color
            // 
            this.tabPage_color.Controls.Add(this.label4);
            this.tabPage_color.Location = new System.Drawing.Point(4, 22);
            this.tabPage_color.Name = "tabPage_color";
            this.tabPage_color.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_color.Size = new System.Drawing.Size(301, 128);
            this.tabPage_color.TabIndex = 1;
            this.tabPage_color.Text = "Color";
            this.tabPage_color.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(85, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Click ADD to pick a color!";
            // 
            // tabPage_random
            // 
            this.tabPage_random.Controls.Add(this.label2);
            this.tabPage_random.Location = new System.Drawing.Point(4, 22);
            this.tabPage_random.Name = "tabPage_random";
            this.tabPage_random.Size = new System.Drawing.Size(301, 128);
            this.tabPage_random.TabIndex = 2;
            this.tabPage_random.Text = "Random";
            this.tabPage_random.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Click ADD to fill with random numbers!";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Data";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(292, 17);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(75, 20);
            this.button_add.TabIndex = 2;
            this.button_add.Text = "ADD";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Size, MB";
            // 
            // listBox_resources
            // 
            this.listBox_resources.FormattingEnabled = true;
            this.listBox_resources.Location = new System.Drawing.Point(12, 221);
            this.listBox_resources.Name = "listBox_resources";
            this.listBox_resources.Size = new System.Drawing.Size(377, 173);
            this.listBox_resources.TabIndex = 3;
            // 
            // button_remove
            // 
            this.button_remove.Location = new System.Drawing.Point(12, 400);
            this.button_remove.Name = "button_remove";
            this.button_remove.Size = new System.Drawing.Size(115, 20);
            this.button_remove.TabIndex = 5;
            this.button_remove.Text = "Remove selected";
            this.button_remove.UseVisualStyleBackColor = true;
            this.button_remove.Click += new System.EventHandler(this.button_remove_Click);
            // 
            // button_remove_all
            // 
            this.button_remove_all.Location = new System.Drawing.Point(144, 400);
            this.button_remove_all.Name = "button_remove_all";
            this.button_remove_all.Size = new System.Drawing.Size(115, 20);
            this.button_remove_all.TabIndex = 6;
            this.button_remove_all.Text = "Remove all";
            this.button_remove_all.UseVisualStyleBackColor = true;
            this.button_remove_all.Click += new System.EventHandler(this.button_remove_all_Click);
            // 
            // textBox_console
            // 
            this.textBox_console.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox_console.BackColor = System.Drawing.Color.Black;
            this.textBox_console.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_console.ForeColor = System.Drawing.Color.LimeGreen;
            this.textBox_console.Location = new System.Drawing.Point(12, 426);
            this.textBox_console.Multiline = true;
            this.textBox_console.Name = "textBox_console";
            this.textBox_console.ReadOnly = true;
            this.textBox_console.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_console.Size = new System.Drawing.Size(377, 157);
            this.textBox_console.TabIndex = 7;
            // 
            // button_clear_console
            // 
            this.button_clear_console.Location = new System.Drawing.Point(274, 400);
            this.button_clear_console.Name = "button_clear_console";
            this.button_clear_console.Size = new System.Drawing.Size(115, 20);
            this.button_clear_console.TabIndex = 8;
            this.button_clear_console.Text = "Clear console";
            this.button_clear_console.UseVisualStyleBackColor = true;
            this.button_clear_console.Click += new System.EventHandler(this.button_clear_console_Click);
            // 
            // Resources
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 595);
            this.Controls.Add(this.button_clear_console);
            this.Controls.Add(this.textBox_console);
            this.Controls.Add(this.button_remove_all);
            this.Controls.Add(this.button_remove);
            this.Controls.Add(this.listBox_resources);
            this.Controls.Add(this.AddBlock);
            this.Name = "Resources";
            this.Text = "Resources";
            this.Load += new System.EventHandler(this.Resources_Load);
            this.AddBlock.ResumeLayout(false);
            this.AddBlock.PerformLayout();
            this.tabControl_add.ResumeLayout(false);
            this.tabPage_text.ResumeLayout(false);
            this.tabPage_text.PerformLayout();
            this.tabPage_color.ResumeLayout(false);
            this.tabPage_color.PerformLayout();
            this.tabPage_random.ResumeLayout(false);
            this.tabPage_random.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_add;
        private System.Windows.Forms.GroupBox AddBlock;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox_resources;
        private System.Windows.Forms.Button button_remove;
        private System.Windows.Forms.Button button_remove_all;
        private System.Windows.Forms.TabControl tabControl_add;
        private System.Windows.Forms.TabPage tabPage_text;
        private System.Windows.Forms.TextBox textBox_text;
        private System.Windows.Forms.TabPage tabPage_color;
        private System.Windows.Forms.TabPage tabPage_random;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_console;
        private System.Windows.Forms.Button button_clear_console;
    }
}

