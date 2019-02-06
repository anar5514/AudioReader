namespace BabatAudioBook
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
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.listView = new System.Windows.Forms.ListView();
            this.btnPlay = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(401, 12);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(90, 56);
            this.btnLeft.TabIndex = 1;
            this.btnLeft.Text = "<";
            this.btnLeft.UseVisualStyleBackColor = true;
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(685, 13);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(90, 56);
            this.btnRight.TabIndex = 1;
            this.btnRight.Text = ">";
            this.btnRight.UseVisualStyleBackColor = true;
            // 
            // listView
            // 
            this.listView.AllowDrop = true;
            this.listView.Location = new System.Drawing.Point(13, 13);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(353, 383);
            this.listView.TabIndex = 3;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.SelectedIndexChanged += new System.EventHandler(this.listView_SelectedIndexChanged);
            this.listView.DragDrop += new System.Windows.Forms.DragEventHandler(this.listView_DragDrop);
            this.listView.DragEnter += new System.Windows.Forms.DragEventHandler(this.listView_DragEnter);
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(161, 402);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(403, 47);
            this.btnPlay.TabIndex = 4;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Location = new System.Drawing.Point(385, 75);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(403, 321);
            this.pictureBox.TabIndex = 5;
            this.pictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnLeft);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.PictureBox pictureBox;
    }
}

