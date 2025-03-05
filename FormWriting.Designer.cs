using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoAprenderIngles
{
    partial class FormWriting
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

        private void InitializeComponent()
        {
            this.labelWritingQuizTitle = new System.Windows.Forms.Label();
            this.labelWritingIndexQuestion = new System.Windows.Forms.Label();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.labelWritingPhrasePiece1 = new System.Windows.Forms.Label();
            this.labelWritingPhrasePiece2 = new System.Windows.Forms.Label();
            this.labelWritingPhrasePiece3 = new System.Windows.Forms.Label();
            this.labelWritingPhrasePiece4 = new System.Windows.Forms.Label();
            this.textBoxBlankSpace1 = new System.Windows.Forms.TextBox();
            this.textBoxBlankSpace2 = new System.Windows.Forms.TextBox();
            this.textBoxBlankSpace3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelWritingQuizTitle
            // 
            this.labelWritingQuizTitle.AutoSize = true;
            this.labelWritingQuizTitle.Font = new System.Drawing.Font("Segoe UI", 24F);
            this.labelWritingQuizTitle.Location = new System.Drawing.Point(307, 36);
            this.labelWritingQuizTitle.Name = "labelWritingQuizTitle";
            this.labelWritingQuizTitle.Size = new System.Drawing.Size(247, 54);
            this.labelWritingQuizTitle.TabIndex = 0;
            this.labelWritingQuizTitle.Text = "Writing Quiz";
            // 
            // labelWritingIndexQuestion
            // 
            this.labelWritingIndexQuestion.AutoSize = true;
            this.labelWritingIndexQuestion.Location = new System.Drawing.Point(278, 139);
            this.labelWritingIndexQuestion.Name = "labelWritingIndexQuestion";
            this.labelWritingIndexQuestion.Size = new System.Drawing.Size(104, 16);
            this.labelWritingIndexQuestion.TabIndex = 1;
            this.labelWritingIndexQuestion.Text = "Fill in the blanks:";
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(278, 340);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(289, 43);
            this.buttonSubmit.TabIndex = 3;
            this.buttonSubmit.Text = "Comprobar respuestas";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // labelWritingPhrasePiece1
            // 
            this.labelWritingPhrasePiece1.AutoSize = true;
            this.labelWritingPhrasePiece1.Location = new System.Drawing.Point(11, 178);
            this.labelWritingPhrasePiece1.Name = "labelWritingPhrasePiece1";
            this.labelWritingPhrasePiece1.Size = new System.Drawing.Size(0, 16);
            this.labelWritingPhrasePiece1.TabIndex = 4;
            // 
            // labelWritingPhrasePiece2
            // 
            this.labelWritingPhrasePiece2.AutoSize = true;
            this.labelWritingPhrasePiece2.Location = new System.Drawing.Point(126, 178);
            this.labelWritingPhrasePiece2.Name = "labelWritingPhrasePiece2";
            this.labelWritingPhrasePiece2.Size = new System.Drawing.Size(0, 16);
            this.labelWritingPhrasePiece2.TabIndex = 5;
            // 
            // labelWritingPhrasePiece3
            // 
            this.labelWritingPhrasePiece3.AutoSize = true;
            this.labelWritingPhrasePiece3.Location = new System.Drawing.Point(310, 178);
            this.labelWritingPhrasePiece3.Name = "labelWritingPhrasePiece3";
            this.labelWritingPhrasePiece3.Size = new System.Drawing.Size(0, 16);
            this.labelWritingPhrasePiece3.TabIndex = 6;
            // 
            // labelWritingPhrasePiece4
            // 
            this.labelWritingPhrasePiece4.AutoSize = true;
            this.labelWritingPhrasePiece4.Location = new System.Drawing.Point(501, 178);
            this.labelWritingPhrasePiece4.Name = "labelWritingPhrasePiece4";
            this.labelWritingPhrasePiece4.Size = new System.Drawing.Size(0, 16);
            this.labelWritingPhrasePiece4.TabIndex = 7;
            // 
            // textBoxBlankSpace1
            // 
            this.textBoxBlankSpace1.Location = new System.Drawing.Point(46, 175);
            this.textBoxBlankSpace1.Name = "textBoxBlankSpace1";
            this.textBoxBlankSpace1.Size = new System.Drawing.Size(78, 22);
            this.textBoxBlankSpace1.TabIndex = 8;
            // 
            // textBoxBlankSpace2
            // 
            this.textBoxBlankSpace2.Location = new System.Drawing.Point(256, 175);
            this.textBoxBlankSpace2.Name = "textBoxBlankSpace2";
            this.textBoxBlankSpace2.Size = new System.Drawing.Size(53, 22);
            this.textBoxBlankSpace2.TabIndex = 9;
            // 
            // textBoxBlankSpace3
            // 
            this.textBoxBlankSpace3.Location = new System.Drawing.Point(425, 175);
            this.textBoxBlankSpace3.Name = "textBoxBlankSpace3";
            this.textBoxBlankSpace3.Size = new System.Drawing.Size(76, 22);
            this.textBoxBlankSpace3.TabIndex = 10;
            // 
            // FormWriting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 480);
            this.Controls.Add(this.labelWritingQuizTitle);
            this.Controls.Add(this.labelWritingIndexQuestion);
            this.Controls.Add(this.labelWritingPhrasePiece1);
            this.Controls.Add(this.textBoxBlankSpace1);
            this.Controls.Add(this.labelWritingPhrasePiece2);
            this.Controls.Add(this.textBoxBlankSpace2);
            this.Controls.Add(this.labelWritingPhrasePiece3);
            this.Controls.Add(this.textBoxBlankSpace3);
            this.Controls.Add(this.labelWritingPhrasePiece4);
            this.Controls.Add(this.buttonSubmit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormWriting";
            this.Text = "Writing Quiz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelWritingQuizTitle;
        private Label labelWritingIndexQuestion;
        private Button buttonSubmit; // Para enviar las respuestas
        private Label labelWritingPhrasePiece1;
        private Label labelWritingPhrasePiece2;
        private Label labelWritingPhrasePiece3;
        private Label labelWritingPhrasePiece4;
        private TextBox textBoxBlankSpace1;
        private TextBox textBoxBlankSpace2;
        private TextBox textBoxBlankSpace3;
    }
}
