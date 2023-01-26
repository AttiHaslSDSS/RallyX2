namespace RallyX
{
    partial class RallyX
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public new SizeF AutoScaleDimensions { get; private set; }
        public new AutoScaleMode AutoScaleMode { get; private set; }
        public new Size ClientSize { get; private set; }
        public new string Name { get; private set; }

        private string text;

        public string GetText()
        {
            return text;
        }

        private void SetText(string value)
        {
            text = value;
        }

        public new EventHandler Load { get; private set; }

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (RallyX_Load != null))
            {
                components.Dispose();
            }
            object value = base.Dispose(disposing: disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeRallyX()
        {
            this.SuspendLayout();
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "Form1";
            this.SetText("Form1");
            this.Load += new System.EventHandler(this.RallyX_Load);
            this.ResumeLayout(false);

        }

        private new void SuspendLayout()
        {
            throw new NotImplementedException();
        }

        private new void ResumeLayout(bool v)
        {
            throw new NotImplementedException();
        }

        private void RallyX_Load(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Timer gameTimer;
    }
}