namespace Resources
{
    partial class RandomResourceForm
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
            this.textBox_resource_data_hex = new System.Windows.Forms.TextBox();
            this.textBox_summary = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_resource_data_hex
            // 
            this.textBox_resource_data_hex.Location = new System.Drawing.Point(13, 69);
            this.textBox_resource_data_hex.Multiline = true;
            this.textBox_resource_data_hex.Name = "textBox_resource_data_hex";
            this.textBox_resource_data_hex.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_resource_data_hex.Size = new System.Drawing.Size(341, 125);
            this.textBox_resource_data_hex.TabIndex = 7;
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
            this.groupBox1.Location = new System.Drawing.Point(13, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 52);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Summary";
            // 
            // RandomResourceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 201);
            this.Controls.Add(this.textBox_resource_data_hex);
            this.Controls.Add(this.groupBox1);
            this.Name = "RandomResourceForm";
            this.Text = "RandomResourceForm";
            this.Load += new System.EventHandler(this.RandomResourceForm_Load);
            this.Shown += new System.EventHandler(this.RandomResourceForm_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_resource_data_hex;
        private System.Windows.Forms.TextBox textBox_summary;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}