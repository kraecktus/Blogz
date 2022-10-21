namespace Blogz
{
    partial class BlogControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TitleLBL = new System.Windows.Forms.Label();
            this.OpenButton = new Blogz.CustomButton();
            this.DeleteButton = new Blogz.CustomButton();
            this.EditButton = new Blogz.CustomButton();
            this.SuspendLayout();
            // 
            // TitleLBL
            // 
            this.TitleLBL.AutoSize = true;
            this.TitleLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLBL.Location = new System.Drawing.Point(8, 9);
            this.TitleLBL.Name = "TitleLBL";
            this.TitleLBL.Size = new System.Drawing.Size(60, 22);
            this.TitleLBL.TabIndex = 0;
            this.TitleLBL.Text = "TITLE";
            // 
            // OpenButton
            // 
            this.OpenButton.BackColor = System.Drawing.Color.SlateGray;
            this.OpenButton.BlogID = "Blog0000";
            this.OpenButton.CategoryID = "Category0000";
            this.OpenButton.ClickState = Blogz.ClickState.Open;
            this.OpenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.OpenButton.Location = new System.Drawing.Point(535, 8);
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(53, 23);
            this.OpenButton.TabIndex = 10;
            this.OpenButton.Text = "Open";
            this.OpenButton.UseVisualStyleBackColor = false;
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.DarkGray;
            this.DeleteButton.BlogID = "Blog0000";
            this.DeleteButton.CategoryID = "Category0000";
            this.DeleteButton.ClickState = Blogz.ClickState.Delete;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Location = new System.Drawing.Point(423, 8);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(50, 23);
            this.DeleteButton.TabIndex = 9;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.BackColor = System.Drawing.Color.DarkGray;
            this.EditButton.BlogID = "Blog0000";
            this.EditButton.CategoryID = "Category0000";
            this.EditButton.ClickState = Blogz.ClickState.Edit;
            this.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditButton.Location = new System.Drawing.Point(479, 8);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(50, 23);
            this.EditButton.TabIndex = 8;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = false;
            // 
            // BlogControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Controls.Add(this.OpenButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.TitleLBL);
            this.Name = "BlogControl";
            this.Size = new System.Drawing.Size(597, 40);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLBL;
        private CustomButton EditButton;
        private CustomButton DeleteButton;
        private CustomButton OpenButton;
    }
}
