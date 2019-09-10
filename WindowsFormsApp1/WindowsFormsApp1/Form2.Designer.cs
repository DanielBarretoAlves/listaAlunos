namespace WindowsFormsApp1
{
    partial class Form2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.okJson = new System.Windows.Forms.Button();
            this.selectJson = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.selectJson);
            this.panel1.Location = new System.Drawing.Point(66, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(353, 133);
            this.panel1.TabIndex = 0;
            // 
            // okJson
            // 
            this.okJson.Location = new System.Drawing.Point(204, 208);
            this.okJson.Name = "okJson";
            this.okJson.Size = new System.Drawing.Size(75, 23);
            this.okJson.TabIndex = 1;
            this.okJson.Text = "OK";
            this.okJson.UseVisualStyleBackColor = true;
            // 
            // selectJson
            // 
            this.selectJson.AutoSize = true;
            this.selectJson.Location = new System.Drawing.Point(20, 14);
            this.selectJson.Name = "selectJson";
            this.selectJson.Size = new System.Drawing.Size(0, 13);
            this.selectJson.TabIndex = 0;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 257);
            this.Controls.Add(this.okJson);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label selectJson;
        private System.Windows.Forms.Button okJson;
    }
}