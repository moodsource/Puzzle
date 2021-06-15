
namespace Puzzle
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxImagePath = new System.Windows.Forms.TextBox();
            this.buttonImageBrowse = new System.Windows.Forms.Button();
            this.groupBoxPuzzle = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonLevel4 = new System.Windows.Forms.Button();
            this.buttonLevel3 = new System.Windows.Forms.Button();
            this.buttonLevel2 = new System.Windows.Forms.Button();
            this.buttonLevel1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.textBoxImagePath);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Location = new System.Drawing.Point(12, 55);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(833, 73);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Choose Image";
            // 
            // textBoxImagePath
            // 
            this.textBoxImagePath.BackColor = System.Drawing.Color.White;
            this.textBoxImagePath.Location = new System.Drawing.Point(6, 28);
            this.textBoxImagePath.Name = "textBoxImagePath";
            this.textBoxImagePath.Size = new System.Drawing.Size(820, 34);
            this.textBoxImagePath.TabIndex = 0;
            // 
            // buttonImageBrowse
            // 
            this.buttonImageBrowse.BackColor = System.Drawing.Color.Transparent;
            this.buttonImageBrowse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonImageBrowse.FlatAppearance.BorderSize = 2;
            this.buttonImageBrowse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.buttonImageBrowse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.buttonImageBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonImageBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonImageBrowse.ForeColor = System.Drawing.Color.White;
            this.buttonImageBrowse.Location = new System.Drawing.Point(862, 68);
            this.buttonImageBrowse.Name = "buttonImageBrowse";
            this.buttonImageBrowse.Size = new System.Drawing.Size(164, 60);
            this.buttonImageBrowse.TabIndex = 1;
            this.buttonImageBrowse.Text = "...";
            this.buttonImageBrowse.UseVisualStyleBackColor = false;
            this.buttonImageBrowse.Click += new System.EventHandler(this.buttonImageBrowse_Click);
            // 
            // groupBoxPuzzle
            // 
            this.groupBoxPuzzle.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxPuzzle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxPuzzle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxPuzzle.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBoxPuzzle.Location = new System.Drawing.Point(440, 134);
            this.groupBoxPuzzle.Name = "groupBoxPuzzle";
            this.groupBoxPuzzle.Size = new System.Drawing.Size(540, 540);
            this.groupBoxPuzzle.TabIndex = 2;
            this.groupBoxPuzzle.TabStop = false;
            this.groupBoxPuzzle.Text = "Puzzle";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.buttonLevel4);
            this.groupBox1.Controls.Add(this.buttonLevel3);
            this.groupBox1.Controls.Add(this.buttonLevel2);
            this.groupBox1.Controls.Add(this.buttonLevel1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(12, 134);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(402, 263);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Play Mode";
            // 
            // buttonLevel4
            // 
            this.buttonLevel4.BackColor = System.Drawing.Color.Transparent;
            this.buttonLevel4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLevel4.FlatAppearance.BorderSize = 2;
            this.buttonLevel4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.buttonLevel4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.buttonLevel4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLevel4.ForeColor = System.Drawing.Color.White;
            this.buttonLevel4.Location = new System.Drawing.Point(118, 195);
            this.buttonLevel4.Name = "buttonLevel4";
            this.buttonLevel4.Size = new System.Drawing.Size(173, 48);
            this.buttonLevel4.TabIndex = 3;
            this.buttonLevel4.Text = "Level 4";
            this.buttonLevel4.UseVisualStyleBackColor = false;
            this.buttonLevel4.Click += new System.EventHandler(this.buttonLevel4_Click);
            // 
            // buttonLevel3
            // 
            this.buttonLevel3.BackColor = System.Drawing.Color.Transparent;
            this.buttonLevel3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLevel3.FlatAppearance.BorderSize = 2;
            this.buttonLevel3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.buttonLevel3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.buttonLevel3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLevel3.ForeColor = System.Drawing.Color.White;
            this.buttonLevel3.Location = new System.Drawing.Point(118, 141);
            this.buttonLevel3.Name = "buttonLevel3";
            this.buttonLevel3.Size = new System.Drawing.Size(173, 48);
            this.buttonLevel3.TabIndex = 2;
            this.buttonLevel3.Text = "Level 3";
            this.buttonLevel3.UseVisualStyleBackColor = false;
            this.buttonLevel3.Click += new System.EventHandler(this.buttonLevel3_Click);
            // 
            // buttonLevel2
            // 
            this.buttonLevel2.BackColor = System.Drawing.Color.Transparent;
            this.buttonLevel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLevel2.FlatAppearance.BorderSize = 2;
            this.buttonLevel2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.buttonLevel2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.buttonLevel2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLevel2.ForeColor = System.Drawing.Color.White;
            this.buttonLevel2.Location = new System.Drawing.Point(118, 87);
            this.buttonLevel2.Name = "buttonLevel2";
            this.buttonLevel2.Size = new System.Drawing.Size(173, 48);
            this.buttonLevel2.TabIndex = 1;
            this.buttonLevel2.Text = "Level 2";
            this.buttonLevel2.UseVisualStyleBackColor = false;
            this.buttonLevel2.Click += new System.EventHandler(this.buttonLevel2_Click);
            // 
            // buttonLevel1
            // 
            this.buttonLevel1.BackColor = System.Drawing.Color.Transparent;
            this.buttonLevel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLevel1.FlatAppearance.BorderSize = 2;
            this.buttonLevel1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.buttonLevel1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.buttonLevel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLevel1.ForeColor = System.Drawing.Color.White;
            this.buttonLevel1.Location = new System.Drawing.Point(118, 33);
            this.buttonLevel1.Name = "buttonLevel1";
            this.buttonLevel1.Size = new System.Drawing.Size(173, 48);
            this.buttonLevel1.TabIndex = 0;
            this.buttonLevel1.Text = "Level 1";
            this.buttonLevel1.UseVisualStyleBackColor = false;
            this.buttonLevel1.Click += new System.EventHandler(this.buttonLevel1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.labelStatus);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Location = new System.Drawing.Point(12, 403);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(402, 271);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Status";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(21, 37);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(47, 28);
            this.labelStatus.TabIndex = 0;
            this.labelStatus.Text = "Idle";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(79)))), ((int)(((byte)(138)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(79)))), ((int)(((byte)(138)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(982, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(49, 37);
            this.button1.TabIndex = 5;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(17, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 28);
            this.label1.TabIndex = 6;
            this.label1.Text = "OnePiece Puzzle";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-5, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1046, 50);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 2;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI Black", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(913, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(49, 37);
            this.button2.TabIndex = 7;
            this.button2.Text = "_";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BackgroundImage = global::Puzzle.Properties.Resources._1612252456_152_p_s_novim_godom_fioletovii_fon_233;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1038, 686);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxPuzzle);
            this.Controls.Add(this.buttonImageBrowse);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Puzzle";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonImageBrowse;
        private System.Windows.Forms.GroupBox groupBoxPuzzle;
        private System.Windows.Forms.TextBox textBoxImagePath;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonLevel4;
        private System.Windows.Forms.Button buttonLevel3;
        private System.Windows.Forms.Button buttonLevel2;
        private System.Windows.Forms.Button buttonLevel1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
    }
}

