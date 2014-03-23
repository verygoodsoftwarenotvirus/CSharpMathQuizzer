namespace MathQuizzer
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
            this.answerButtonPanel = new System.Windows.Forms.TableLayoutPanel();
            this.answerButton4 = new System.Windows.Forms.Button();
            this.answerButton3 = new System.Windows.Forms.Button();
            this.answerButton2 = new System.Windows.Forms.Button();
            this.answerButton1 = new System.Windows.Forms.Button();
            this.questionPanel = new System.Windows.Forms.TableLayoutPanel();
            this.operand2 = new System.Windows.Forms.Label();
            this.op = new System.Windows.Forms.Label();
            this.operand1 = new System.Windows.Forms.Label();
            this.hiddenAnswer = new System.Windows.Forms.Label();
            this.answerButtonPanel.SuspendLayout();
            this.questionPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // answerButtonPanel
            // 
            this.answerButtonPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.answerButtonPanel.AutoSize = true;
            this.answerButtonPanel.ColumnCount = 2;
            this.answerButtonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.answerButtonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.answerButtonPanel.Controls.Add(this.answerButton4, 1, 1);
            this.answerButtonPanel.Controls.Add(this.answerButton3, 0, 1);
            this.answerButtonPanel.Controls.Add(this.answerButton2, 1, 0);
            this.answerButtonPanel.Controls.Add(this.answerButton1, 0, 0);
            this.answerButtonPanel.Location = new System.Drawing.Point(12, 120);
            this.answerButtonPanel.Name = "answerButtonPanel";
            this.answerButtonPanel.RowCount = 2;
            this.answerButtonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.answerButtonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.answerButtonPanel.Size = new System.Drawing.Size(255, 210);
            this.answerButtonPanel.TabIndex = 0;
            // 
            // answerButton4
            // 
            this.answerButton4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.answerButton4.AutoSize = true;
            this.answerButton4.Location = new System.Drawing.Point(130, 108);
            this.answerButton4.Name = "answerButton4";
            this.answerButton4.Size = new System.Drawing.Size(122, 99);
            this.answerButton4.TabIndex = 3;
            this.answerButton4.Text = "Answer";
            this.answerButton4.UseVisualStyleBackColor = true;
            this.answerButton4.Click += new System.EventHandler(this.answerButton4_Click);
            // 
            // answerButton3
            // 
            this.answerButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.answerButton3.AutoSize = true;
            this.answerButton3.Location = new System.Drawing.Point(3, 108);
            this.answerButton3.Name = "answerButton3";
            this.answerButton3.Size = new System.Drawing.Size(121, 99);
            this.answerButton3.TabIndex = 2;
            this.answerButton3.Text = "Answer";
            this.answerButton3.UseVisualStyleBackColor = true;
            this.answerButton3.Click += new System.EventHandler(this.answerButton3_Click);
            // 
            // answerButton2
            // 
            this.answerButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.answerButton2.AutoSize = true;
            this.answerButton2.Location = new System.Drawing.Point(130, 3);
            this.answerButton2.Name = "answerButton2";
            this.answerButton2.Size = new System.Drawing.Size(122, 99);
            this.answerButton2.TabIndex = 1;
            this.answerButton2.Text = "Answer";
            this.answerButton2.UseVisualStyleBackColor = true;
            this.answerButton2.Click += new System.EventHandler(this.answerButton2_Click);
            // 
            // answerButton1
            // 
            this.answerButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.answerButton1.AutoSize = true;
            this.answerButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.answerButton1.Location = new System.Drawing.Point(3, 3);
            this.answerButton1.Name = "answerButton1";
            this.answerButton1.Size = new System.Drawing.Size(121, 99);
            this.answerButton1.TabIndex = 0;
            this.answerButton1.Text = "Answer";
            this.answerButton1.UseVisualStyleBackColor = true;
            this.answerButton1.Click += new System.EventHandler(this.answerButton1_Click);
            // 
            // questionPanel
            // 
            this.questionPanel.ColumnCount = 3;
            this.questionPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.questionPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.questionPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.questionPanel.Controls.Add(this.operand2, 2, 0);
            this.questionPanel.Controls.Add(this.op, 1, 0);
            this.questionPanel.Controls.Add(this.operand1, 0, 0);
            this.questionPanel.Location = new System.Drawing.Point(15, 12);
            this.questionPanel.Name = "questionPanel";
            this.questionPanel.RowCount = 1;
            this.questionPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.questionPanel.Size = new System.Drawing.Size(249, 102);
            this.questionPanel.TabIndex = 1;
            // 
            // operand2
            // 
            this.operand2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.operand2.AutoSize = true;
            this.operand2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operand2.Location = new System.Drawing.Point(151, 0);
            this.operand2.Name = "operand2";
            this.operand2.Size = new System.Drawing.Size(95, 102);
            this.operand2.TabIndex = 2;
            this.operand2.Text = "3";
            this.operand2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // op
            // 
            this.op.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.op.AutoSize = true;
            this.op.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.op.Location = new System.Drawing.Point(102, 0);
            this.op.Name = "op";
            this.op.Size = new System.Drawing.Size(43, 102);
            this.op.TabIndex = 1;
            this.op.Text = "x";
            this.op.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // operand1
            // 
            this.operand1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.operand1.AutoSize = true;
            this.operand1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operand1.Location = new System.Drawing.Point(3, 0);
            this.operand1.Name = "operand1";
            this.operand1.Size = new System.Drawing.Size(93, 102);
            this.operand1.TabIndex = 0;
            this.operand1.Text = "3";
            this.operand1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hiddenAnswer
            // 
            this.hiddenAnswer.AutoSize = true;
            this.hiddenAnswer.Location = new System.Drawing.Point(271, 317);
            this.hiddenAnswer.Name = "hiddenAnswer";
            this.hiddenAnswer.Size = new System.Drawing.Size(0, 13);
            this.hiddenAnswer.TabIndex = 2;
            this.hiddenAnswer.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 342);
            this.Controls.Add(this.hiddenAnswer);
            this.Controls.Add(this.questionPanel);
            this.Controls.Add(this.answerButtonPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Math Quizzer";
            this.answerButtonPanel.ResumeLayout(false);
            this.answerButtonPanel.PerformLayout();
            this.questionPanel.ResumeLayout(false);
            this.questionPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel answerButtonPanel;
        private System.Windows.Forms.Button answerButton4;
        private System.Windows.Forms.Button answerButton3;
        private System.Windows.Forms.Button answerButton2;
        private System.Windows.Forms.Button answerButton1;
        private System.Windows.Forms.TableLayoutPanel questionPanel;
        private System.Windows.Forms.Label operand2;
        private System.Windows.Forms.Label op;
        private System.Windows.Forms.Label operand1;
        private System.Windows.Forms.Label hiddenAnswer;
    }
}

