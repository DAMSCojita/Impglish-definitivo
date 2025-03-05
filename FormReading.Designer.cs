using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoAprenderIngles
{
    partial class FormReading
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
            this.labelReadingQuizTitle = new System.Windows.Forms.Label();
            this.labelReadingIndexQuestion = new System.Windows.Forms.Label();
            this.labelReadingIndexComboQuestion1 = new System.Windows.Forms.Label();
            this.labelReadingIndexComboQuestion2 = new System.Windows.Forms.Label();
            this.textBoxStoryIndex = new System.Windows.Forms.TextBox();
            this.comboBoxIndexAnswers1 = new System.Windows.Forms.ComboBox();
            this.comboBoxIndexAnswers2 = new System.Windows.Forms.ComboBox();
            this.checkButtonReading = new System.Windows.Forms.Button();
            this.NextQuestionB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelReadingQuizTitle
            // 
            this.labelReadingQuizTitle.AutoSize = true;
            this.labelReadingQuizTitle.Font = new System.Drawing.Font("Segoe UI", 24F);
            this.labelReadingQuizTitle.Location = new System.Drawing.Point(307, 36);
            this.labelReadingQuizTitle.Name = "labelReadingQuizTitle";
            this.labelReadingQuizTitle.Size = new System.Drawing.Size(260, 54);
            this.labelReadingQuizTitle.TabIndex = 0;
            this.labelReadingQuizTitle.Text = "Reading Quiz";
            // 
            // labelReadingIndexQuestion
            // 
            this.labelReadingIndexQuestion.AutoSize = true;
            this.labelReadingIndexQuestion.Location = new System.Drawing.Point(278, 139);
            this.labelReadingIndexQuestion.Name = "labelReadingIndexQuestion";
            this.labelReadingIndexQuestion.Size = new System.Drawing.Size(413, 16);
            this.labelReadingIndexQuestion.TabIndex = 1;
            this.labelReadingIndexQuestion.Text = "Lee la siguiente frase y responde en inglés las preguntas siguientes:";
            // 
            // labelReadingIndexComboQuestion1
            // 
            this.labelReadingIndexComboQuestion1.AutoSize = true;
            this.labelReadingIndexComboQuestion1.Location = new System.Drawing.Point(292, 406);
            this.labelReadingIndexComboQuestion1.Name = "labelReadingIndexComboQuestion1";
            this.labelReadingIndexComboQuestion1.Size = new System.Drawing.Size(158, 16);
            this.labelReadingIndexComboQuestion1.TabIndex = 2;
            this.labelReadingIndexComboQuestion1.Text = "First ComboBox Question";
            // 
            // labelReadingIndexComboQuestion2
            // 
            this.labelReadingIndexComboQuestion2.AutoSize = true;
            this.labelReadingIndexComboQuestion2.Location = new System.Drawing.Point(276, 500);
            this.labelReadingIndexComboQuestion2.Name = "labelReadingIndexComboQuestion2";
            this.labelReadingIndexComboQuestion2.Size = new System.Drawing.Size(180, 16);
            this.labelReadingIndexComboQuestion2.TabIndex = 2;
            this.labelReadingIndexComboQuestion2.Text = "Second ComboBox Question";
            // 
            // textBoxStoryIndex
            // 
            this.textBoxStoryIndex.BackColor = System.Drawing.Color.White;
            this.textBoxStoryIndex.Location = new System.Drawing.Point(295, 173);
            this.textBoxStoryIndex.Multiline = true;
            this.textBoxStoryIndex.Name = "textBoxStoryIndex";
            this.textBoxStoryIndex.ReadOnly = true;
            this.textBoxStoryIndex.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxStoryIndex.Size = new System.Drawing.Size(282, 219);
            this.textBoxStoryIndex.TabIndex = 6;
            this.textBoxStoryIndex.TabStop = false;
            // 
            // comboBoxIndexAnswers1
            // 
            this.comboBoxIndexAnswers1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxIndexAnswers1.Location = new System.Drawing.Point(279, 425);
            this.comboBoxIndexAnswers1.Name = "comboBoxIndexAnswers1";
            this.comboBoxIndexAnswers1.Size = new System.Drawing.Size(171, 24);
            this.comboBoxIndexAnswers1.TabIndex = 2;
            // 
            // comboBoxIndexAnswers2
            // 
            this.comboBoxIndexAnswers2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxIndexAnswers2.Location = new System.Drawing.Point(279, 519);
            this.comboBoxIndexAnswers2.Name = "comboBoxIndexAnswers2";
            this.comboBoxIndexAnswers2.Size = new System.Drawing.Size(171, 24);
            this.comboBoxIndexAnswers2.TabIndex = 3;
            // 
            // checkButtonReading
            // 
            this.checkButtonReading.Location = new System.Drawing.Point(506, 172);
            this.checkButtonReading.Name = "checkButtonReading";
            this.checkButtonReading.Size = new System.Drawing.Size(154, 25);
            this.checkButtonReading.TabIndex = 7;
            this.checkButtonReading.Text = "Comprobar respuesta";
            this.checkButtonReading.UseVisualStyleBackColor = true;
            this.checkButtonReading.Click += new System.EventHandler(this.checkReading_Click);
            // 
            // NextQuestionB
            // 
            this.NextQuestionB.Location = new System.Drawing.Point(517, 367);
            this.NextQuestionB.Name = "NextQuestionB";
            this.NextQuestionB.Size = new System.Drawing.Size(143, 25);
            this.NextQuestionB.TabIndex = 10;
            this.NextQuestionB.Text = "Siguiente pregunta";
            this.NextQuestionB.UseVisualStyleBackColor = true;
            this.NextQuestionB.Click += new System.EventHandler(this.NextQuestionB_Click);
            // 
            // FormReading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.labelReadingQuizTitle);
            this.Controls.Add(this.labelReadingIndexQuestion);
            this.Controls.Add(this.textBoxStoryIndex);
            this.Controls.Add(this.labelReadingIndexComboQuestion1);
            this.Controls.Add(this.comboBoxIndexAnswers1);
            this.Controls.Add(this.labelReadingIndexComboQuestion2);
            this.Controls.Add(this.comboBoxIndexAnswers2);
            this.Controls.Add(this.checkButtonReading);
            this.Controls.Add(this.NextQuestionB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormReading";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelReadingQuizTitle;
        private Label labelReadingIndexQuestion;
        private Label labelReadingIndexComboQuestion1;
        private Label labelReadingIndexComboQuestion2;
        private TextBox textBoxStoryIndex;
        private Button checkButtonReading;
        private Button NextQuestionB;
        private ComboBox comboBoxIndexAnswers1;
        private ComboBox comboBoxIndexAnswers2;
    }
}
