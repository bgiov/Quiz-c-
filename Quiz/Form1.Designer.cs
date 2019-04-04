namespace Quiz
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.firstTbx = new System.Windows.Forms.TextBox();
            this.answerTbx = new System.Windows.Forms.TextBox();
            this.secondTbx = new System.Windows.Forms.TextBox();
            this.opTbx = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sendBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.aTbx = new System.Windows.Forms.TextBox();
            this.submitBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.qTbx = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.questionLbx = new System.Windows.Forms.ListBox();
            this.sortMinus = new System.Windows.Forms.Button();
            this.sortPlus = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.wrongLbx = new System.Windows.Forms.ListBox();
            this.exitBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Question, then click Send.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Second Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Operator:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "First Number:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Answer:";
            // 
            // firstTbx
            // 
            this.firstTbx.Location = new System.Drawing.Point(129, 67);
            this.firstTbx.Name = "firstTbx";
            this.firstTbx.Size = new System.Drawing.Size(116, 22);
            this.firstTbx.TabIndex = 6;
            // 
            // answerTbx
            // 
            this.answerTbx.Location = new System.Drawing.Point(129, 175);
            this.answerTbx.Name = "answerTbx";
            this.answerTbx.Size = new System.Drawing.Size(116, 22);
            this.answerTbx.TabIndex = 8;
            // 
            // secondTbx
            // 
            this.secondTbx.Location = new System.Drawing.Point(129, 140);
            this.secondTbx.Name = "secondTbx";
            this.secondTbx.Size = new System.Drawing.Size(116, 22);
            this.secondTbx.TabIndex = 9;
            this.secondTbx.Leave += new System.EventHandler(this.secondTbx_Leave);
            // 
            // opTbx
            // 
            this.opTbx.FormattingEnabled = true;
            this.opTbx.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.opTbx.Location = new System.Drawing.Point(129, 104);
            this.opTbx.Name = "opTbx";
            this.opTbx.Size = new System.Drawing.Size(121, 24);
            this.opTbx.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sendBtn);
            this.groupBox1.Controls.Add(this.clearBtn);
            this.groupBox1.Controls.Add(this.answerTbx);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.opTbx);
            this.groupBox1.Controls.Add(this.secondTbx);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.firstTbx);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(398, 252);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Intructor";
            // 
            // sendBtn
            // 
            this.sendBtn.Location = new System.Drawing.Point(6, 217);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(300, 29);
            this.sendBtn.TabIndex = 13;
            this.sendBtn.Text = "Send";
            this.sendBtn.UseVisualStyleBackColor = true;
            this.sendBtn.Click += new System.EventHandler(this.sendBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(333, 217);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(59, 29);
            this.clearBtn.TabIndex = 14;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.aTbx);
            this.groupBox2.Controls.Add(this.submitBtn);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.qTbx);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(965, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(399, 252);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Student";
            // 
            // aTbx
            // 
            this.aTbx.Location = new System.Drawing.Point(129, 104);
            this.aTbx.Name = "aTbx";
            this.aTbx.Size = new System.Drawing.Size(116, 22);
            this.aTbx.TabIndex = 15;
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(6, 217);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(387, 29);
            this.submitBtn.TabIndex = 13;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(229, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Enter your answer and click Submit";
            // 
            // qTbx
            // 
            this.qTbx.Location = new System.Drawing.Point(129, 67);
            this.qTbx.Name = "qTbx";
            this.qTbx.Size = new System.Drawing.Size(116, 22);
            this.qTbx.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 67);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 17);
            this.label9.TabIndex = 3;
            this.label9.Text = "Question:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 104);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 17);
            this.label10.TabIndex = 2;
            this.label10.Text = "Your Answer";
            // 
            // questionLbx
            // 
            this.questionLbx.FormattingEnabled = true;
            this.questionLbx.ItemHeight = 16;
            this.questionLbx.Location = new System.Drawing.Point(416, 15);
            this.questionLbx.Name = "questionLbx";
            this.questionLbx.Size = new System.Drawing.Size(543, 244);
            this.questionLbx.TabIndex = 18;
            // 
            // sortMinus
            // 
            this.sortMinus.Location = new System.Drawing.Point(582, 265);
            this.sortMinus.Name = "sortMinus";
            this.sortMinus.Size = new System.Drawing.Size(75, 23);
            this.sortMinus.TabIndex = 19;
            this.sortMinus.Text = "Sort-";
            this.sortMinus.UseVisualStyleBackColor = true;
            this.sortMinus.Click += new System.EventHandler(this.sortMinus_Click);
            // 
            // sortPlus
            // 
            this.sortPlus.Location = new System.Drawing.Point(663, 265);
            this.sortPlus.Name = "sortPlus";
            this.sortPlus.Size = new System.Drawing.Size(75, 23);
            this.sortPlus.TabIndex = 20;
            this.sortPlus.Text = "Sort+";
            this.sortPlus.UseVisualStyleBackColor = true;
            this.sortPlus.Click += new System.EventHandler(this.sortPlus_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(744, 265);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 21;
            this.button3.Text = "Sort/";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // wrongLbx
            // 
            this.wrongLbx.FormattingEnabled = true;
            this.wrongLbx.ItemHeight = 16;
            this.wrongLbx.Location = new System.Drawing.Point(12, 286);
            this.wrongLbx.Name = "wrongLbx";
            this.wrongLbx.Size = new System.Drawing.Size(543, 244);
            this.wrongLbx.TabIndex = 22;
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(1268, 509);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(96, 32);
            this.exitBtn.TabIndex = 23;
            this.exitBtn.Text = "exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 542);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.wrongLbx);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.sortPlus);
            this.Controls.Add(this.sortMinus);
            this.Controls.Add(this.questionLbx);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox firstTbx;
        private System.Windows.Forms.TextBox answerTbx;
        private System.Windows.Forms.TextBox secondTbx;
        private System.Windows.Forms.ComboBox opTbx;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button sendBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox qTbx;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox aTbx;
        private System.Windows.Forms.ListBox questionLbx;
        private System.Windows.Forms.Button sortMinus;
        private System.Windows.Forms.Button sortPlus;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox wrongLbx;
        private System.Windows.Forms.Button exitBtn;
    }
}

