namespace spiel
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.TextBox();
            this.capital = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.land = new System.Windows.Forms.RadioButton();
            this.welt = new System.Windows.Forms.RadioButton();
            this.SudAmerika = new System.Windows.Forms.RadioButton();
            this.NordAmerika = new System.Windows.Forms.RadioButton();
            this.regionGroup = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.typGroup = new System.Windows.Forms.GroupBox();
            this.regionGroup.SuspendLayout();
            this.typGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // start
            // 
            this.start.Enabled = false;
            this.start.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start.Location = new System.Drawing.Point(267, 459);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(129, 51);
            this.start.TabIndex = 1;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // result
            // 
            this.result.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result.Location = new System.Drawing.Point(95, 459);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(129, 51);
            this.result.TabIndex = 2;
            this.result.Text = "result";
            this.result.UseVisualStyleBackColor = true;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(164, 101);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(391, 22);
            this.name.TabIndex = 3;
            this.name.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // capital
            // 
            this.capital.AutoSize = true;
            this.capital.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.capital.Location = new System.Drawing.Point(6, 21);
            this.capital.Name = "capital";
            this.capital.Size = new System.Drawing.Size(127, 29);
            this.capital.TabIndex = 4;
            this.capital.Text = "Hauptstadt";
            this.capital.UseVisualStyleBackColor = true;
            this.capital.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(409, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 30);
            this.label2.TabIndex = 9;
            this.label2.Text = "Fragetyp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(144, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 30);
            this.label3.TabIndex = 10;
            this.label3.Text = "Region";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // land
            // 
            this.land.AutoSize = true;
            this.land.Checked = true;
            this.land.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.land.Location = new System.Drawing.Point(6, 74);
            this.land.Name = "land";
            this.land.Size = new System.Drawing.Size(77, 29);
            this.land.TabIndex = 11;
            this.land.TabStop = true;
            this.land.Text = "Land";
            this.land.UseVisualStyleBackColor = true;
            this.land.CheckedChanged += new System.EventHandler(this.land_CheckedChanged);
            // 
            // welt
            // 
            this.welt.AutoSize = true;
            this.welt.Checked = true;
            this.welt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welt.Location = new System.Drawing.Point(6, 31);
            this.welt.Name = "welt";
            this.welt.Size = new System.Drawing.Size(107, 29);
            this.welt.TabIndex = 12;
            this.welt.TabStop = true;
            this.welt.Text = "Weltweit";
            this.welt.UseVisualStyleBackColor = true;
            // 
            // SudAmerika
            // 
            this.SudAmerika.AutoSize = true;
            this.SudAmerika.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SudAmerika.Location = new System.Drawing.Point(6, 77);
            this.SudAmerika.Name = "SudAmerika";
            this.SudAmerika.Size = new System.Drawing.Size(138, 29);
            this.SudAmerika.TabIndex = 13;
            this.SudAmerika.Text = "Südamerika";
            this.SudAmerika.UseVisualStyleBackColor = true;
            this.SudAmerika.CheckedChanged += new System.EventHandler(this.SudAmerika_CheckedChanged);
            // 
            // NordAmerika
            // 
            this.NordAmerika.AutoSize = true;
            this.NordAmerika.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NordAmerika.Location = new System.Drawing.Point(6, 121);
            this.NordAmerika.Name = "NordAmerika";
            this.NordAmerika.Size = new System.Drawing.Size(144, 29);
            this.NordAmerika.TabIndex = 14;
            this.NordAmerika.Text = "Nordamerika";
            this.NordAmerika.UseVisualStyleBackColor = true;
            this.NordAmerika.CheckedChanged += new System.EventHandler(this.NordAmerika_CheckedChanged);
            // 
            // regionGroup
            // 
            this.regionGroup.Controls.Add(this.NordAmerika);
            this.regionGroup.Controls.Add(this.SudAmerika);
            this.regionGroup.Controls.Add(this.welt);
            this.regionGroup.Location = new System.Drawing.Point(111, 208);
            this.regionGroup.Name = "regionGroup";
            this.regionGroup.Size = new System.Drawing.Size(185, 200);
            this.regionGroup.TabIndex = 15;
            this.regionGroup.TabStop = false;
            // 
            // typGroup
            // 
            this.typGroup.Controls.Add(this.land);
            this.typGroup.Controls.Add(this.capital);
            this.typGroup.Location = new System.Drawing.Point(370, 208);
            this.typGroup.Name = "typGroup";
            this.typGroup.Size = new System.Drawing.Size(185, 126);
            this.typGroup.TabIndex = 16;
            this.typGroup.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 539);
            this.Controls.Add(this.typGroup);
            this.Controls.Add(this.regionGroup);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.name);
            this.Controls.Add(this.result);
            this.Controls.Add(this.start);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.regionGroup.ResumeLayout(false);
            this.regionGroup.PerformLayout();
            this.typGroup.ResumeLayout(false);
            this.typGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button result;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.RadioButton capital;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton land;
        private System.Windows.Forms.RadioButton welt;
        private System.Windows.Forms.RadioButton SudAmerika;
        private System.Windows.Forms.RadioButton NordAmerika;
        private System.Windows.Forms.GroupBox regionGroup;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox typGroup;
    }
}

