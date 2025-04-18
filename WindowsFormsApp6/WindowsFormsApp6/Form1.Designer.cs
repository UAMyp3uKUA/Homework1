namespace WindowsFormsApp6
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Button moleButton1;
        private System.Windows.Forms.Button moleButton2;
        private System.Windows.Forms.Button moleButton3;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblScore = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.moleButton1 = new System.Windows.Forms.Button();
            this.moleButton2 = new System.Windows.Forms.Button();
            this.moleButton3 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 12);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(100, 30);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Старт";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblScore.ForeColor = System.Drawing.Color.Black;
            this.lblScore.Location = new System.Drawing.Point(130, 18);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(58, 17);
            this.lblScore.TabIndex = 1;
            this.lblScore.Text = "Очки: 0";
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 1000;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // moleButton1
            // 
            this.moleButton1.Font = new System.Drawing.Font("Segoe UI Emoji", 20F);
            this.moleButton1.Location = new System.Drawing.Point(200, 150);
            this.moleButton1.Name = "moleButton1";
            this.moleButton1.Size = new System.Drawing.Size(60, 60);
            this.moleButton1.TabIndex = 2;
            this.moleButton1.Text = "🐹";
            this.moleButton1.UseVisualStyleBackColor = true;
            this.moleButton1.Visible = false;
            this.moleButton1.Click += new System.EventHandler(this.moleButton_Click);
            // 
            // moleButton2
            // 
            this.moleButton2.Font = new System.Drawing.Font("Segoe UI Emoji", 20F);
            this.moleButton2.Location = new System.Drawing.Point(200, 150);
            this.moleButton2.Name = "moleButton2";
            this.moleButton2.Size = new System.Drawing.Size(60, 60);
            this.moleButton2.TabIndex = 2;
            this.moleButton2.Text = "🐹";
            this.moleButton2.UseVisualStyleBackColor = true;
            this.moleButton2.Visible = false;
            this.moleButton2.Click += new System.EventHandler(this.moleButton_Click);
            // 
            // moleButton3
            // 
            this.moleButton3.Font = new System.Drawing.Font("Segoe UI Emoji", 20F);
            this.moleButton3.Location = new System.Drawing.Point(200, 150);
            this.moleButton3.Name = "moleButton3";
            this.moleButton3.Size = new System.Drawing.Size(60, 60);
            this.moleButton3.TabIndex = 2;
            this.moleButton3.Text = "🐹";
            this.moleButton3.UseVisualStyleBackColor = true;
            this.moleButton3.Visible = false;
            this.moleButton3.Click += new System.EventHandler(this.moleButton_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Easy",
            "Medium",
            "Hard"});
            this.comboBox1.Location = new System.Drawing.Point(467, 17);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(211, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Час: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.moleButton1);
            this.Controls.Add(this.moleButton2);
            this.Controls.Add(this.moleButton3);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.btnStart);
            this.Name = "Form1";
            this.Text = "Клікни крота!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
    }
}

