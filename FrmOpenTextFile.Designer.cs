namespace ReadingFile
{
    partial class FrmOpenTextFile
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
            lvShowText = new ListView();
            btnOpen = new Button();
            openFileDialog1 = new OpenFileDialog();
            btnStudentRecord = new Button();
            SuspendLayout();
            // 
            // lvShowText
            // 
            lvShowText.Location = new Point(12, 12);
            lvShowText.Name = "lvShowText";
            lvShowText.Size = new Size(742, 268);
            lvShowText.TabIndex = 0;
            lvShowText.UseCompatibleStateImageBehavior = false;
            // 
            // btnOpen
            // 
            btnOpen.BackColor = Color.Black;
            btnOpen.FlatStyle = FlatStyle.Flat;
            btnOpen.Font = new Font("Impact", 12F);
            btnOpen.ForeColor = SystemColors.ButtonFace;
            btnOpen.Location = new Point(224, 306);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(105, 34);
            btnOpen.TabIndex = 1;
            btnOpen.Text = "Open";
            btnOpen.UseVisualStyleBackColor = false;
            btnOpen.Click += btnOpen_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnStudentRecord
            // 
            btnStudentRecord.BackColor = Color.Black;
            btnStudentRecord.FlatStyle = FlatStyle.Flat;
            btnStudentRecord.Font = new Font("Impact", 12F);
            btnStudentRecord.ForeColor = SystemColors.ButtonFace;
            btnStudentRecord.Location = new Point(429, 306);
            btnStudentRecord.Name = "btnStudentRecord";
            btnStudentRecord.Size = new Size(116, 34);
            btnStudentRecord.TabIndex = 2;
            btnStudentRecord.Text = "Student Record";
            btnStudentRecord.UseVisualStyleBackColor = false;
            btnStudentRecord.Click += button1_Click;
            // 
            // FrmOpenTextFile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.IndianRed;
            ClientSize = new Size(766, 367);
            Controls.Add(btnStudentRecord);
            Controls.Add(btnOpen);
            Controls.Add(lvShowText);
            Name = "FrmOpenTextFile";
            Text = "FrmOpenTextFile";
            ResumeLayout(false);
        }

        #endregion

        private ListView lvShowText;
        private Button btnOpen;
        private OpenFileDialog openFileDialog1;
        private Button btnStudentRecord;
    }
}
