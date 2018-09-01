namespace Flashcards
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.flashcardPane = new System.Windows.Forms.Panel();
            this.typeAnswerResponse = new System.Windows.Forms.Label();
            this.answerTextBox = new System.Windows.Forms.TextBox();
            this.mainMenu = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flashcardPane.SuspendLayout();
            this.mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(230, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(781, 512);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 574);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(381, 99);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(399, 574);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(381, 99);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(786, 574);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(380, 99);
            this.button3.TabIndex = 3;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // flashcardPane
            // 
            this.flashcardPane.Controls.Add(this.button6);
            this.flashcardPane.Controls.Add(this.button5);
            this.flashcardPane.Controls.Add(this.typeAnswerResponse);
            this.flashcardPane.Controls.Add(this.answerTextBox);
            this.flashcardPane.Controls.Add(this.pictureBox1);
            this.flashcardPane.Controls.Add(this.button1);
            this.flashcardPane.Controls.Add(this.button2);
            this.flashcardPane.Controls.Add(this.button3);
            this.flashcardPane.Location = new System.Drawing.Point(1196, 12);
            this.flashcardPane.Name = "flashcardPane";
            this.flashcardPane.Size = new System.Drawing.Size(1178, 684);
            this.flashcardPane.TabIndex = 4;
            // 
            // typeAnswerResponse
            // 
            this.typeAnswerResponse.AutoSize = true;
            this.typeAnswerResponse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeAnswerResponse.Location = new System.Drawing.Point(569, 551);
            this.typeAnswerResponse.Name = "typeAnswerResponse";
            this.typeAnswerResponse.Size = new System.Drawing.Size(79, 29);
            this.typeAnswerResponse.TabIndex = 5;
            this.typeAnswerResponse.Text = "label1";
            // 
            // answerTextBox
            // 
            this.answerTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerTextBox.Location = new System.Drawing.Point(399, 608);
            this.answerTextBox.Name = "answerTextBox";
            this.answerTextBox.Size = new System.Drawing.Size(381, 35);
            this.answerTextBox.TabIndex = 4;
            this.answerTextBox.TextChanged += new System.EventHandler(this.answerTextBox_TextChanged);
            this.answerTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.answerTextBox_HandleKeyDown);
            // 
            // mainMenu
            // 
            this.mainMenu.Controls.Add(this.button4);
            this.mainMenu.Location = new System.Drawing.Point(12, 12);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(1178, 684);
            this.mainMenu.TabIndex = 5;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(507, 273);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(206, 102);
            this.button4.TabIndex = 0;
            this.button4.Text = "Load Lesson";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(12, 22);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(163, 59);
            this.button5.TabIndex = 6;
            this.button5.Text = "Multi Choice";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(12, 87);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(163, 59);
            this.button6.TabIndex = 7;
            this.button6.Text = "Text Answer";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2387, 710);
            this.Controls.Add(this.mainMenu);
            this.Controls.Add(this.flashcardPane);
            this.Name = "Form1";
            this.Text = "Flashcards!";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flashcardPane.ResumeLayout(false);
            this.flashcardPane.PerformLayout();
            this.mainMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel flashcardPane;
        private System.Windows.Forms.Panel mainMenu;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox answerTextBox;
        private System.Windows.Forms.Label typeAnswerResponse;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
    }
}

