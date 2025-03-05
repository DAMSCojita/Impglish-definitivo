using System.Drawing;
using System.Windows.Forms;

namespace ProyectoAprenderIngles
{
    partial class FormListening
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
            this.labelListeningQuizTitle = new System.Windows.Forms.Label();
            this.labelListeningIndexQuestion = new System.Windows.Forms.Label();
            this.textBoxAnswer = new System.Windows.Forms.TextBox();
            this.buttonCheck = new System.Windows.Forms.Button();
            this.textBoxCheckAnswer = new System.Windows.Forms.TextBox();
            this.labelCheck = new System.Windows.Forms.Label();
            this.NextQuestionB = new System.Windows.Forms.Button();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelListeningQuizTitle
            // 
            this.labelListeningQuizTitle.AutoSize = true;
            this.labelListeningQuizTitle.Font = new System.Drawing.Font("Segoe UI", 24F);
            this.labelListeningQuizTitle.Location = new System.Drawing.Point(286, 32);
            this.labelListeningQuizTitle.Name = "labelListeningQuizTitle";
            this.labelListeningQuizTitle.Size = new System.Drawing.Size(276, 54);
            this.labelListeningQuizTitle.TabIndex = 0;
            this.labelListeningQuizTitle.Text = "Listening Quiz";
            // 
            // labelListeningIndexQuestion
            // 
            this.labelListeningIndexQuestion.AutoSize = true;
            this.labelListeningIndexQuestion.Location = new System.Drawing.Point(286, 107);
            this.labelListeningIndexQuestion.Name = "labelListeningIndexQuestion";
            this.labelListeningIndexQuestion.Size = new System.Drawing.Size(52, 16);
            this.labelListeningIndexQuestion.TabIndex = 1;
            this.labelListeningIndexQuestion.Text = "Frase 1";
            // 
            // textBoxAnswer
            // 
            this.textBoxAnswer.Location = new System.Drawing.Point(286, 139);
            this.textBoxAnswer.Name = "textBoxAnswer";
            this.textBoxAnswer.Size = new System.Drawing.Size(285, 22);
            this.textBoxAnswer.TabIndex = 3;
            // 
            // buttonCheck
            // 
            this.buttonCheck.Location = new System.Drawing.Point(286, 181);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(171, 25);
            this.buttonCheck.TabIndex = 4;
            this.buttonCheck.Text = "Comprobar respuesta";
            this.buttonCheck.Click += new System.EventHandler(this.checkListening_Click);
            // 
            // textBoxCheckAnswer
            // 
            this.textBoxCheckAnswer.Location = new System.Drawing.Point(286, 256);
            this.textBoxCheckAnswer.Name = "textBoxCheckAnswer";
            this.textBoxCheckAnswer.Size = new System.Drawing.Size(285, 22);
            this.textBoxCheckAnswer.TabIndex = 6;
            // 
            // labelCheck
            // 
            this.labelCheck.AutoSize = true;
            this.labelCheck.Location = new System.Drawing.Point(286, 224);
            this.labelCheck.Name = "labelCheck";
            this.labelCheck.Size = new System.Drawing.Size(160, 16);
            this.labelCheck.TabIndex = 5;
            this.labelCheck.Text = "Comprobando respuesta:";
            // 
            // NextQuestionB
            // 
            this.NextQuestionB.Location = new System.Drawing.Point(583, 256);
            this.NextQuestionB.Name = "NextQuestionB";
            this.NextQuestionB.Size = new System.Drawing.Size(149, 25);
            this.NextQuestionB.TabIndex = 7;
            this.NextQuestionB.Text = "Siguiente pregunta";
            this.NextQuestionB.Click += new System.EventHandler(this.NextQuestionB_Click);
            // 
            // buttonPlay
            // 
            this.buttonPlay.Location = new System.Drawing.Point(137, 139);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(114, 25);
            this.buttonPlay.TabIndex = 2;
            this.buttonPlay.Text = "Reproducir";
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // FormListening
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 480);
            this.Controls.Add(this.labelListeningQuizTitle);
            this.Controls.Add(this.labelListeningIndexQuestion);
            this.Controls.Add(this.buttonPlay);
            this.Controls.Add(this.textBoxAnswer);
            this.Controls.Add(this.buttonCheck);
            this.Controls.Add(this.labelCheck);
            this.Controls.Add(this.textBoxCheckAnswer);
            this.Controls.Add(this.NextQuestionB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormListening";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelListeningQuizTitle;
        private Label labelListeningIndexQuestion;
        private TextBox textBoxAnswer;
        private Button buttonCheck;
        private TextBox textBoxCheckAnswer;
        private Label labelCheck;
        private Button NextQuestionB;
        private Button buttonPlay;
    }
}