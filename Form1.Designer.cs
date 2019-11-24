namespace color_reader
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.picStream = new System.Windows.Forms.PictureBox();
            this.colorDATA = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picStream)).BeginInit();
            this.SuspendLayout();
            // 
            // picStream
            // 
            this.picStream.Image = ((System.Drawing.Image)(resources.GetObject("picStream.Image")));
            this.picStream.Location = new System.Drawing.Point(77, 12);
            this.picStream.Name = "picStream";
            this.picStream.Size = new System.Drawing.Size(569, 335);
            this.picStream.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picStream.TabIndex = 0;
            this.picStream.TabStop = false;
            // 
            // colorDATA
            // 
            this.colorDATA.AutoSize = true;
            this.colorDATA.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colorDATA.Location = new System.Drawing.Point(275, 362);
            this.colorDATA.Name = "colorDATA";
            this.colorDATA.Size = new System.Drawing.Size(145, 42);
            this.colorDATA.TabIndex = 1;
            this.colorDATA.Text = "Nodata";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 448);
            this.Controls.Add(this.colorDATA);
            this.Controls.Add(this.picStream);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picStream)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picStream;
        private System.Windows.Forms.Label colorDATA;
    }
}

