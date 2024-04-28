namespace WindowsServiceInstaller
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
            button1 = new Button();
            openFileDialog1 = new OpenFileDialog();
            label1 = new Label();
            button2 = new Button();
            textBox1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            btnDelete = new Button();
            btn_new = new Button();
            btnStopAndStart = new Button();
            label4 = new Label();
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            label5 = new Label();
            panel2 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(102, 9);
            button1.Name = "button1";
            button1.Size = new Size(142, 23);
            button1.TabIndex = 0;
            button1.Text = "Select .exe Project";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            label1.ForeColor = Color.Green;
            label1.Location = new Point(6, 47);
            label1.Name = "label1";
            label1.Size = new Size(241, 151);
            label1.TabIndex = 1;
            label1.Text = "Path";
            // 
            // button2
            // 
            button2.Location = new Point(11, 341);
            button2.Name = "button2";
            button2.Size = new Size(294, 29);
            button2.TabIndex = 2;
            button2.Text = "Create Service";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btn_Create_Serice_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(68, 30);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(156, 23);
            textBox1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 17);
            label2.Name = "label2";
            label2.Size = new Size(93, 15);
            label2.TabIndex = 5;
            label2.Text = "Path of service : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 247);
            label3.Name = "label3";
            label3.Size = new Size(79, 15);
            label3.TabIndex = 6;
            label3.Text = "Service Name";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(311, 313);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete Service";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btn_new
            // 
            btn_new.Location = new Point(311, 255);
            btn_new.Name = "btn_new";
            btn_new.Size = new Size(75, 23);
            btn_new.TabIndex = 8;
            btn_new.Text = "New";
            btn_new.UseVisualStyleBackColor = true;
            btn_new.Click += btn_new_Click;
            // 
            // btnStopAndStart
            // 
            btnStopAndStart.Location = new Point(311, 284);
            btnStopAndStart.Name = "btnStopAndStart";
            btnStopAndStart.Size = new Size(75, 23);
            btnStopAndStart.TabIndex = 9;
            btnStopAndStart.Text = "Stop";
            btnStopAndStart.UseVisualStyleBackColor = true;
            btnStopAndStart.Click += stopAndStart_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(4, 38);
            label4.Name = "label4";
            label4.Size = new Size(64, 15);
            label4.TabIndex = 10;
            label4.Text = ".BPJService";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(textBox1);
            panel1.Location = new Point(12, 256);
            panel1.Name = "panel1";
            panel1.Size = new Size(293, 79);
            panel1.TabIndex = 11;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Window;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 27);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(293, 212);
            dataGridView1.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 9);
            label5.Name = "label5";
            label5.Size = new Size(100, 15);
            label5.TabIndex = 13;
            label5.Text = "Available Services";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(button1);
            panel2.Location = new Point(311, 27);
            panel2.Name = "panel2";
            panel2.Size = new Size(254, 212);
            panel2.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(577, 379);
            Controls.Add(panel2);
            Controls.Add(label5);
            Controls.Add(dataGridView1);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(btnStopAndStart);
            Controls.Add(btn_new);
            Controls.Add(btnDelete);
            Controls.Add(button2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private OpenFileDialog openFileDialog1;
        private Label label1;
        private Button button2;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private Button btnDelete;
        private Button btn_new;
        private Button btnStopAndStart;
        private Label label4;
        private Panel panel1;
        private DataGridView dataGridView1;
        private Label label5;
        private Panel panel2;
    }
}
