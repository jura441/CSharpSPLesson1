﻿namespace ProcessesApp
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
            this.components = new System.ComponentModel.Container();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.L_id = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Thread_count = new System.Windows.Forms.Label();
            this.Proc_Copy = new System.Windows.Forms.Label();
            this.label_startTime = new System.Windows.Forms.Label();
            this.Proc_Time = new System.Windows.Forms.Label();
            this.start_time = new System.Windows.Forms.Label();
            this.btn_close_process = new System.Windows.Forms.Button();
            this.newProcessStart = new System.Windows.Forms.Button();
            this.newProcessName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(4, 80);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(278, 342);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(147, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "5";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(165, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(320, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Иформация о процессе";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(320, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Process ID:";
            // 
            // L_id
            // 
            this.L_id.AutoSize = true;
            this.L_id.Location = new System.Drawing.Point(460, 80);
            this.L_id.Name = "L_id";
            this.L_id.Size = new System.Drawing.Size(0, 13);
            this.L_id.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(329, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Start time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(300, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Processor Time";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(311, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "ThreadCount";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(311, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Process copy";
            // 
            // Thread_count
            // 
            this.Thread_count.AutoSize = true;
            this.Thread_count.Location = new System.Drawing.Point(440, 184);
            this.Thread_count.Name = "Thread_count";
            this.Thread_count.Size = new System.Drawing.Size(0, 13);
            this.Thread_count.TabIndex = 10;
            // 
            // Proc_Copy
            // 
            this.Proc_Copy.AutoSize = true;
            this.Proc_Copy.Location = new System.Drawing.Point(440, 230);
            this.Proc_Copy.Name = "Proc_Copy";
            this.Proc_Copy.Size = new System.Drawing.Size(0, 13);
            this.Proc_Copy.TabIndex = 11;
            // 
            // label_startTime
            // 
            this.label_startTime.AutoSize = true;
            this.label_startTime.Location = new System.Drawing.Point(440, 122);
            this.label_startTime.Name = "label_startTime";
            this.label_startTime.Size = new System.Drawing.Size(0, 13);
            this.label_startTime.TabIndex = 12;
            // 
            // Proc_Time
            // 
            this.Proc_Time.AutoSize = true;
            this.Proc_Time.Location = new System.Drawing.Point(440, 150);
            this.Proc_Time.Name = "Proc_Time";
            this.Proc_Time.Size = new System.Drawing.Size(0, 13);
            this.Proc_Time.TabIndex = 13;
            // 
            // start_time
            // 
            this.start_time.AutoSize = true;
            this.start_time.Location = new System.Drawing.Point(440, 122);
            this.start_time.Name = "start_time";
            this.start_time.Size = new System.Drawing.Size(0, 13);
            this.start_time.TabIndex = 14;
            // 
            // btn_close_process
            // 
            this.btn_close_process.Location = new System.Drawing.Point(409, 273);
            this.btn_close_process.Name = "btn_close_process";
            this.btn_close_process.Size = new System.Drawing.Size(75, 23);
            this.btn_close_process.TabIndex = 15;
            this.btn_close_process.Text = "close";
            this.btn_close_process.UseVisualStyleBackColor = true;
            this.btn_close_process.Click += new System.EventHandler(this.btn_close_process_Click);
            // 
            // newProcessStart
            // 
            this.newProcessStart.Location = new System.Drawing.Point(396, 363);
            this.newProcessStart.Name = "newProcessStart";
            this.newProcessStart.Size = new System.Drawing.Size(161, 23);
            this.newProcessStart.TabIndex = 16;
            this.newProcessStart.Text = "Запустить новые процесс";
            this.newProcessStart.UseVisualStyleBackColor = true;
            this.newProcessStart.Click += new System.EventHandler(this.newProcessStart_Click);
            // 
            // newProcessName
            // 
            this.newProcessName.Location = new System.Drawing.Point(332, 318);
            this.newProcessName.Name = "newProcessName";
            this.newProcessName.Size = new System.Drawing.Size(215, 20);
            this.newProcessName.TabIndex = 17;
            this.newProcessName.TextChanged += new System.EventHandler(this.newProcessName_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 445);
            this.Controls.Add(this.newProcessName);
            this.Controls.Add(this.newProcessStart);
            this.Controls.Add(this.btn_close_process);
            this.Controls.Add(this.start_time);
            this.Controls.Add(this.Proc_Time);
            this.Controls.Add(this.label_startTime);
            this.Controls.Add(this.Proc_Copy);
            this.Controls.Add(this.Thread_count);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.L_id);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label L_id;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Thread_count;
        private System.Windows.Forms.Label Proc_Copy;
        private System.Windows.Forms.Label label_startTime;
        private System.Windows.Forms.Label Proc_Time;
        private System.Windows.Forms.Label start_time;
        private System.Windows.Forms.Button btn_close_process;
        private System.Windows.Forms.Button newProcessStart;
        private System.Windows.Forms.TextBox newProcessName;
    }
}

