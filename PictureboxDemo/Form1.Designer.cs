namespace PictureboxDemo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.picBestGame1 = new System.Windows.Forms.PictureBox();
            this.picAverageGame1 = new System.Windows.Forms.PictureBox();
            this.picWorstGame1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBestGame1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAverageGame1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWorstGame1)).BeginInit();
            this.SuspendLayout();
            // 
            // picBestGame1
            // 
            this.picBestGame1.Image = ((System.Drawing.Image)(resources.GetObject("picBestGame1.Image")));
            this.picBestGame1.Location = new System.Drawing.Point(0, 67);
            this.picBestGame1.Name = "picBestGame1";
            this.picBestGame1.Size = new System.Drawing.Size(261, 259);
            this.picBestGame1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBestGame1.TabIndex = 0;
            this.picBestGame1.TabStop = false;
            this.picBestGame1.Visible = false;
            // 
            // picAverageGame1
            // 
            this.picAverageGame1.Image = ((System.Drawing.Image)(resources.GetObject("picAverageGame1.Image")));
            this.picAverageGame1.Location = new System.Drawing.Point(267, 67);
            this.picAverageGame1.Name = "picAverageGame1";
            this.picAverageGame1.Size = new System.Drawing.Size(261, 259);
            this.picAverageGame1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAverageGame1.TabIndex = 1;
            this.picAverageGame1.TabStop = false;
            this.picAverageGame1.Visible = false;
            // 
            // picWorstGame1
            // 
            this.picWorstGame1.Image = ((System.Drawing.Image)(resources.GetObject("picWorstGame1.Image")));
            this.picWorstGame1.Location = new System.Drawing.Point(534, 67);
            this.picWorstGame1.Name = "picWorstGame1";
            this.picWorstGame1.Size = new System.Drawing.Size(261, 259);
            this.picWorstGame1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picWorstGame1.TabIndex = 2;
            this.picWorstGame1.TabStop = false;
            this.picWorstGame1.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 332);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(261, 33);
            this.button1.TabIndex = 3;
            this.button1.Text = "Best Game";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(267, 332);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(261, 33);
            this.button2.TabIndex = 4;
            this.button2.Text = "Average Game";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(534, 332);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(261, 33);
            this.button3.TabIndex = 5;
            this.button3.Text = "Worst Game";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.picWorstGame1);
            this.Controls.Add(this.picAverageGame1);
            this.Controls.Add(this.picBestGame1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picBestGame1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAverageGame1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWorstGame1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox picBestGame1;
        private PictureBox picAverageGame1;
        private PictureBox picWorstGame1;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}