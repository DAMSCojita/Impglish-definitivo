using System.Drawing;
using System.Windows.Forms;

namespace ProyectoAprenderIngles
{
    partial class FormVocabulary
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
            this.labelVocabularyQuizTitle = new System.Windows.Forms.Label();
            this.labelVocabularyIndexQuestion = new System.Windows.Forms.Label();
            this.answerA1 = new System.Windows.Forms.Label();
            this.answerA2 = new System.Windows.Forms.Label();
            this.answerA3 = new System.Windows.Forms.Label();
            this.textBoxInputAnswer = new System.Windows.Forms.TextBox();
            this.buttonCheck = new System.Windows.Forms.Button();
            this.textBoxCheckAnswer = new System.Windows.Forms.TextBox();
            this.labelCorrectAnswer = new System.Windows.Forms.Label();
            this.NextQuestionB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelVocabularyQuizTitle
            // 
            this.labelVocabularyQuizTitle.AutoSize = true;
            this.labelVocabularyQuizTitle.Font = new System.Drawing.Font("Segoe UI", 24F);
            this.labelVocabularyQuizTitle.Location = new System.Drawing.Point(307, 36);
            this.labelVocabularyQuizTitle.Name = "labelVocabularyQuizTitle";
            this.labelVocabularyQuizTitle.Size = new System.Drawing.Size(308, 54);
            this.labelVocabularyQuizTitle.TabIndex = 0;
            this.labelVocabularyQuizTitle.Text = "Vocabulary Quiz";
            // 
            // labelVocabularyIndexQuestion
            // 
            this.labelVocabularyIndexQuestion.AutoSize = true;
            this.labelVocabularyIndexQuestion.Location = new System.Drawing.Point(278, 139);
            this.labelVocabularyIndexQuestion.Name = "labelVocabularyIndexQuestion";
            this.labelVocabularyIndexQuestion.Size = new System.Drawing.Size(273, 16);
            this.labelVocabularyIndexQuestion.TabIndex = 1;
            this.labelVocabularyIndexQuestion.Text = "¿Cómo se escribe el verbo comer en inglés?";
            // 
            // answerA1
            // 
            this.answerA1.AutoSize = true;
            this.answerA1.Location = new System.Drawing.Point(286, 220);
            this.answerA1.Name = "answerA1";
            this.answerA1.Size = new System.Drawing.Size(27, 16);
            this.answerA1.TabIndex = 3;
            this.answerA1.Text = "Eat";
            // 
            // answerA2
            // 
            this.answerA2.AutoSize = true;
            this.answerA2.Location = new System.Drawing.Point(391, 220);
            this.answerA2.Name = "answerA2";
            this.answerA2.Size = new System.Drawing.Size(27, 16);
            this.answerA2.TabIndex = 4;
            this.answerA2.Text = "Ate";
            // 
            // answerA3
            // 
            this.answerA3.AutoSize = true;
            this.answerA3.Location = new System.Drawing.Point(499, 220);
            this.answerA3.Name = "answerA3";
            this.answerA3.Size = new System.Drawing.Size(30, 16);
            this.answerA3.TabIndex = 5;
            this.answerA3.Text = "Ouit";
            // 
            // textBoxInputAnswer
            // 
            this.textBoxInputAnswer.Location = new System.Drawing.Point(270, 172);
            this.textBoxInputAnswer.Name = "textBoxInputAnswer";
            this.textBoxInputAnswer.Size = new System.Drawing.Size(282, 22);
            this.textBoxInputAnswer.TabIndex = 6;
            // 
            // buttonCheck
            // 
            this.buttonCheck.Location = new System.Drawing.Point(583, 172);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(152, 25);
            this.buttonCheck.TabIndex = 7;
            this.buttonCheck.Text = "Comprobar respuesta";
            this.buttonCheck.UseVisualStyleBackColor = true;
            this.buttonCheck.Click += new System.EventHandler(this.checkVocabulary_Click);
            // 
            // textBoxCheckAnswer
            // 
            this.textBoxCheckAnswer.Location = new System.Drawing.Point(270, 289);
            this.textBoxCheckAnswer.Name = "textBoxCheckAnswer";
            this.textBoxCheckAnswer.Size = new System.Drawing.Size(282, 22);
            this.textBoxCheckAnswer.TabIndex = 8;
            // 
            // labelCorrectAnswer
            // 
            this.labelCorrectAnswer.AutoSize = true;
            this.labelCorrectAnswer.Location = new System.Drawing.Point(361, 259);
            this.labelCorrectAnswer.Name = "labelCorrectAnswer";
            this.labelCorrectAnswer.Size = new System.Drawing.Size(128, 16);
            this.labelCorrectAnswer.TabIndex = 9;
            this.labelCorrectAnswer.Text = "Respuesta correcta:";
            // 
            // NextQuestionB
            // 
            this.NextQuestionB.Location = new System.Drawing.Point(346, 352);
            this.NextQuestionB.Name = "NextQuestionB";
            this.NextQuestionB.Size = new System.Drawing.Size(143, 25);
            this.NextQuestionB.TabIndex = 10;
            this.NextQuestionB.Text = "Siguiente pregunta";
            this.NextQuestionB.UseVisualStyleBackColor = true;
            this.NextQuestionB.Click += new System.EventHandler(this.NextQuestionB_Click);
            // 
            // FormVocabulary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 480);
            this.Controls.Add(this.labelVocabularyQuizTitle);
            this.Controls.Add(this.labelVocabularyIndexQuestion);
            this.Controls.Add(this.textBoxInputAnswer);
            this.Controls.Add(this.answerA3);
            this.Controls.Add(this.answerA2);
            this.Controls.Add(this.answerA1);
            this.Controls.Add(this.buttonCheck);
            this.Controls.Add(this.labelCorrectAnswer);
            this.Controls.Add(this.textBoxCheckAnswer);
            this.Controls.Add(this.NextQuestionB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormVocabulary";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelVocabularyQuizTitle;
        private Label labelVocabularyIndexQuestion;
        private Label answerA1;
        private Label answerA2;
        private Label answerA3;
        private TextBox textBoxInputAnswer;
        private Button buttonCheck;
        private TextBox textBoxCheckAnswer;
        private Label labelCorrectAnswer;
        private Button NextQuestionB;
    }
}