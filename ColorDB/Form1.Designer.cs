﻿namespace ColorDB
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
            this.label1 = new System.Windows.Forms.Label();
            this.PrimaryColor = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ColorType = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Colors";
            // 
            // PrimaryColor
            // 
            this.PrimaryColor.FormattingEnabled = true;
            this.PrimaryColor.Location = new System.Drawing.Point(57, 133);
            this.PrimaryColor.Name = "PrimaryColor";
            this.PrimaryColor.Size = new System.Drawing.Size(93, 108);
            this.PrimaryColor.TabIndex = 1;
            this.PrimaryColor.SelectedIndexChanged += new System.EventHandler(this.PrimaryColor_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(345, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "ColorType";
            // 
            // ColorType
            // 
            this.ColorType.FormattingEnabled = true;
            this.ColorType.Location = new System.Drawing.Point(339, 130);
            this.ColorType.Name = "ColorType";
            this.ColorType.Size = new System.Drawing.Size(87, 108);
            this.ColorType.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ColorType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PrimaryColor);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox PrimaryColor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox ColorType;
    }
}

