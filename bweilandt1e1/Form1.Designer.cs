
namespace bweilandt1e1
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
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTest1Score = new System.Windows.Forms.TextBox();
            this.txtTest2Score = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtTest3Score = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtAverageScore = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(181, 47);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(81, 20);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Test 1:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtTest1Score
            // 
            this.txtTest1Score.Location = new System.Drawing.Point(91, 47);
            this.txtTest1Score.Name = "txtTest1Score";
            this.txtTest1Score.Size = new System.Drawing.Size(50, 20);
            this.txtTest1Score.TabIndex = 2;
            this.txtTest1Score.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTest1Score.TextChanged += new System.EventHandler(this.txtTestScore_TextChanged);
            // 
            // txtTest2Score
            // 
            this.txtTest2Score.Location = new System.Drawing.Point(91, 73);
            this.txtTest2Score.Name = "txtTest2Score";
            this.txtTest2Score.Size = new System.Drawing.Size(50, 20);
            this.txtTest2Score.TabIndex = 5;
            this.txtTest2Score.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTest2Score.TextChanged += new System.EventHandler(this.txtTestScore_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Test 2:";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(181, 73);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(81, 20);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtTest3Score
            // 
            this.txtTest3Score.Location = new System.Drawing.Point(91, 99);
            this.txtTest3Score.Name = "txtTest3Score";
            this.txtTest3Score.Size = new System.Drawing.Size(50, 20);
            this.txtTest3Score.TabIndex = 8;
            this.txtTest3Score.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTest3Score.TextChanged += new System.EventHandler(this.txtTestScore_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Test 3:";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(181, 99);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(81, 20);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtAverageScore
            // 
            this.txtAverageScore.Location = new System.Drawing.Point(91, 159);
            this.txtAverageScore.Name = "txtAverageScore";
            this.txtAverageScore.ReadOnly = true;
            this.txtAverageScore.Size = new System.Drawing.Size(50, 20);
            this.txtAverageScore.TabIndex = 11;
            this.txtAverageScore.TabStop = false;
            this.txtAverageScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAverageScore.TextChanged += new System.EventHandler(this.txtaveragescores);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Average:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 227);
            this.Controls.Add(this.txtAverageScore);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTest3Score);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtTest2Score);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtTest1Score);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalculate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TextChanged += new System.EventHandler(this.txtTestScoreTextChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTest1Score;
        private System.Windows.Forms.TextBox txtTest2Score;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtTest3Score;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtAverageScore;
        private System.Windows.Forms.Label label4;
    }
}

