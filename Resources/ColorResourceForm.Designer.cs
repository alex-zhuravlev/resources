namespace Resources
{
    partial class ColorResourceForm
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
            this.textBox_summary = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel_color = new System.Windows.Forms.Panel();
            this.textBox_resource_data_hex = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_summary
            // 
            this.textBox_summary.Location = new System.Drawing.Point(7, 20);
            this.textBox_summary.Name = "textBox_summary";
            this.textBox_summary.ReadOnly = true;
            this.textBox_summary.Size = new System.Drawing.Size(327, 20);
            this.textBox_summary.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_summary);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 52);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Summary";
            // 
            // panel_color
            // 
            this.panel_color.Location = new System.Drawing.Point(12, 70);
            this.panel_color.Name = "panel_color";
            this.panel_color.Size = new System.Drawing.Size(341, 80);
            this.panel_color.TabIndex = 4;
            // 
            // textBox_resource_data_hex
            // 
            this.textBox_resource_data_hex.Location = new System.Drawing.Point(11, 156);
            this.textBox_resource_data_hex.Multiline = true;
            this.textBox_resource_data_hex.Name = "textBox_resource_data_hex";
            this.textBox_resource_data_hex.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_resource_data_hex.Size = new System.Drawing.Size(341, 125);
            this.textBox_resource_data_hex.TabIndex = 5;
            // 
            // ColorResourceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 291);
            this.Controls.Add(this.textBox_resource_data_hex);
            this.Controls.Add(this.panel_color);
            this.Controls.Add(this.groupBox1);
            this.Name = "ColorResourceForm";
            this.Text = "ColorResource";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ColorResourceForm_FormClosing);
            this.Load += new System.EventHandler(this.ColorResourceForm_Load);
            this.Shown += new System.EventHandler(this.ColorResourceForm_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_summary;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel_color;
        private System.Windows.Forms.TextBox textBox_resource_data_hex;
    }
}