namespace spiel
{
    partial class Form2
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
            this.frage = new System.Windows.Forms.Label();
            this.antwort1 = new System.Windows.Forms.Button();
            this.antwort3 = new System.Windows.Forms.Button();
            this.antwort2 = new System.Windows.Forms.Button();
            this.antwort4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.score = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // frage
            // 
            this.frage.AutoSize = true;
            this.frage.Location = new System.Drawing.Point(126, 68);
            this.frage.Name = "frage";
            this.frage.Size = new System.Drawing.Size(38, 16);
            this.frage.TabIndex = 1;
            this.frage.Text = "frage";
            // 
            // antwort1
            // 
            this.antwort1.Location = new System.Drawing.Point(526, 184);
            this.antwort1.Name = "antwort1";
            this.antwort1.Size = new System.Drawing.Size(206, 50);
            this.antwort1.TabIndex = 2;
            this.antwort1.Text = "antwort1";
            this.antwort1.UseVisualStyleBackColor = true;
            this.antwort1.Click += new System.EventHandler(this.antwort1_Click);
            // 
            // antwort3
            // 
            this.antwort3.Location = new System.Drawing.Point(526, 320);
            this.antwort3.Name = "antwort3";
            this.antwort3.Size = new System.Drawing.Size(206, 50);
            this.antwort3.TabIndex = 3;
            this.antwort3.Text = "antwort3";
            this.antwort3.UseVisualStyleBackColor = true;
            this.antwort3.Click += new System.EventHandler(this.antwort3_Click_1);
            // 
            // antwort2
            // 
            this.antwort2.Location = new System.Drawing.Point(72, 184);
            this.antwort2.Name = "antwort2";
            this.antwort2.Size = new System.Drawing.Size(206, 50);
            this.antwort2.TabIndex = 4;
            this.antwort2.Text = "antwort2";
            this.antwort2.UseVisualStyleBackColor = true;
            this.antwort2.Click += new System.EventHandler(this.antwort2_Click_1);
            // 
            // antwort4
            // 
            this.antwort4.Location = new System.Drawing.Point(72, 307);
            this.antwort4.Name = "antwort4";
            this.antwort4.Size = new System.Drawing.Size(206, 50);
            this.antwort4.TabIndex = 5;
            this.antwort4.Text = "antwort4";
            this.antwort4.UseVisualStyleBackColor = true;
            this.antwort4.Click += new System.EventHandler(this.antwort4_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(611, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "score:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.Location = new System.Drawing.Point(661, 19);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(18, 20);
            this.score.TabIndex = 7;
            this.score.Text = "0";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 416);
            this.Controls.Add(this.score);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.antwort4);
            this.Controls.Add(this.antwort2);
            this.Controls.Add(this.antwort3);
            this.Controls.Add(this.antwort1);
            this.Controls.Add(this.frage);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label frage;
        private System.Windows.Forms.Button antwort1;
        private System.Windows.Forms.Button antwort3;
        private System.Windows.Forms.Button antwort2;
        private System.Windows.Forms.Button antwort4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label score;
    }
}