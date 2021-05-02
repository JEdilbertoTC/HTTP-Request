
namespace Spotify_API
{
    partial class Spotify
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
            this.button1 = new System.Windows.Forms.Button();
            this.SArtist = new System.Windows.Forms.TextBox();
            this.IDPlaylist = new System.Windows.Forms.Button();
            this.SPlaylist = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.playid = new System.Windows.Forms.TextBox();
            this.uris = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 21);
            this.button1.TabIndex = 0;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SArtist
            // 
            this.SArtist.Location = new System.Drawing.Point(88, 13);
            this.SArtist.Name = "SArtist";
            this.SArtist.Size = new System.Drawing.Size(100, 20);
            this.SArtist.TabIndex = 3;
            // 
            // IDPlaylist
            // 
            this.IDPlaylist.Location = new System.Drawing.Point(194, 12);
            this.IDPlaylist.Name = "IDPlaylist";
            this.IDPlaylist.Size = new System.Drawing.Size(71, 21);
            this.IDPlaylist.TabIndex = 4;
            this.IDPlaylist.Text = "IDPlaylist";
            this.IDPlaylist.UseVisualStyleBackColor = true;
            this.IDPlaylist.Click += new System.EventHandler(this.IDPlaylist_Click);
            // 
            // SPlaylist
            // 
            this.SPlaylist.Location = new System.Drawing.Point(271, 13);
            this.SPlaylist.Name = "SPlaylist";
            this.SPlaylist.Size = new System.Drawing.Size(100, 20);
            this.SPlaylist.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(733, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "CreatePlayList";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(759, 44);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(759, 70);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(718, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(693, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Description";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(866, 70);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "Save";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(733, 96);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(117, 23);
            this.button4.TabIndex = 12;
            this.button4.Text = "AddTrackToPlayList";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(701, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "playlist_id";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(730, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "uris";
            // 
            // playid
            // 
            this.playid.Location = new System.Drawing.Point(759, 146);
            this.playid.Name = "playid";
            this.playid.Size = new System.Drawing.Size(100, 20);
            this.playid.TabIndex = 15;
            // 
            // uris
            // 
            this.uris.Location = new System.Drawing.Point(759, 188);
            this.uris.Name = "uris";
            this.uris.Size = new System.Drawing.Size(100, 20);
            this.uris.TabIndex = 16;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(866, 185);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 17;
            this.button5.Text = "Save";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Spotify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = global::Spotify_API.Properties.Resources.Fondo;
            this.ClientSize = new System.Drawing.Size(953, 452);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.uris);
            this.Controls.Add(this.playid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.SPlaylist);
            this.Controls.Add(this.IDPlaylist);
            this.Controls.Add(this.SArtist);
            this.Controls.Add(this.button1);
            this.Name = "Spotify";
            this.Text = "Spotify Chafa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox SArtist;
        private System.Windows.Forms.Button IDPlaylist;
        private System.Windows.Forms.TextBox SPlaylist;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox playid;
        private System.Windows.Forms.TextBox uris;
        private System.Windows.Forms.Button button5;
    }
}

