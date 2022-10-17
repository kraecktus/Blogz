namespace Blogz
{
    partial class Form1
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
            this.CategoryFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // CategoryFlowPanel
            // 
            this.CategoryFlowPanel.AutoScroll = true;
            this.CategoryFlowPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CategoryFlowPanel.Location = new System.Drawing.Point(1, 1);
            this.CategoryFlowPanel.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.CategoryFlowPanel.MinimumSize = new System.Drawing.Size(655, 450);
            this.CategoryFlowPanel.Name = "CategoryFlowPanel";
            this.CategoryFlowPanel.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.CategoryFlowPanel.Size = new System.Drawing.Size(655, 450);
            this.CategoryFlowPanel.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CategoryFlowPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel CategoryFlowPanel;
    }
}

