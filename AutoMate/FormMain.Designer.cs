namespace AutoMate
{
    partial class FormMain
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
            this.buttonMoveMouse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonMoveMouse
            // 
            this.buttonMoveMouse.Location = new System.Drawing.Point(272, 125);
            this.buttonMoveMouse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonMoveMouse.Name = "buttonMoveMouse";
            this.buttonMoveMouse.Size = new System.Drawing.Size(228, 111);
            this.buttonMoveMouse.TabIndex = 0;
            this.buttonMoveMouse.Text = "Move Mouse";
            this.buttonMoveMouse.UseVisualStyleBackColor = true;
            this.buttonMoveMouse.Click += new System.EventHandler(this.buttonMoveMouse_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.buttonMoveMouse);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonMoveMouse;
    }
}

