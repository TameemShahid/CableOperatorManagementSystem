namespace CableMangementSystem
{
    partial class ShowCityForm
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
            this.ShowCityListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // ShowCityListBox
            // 
            this.ShowCityListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ShowCityListBox.FormattingEnabled = true;
            this.ShowCityListBox.ItemHeight = 20;
            this.ShowCityListBox.Location = new System.Drawing.Point(12, 22);
            this.ShowCityListBox.Name = "ShowCityListBox";
            this.ShowCityListBox.Size = new System.Drawing.Size(648, 424);
            this.ShowCityListBox.TabIndex = 0;
            // 
            // ShowCityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 468);
            this.Controls.Add(this.ShowCityListBox);
            this.Name = "ShowCityForm";
            this.Text = "Show Provider City ";
            this.Load += new System.EventHandler(this.ShowCityForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ShowCityListBox;
    }
}