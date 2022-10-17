﻿namespace Blogz
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
            this.DeleteButton = new Blogz.CustomButton();
            this.OpenButton = new Blogz.CustomButton();
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
            // DeleteButton
            // 
            this.DeleteButton.ClickState = Blogz.ClickState.Delete;
            this.DeleteButton.ID = 0;
            this.DeleteButton.Location = new System.Drawing.Point(413, 9);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(50, 23);
            this.DeleteButton.TabIndex = 6;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            // 
            // OpenButton
            // 
            this.OpenButton.BackColor = System.Drawing.Color.SlateGray;
            this.OpenButton.ClickState = Blogz.ClickState.Open;
            this.OpenButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.OpenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.OpenButton.ID = 0;
            this.OpenButton.Location = new System.Drawing.Point(525, 7);
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(50, 24);
            this.OpenButton.TabIndex = 5;
            this.OpenButton.Text = "Open";
            this.OpenButton.UseVisualStyleBackColor = false;
            // 
            // EditButton
            // 
            this.EditButton.ClickState = Blogz.ClickState.Edit;
            this.EditButton.ID = 0;
            this.EditButton.Location = new System.Drawing.Point(469, 8);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(50, 23);
            this.EditButton.TabIndex = 4;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            // 
            // BlogControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.OpenButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.TitleLBL);
            this.Name = "BlogControl";
            this.Size = new System.Drawing.Size(585, 40);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLBL;
        private CustomButton EditButton;
        private CustomButton OpenButton;
        private CustomButton DeleteButton;
    }
}