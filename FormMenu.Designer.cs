using System.Drawing;
using System.Windows.Forms;

namespace Wirframe
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            panelMenuTopButtons = new Panel();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            panelMenuFormularyButtons = new Panel();
            pictureBox4 = new PictureBox();
            buttonWriting = new Button();
            buttonVocabulary = new Button();
            buttonGrammar = new Button();
            buttonListening = new Button();
            buttonReading = new Button();
            panelFormulary = new Panel();
            panelMenuTopButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelMenuFormularyButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // panel1 (aquí se añaden los controles para los botones de minimizar, maximizar y cerrar la ventana principal)
            // 
            panelMenuTopButtons.BackColor = SystemColors.ActiveCaption;
            panelMenuTopButtons.Controls.Add(pictureBox3);
            panelMenuTopButtons.Controls.Add(pictureBox2);
            panelMenuTopButtons.Controls.Add(pictureBox1);
            panelMenuTopButtons.Dock = DockStyle.Top;
            panelMenuTopButtons.Location = new Point(0, 0);
            panelMenuTopButtons.Name = "panelMenuTopButtons";
            panelMenuTopButtons.Size = new Size(700, 35);
            panelMenuTopButtons.TabIndex = 0;
            // 
            // pictureBox3 (imagen que representa el boton de minimizar la ventana de la aplicación)
            // 
            pictureBox3.Dock = DockStyle.Right;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(600, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(35, 35);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox2 (imagen que representa el boton de maximizar la ventana de la aplicación)
            // 
            pictureBox2.Dock = DockStyle.Right;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(635, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(35, 35);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox1 (imagen que representa el boton de cerrar la ventana de la aplicación)
            // 
            pictureBox1.Dock = DockStyle.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(670, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 35);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panelMenuButtons
            // 
            panelMenuFormularyButtons.BackColor = SystemColors.Info;
            panelMenuFormularyButtons.Controls.Add(pictureBox4);
            panelMenuFormularyButtons.Controls.Add(buttonWriting);
            panelMenuFormularyButtons.Controls.Add(buttonVocabulary);
            panelMenuFormularyButtons.Controls.Add(buttonGrammar);
            panelMenuFormularyButtons.Controls.Add(buttonListening);
            panelMenuFormularyButtons.Controls.Add(buttonReading);
            panelMenuFormularyButtons.Dock = DockStyle.Left;
            panelMenuFormularyButtons.Location = new Point(0, 35);
            panelMenuFormularyButtons.Name = "panelMenuFormularyButtons";
            panelMenuFormularyButtons.Size = new Size(175, 515);
            panelMenuFormularyButtons.TabIndex = 1;
            // 
            // pictureBox4 (imagen del logo de la aplicación)
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(-3, 0);
            pictureBox4.Margin = new Padding(0);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(175, 173);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 5;
            pictureBox4.TabStop = false;
            // 
            // buttonWriting
            // 
            buttonWriting.Dock = DockStyle.Bottom;
            buttonWriting.Location = new Point(0, 305);
            buttonWriting.Name = "buttonWriting";
            buttonWriting.Size = new Size(175, 42);
            buttonWriting.TabIndex = 4;
            buttonWriting.Text = "Writing ";
            buttonWriting.UseVisualStyleBackColor = true;
            buttonWriting.Click += buttonWriting_Click;
            // 
            // buttonVocabulary
            // 
            buttonVocabulary.Dock = DockStyle.Bottom;
            buttonVocabulary.Location = new Point(0, 347);
            buttonVocabulary.Name = "buttonVocabulary";
            buttonVocabulary.Size = new Size(175, 42);
            buttonVocabulary.TabIndex = 3;
            buttonVocabulary.Text = "Vocabulary";
            buttonVocabulary.UseVisualStyleBackColor = true;
            buttonVocabulary.Click += buttonVocabulary_Click;
            // 
            // buttonGrammar
            // 
            buttonGrammar.Dock = DockStyle.Bottom;
            buttonGrammar.Location = new Point(0, 389);
            buttonGrammar.Name = "buttonGrammar";
            buttonGrammar.Size = new Size(175, 42);
            buttonGrammar.TabIndex = 2;
            buttonGrammar.Text = "Grammar";
            buttonGrammar.UseVisualStyleBackColor = true;
            buttonGrammar.Click += buttonGrammar_Click;
            // 
            // buttonListening
            // 
            buttonListening.Dock = DockStyle.Bottom;
            buttonListening.Location = new Point(0, 431);
            buttonListening.Name = "buttonListening";
            buttonListening.Size = new Size(175, 42);
            buttonListening.TabIndex = 1;
            buttonListening.Text = "Listening";
            buttonListening.UseVisualStyleBackColor = true;
            buttonListening.Click += buttonListening_Click;
            // 
            // buttonReading
            // 
            buttonReading.Dock = DockStyle.Bottom;
            buttonReading.Location = new Point(0, 473);
            buttonReading.Name = "buttonReading";
            buttonReading.Size = new Size(175, 42);
            buttonReading.TabIndex = 0;
            buttonReading.Text = "Reading";
            buttonReading.UseVisualStyleBackColor = true;
            buttonReading.Click += buttonReading_Click;
            // 
            // panelFormulary
            // 
            panelFormulary.BackColor = SystemColors.GradientInactiveCaption;
            panelFormulary.Dock = DockStyle.Fill;
            panelFormulary.Location = new Point(175, 35);
            panelFormulary.Name = "panelFormulary";
            panelFormulary.Size = new Size(525, 515);
            panelFormulary.TabIndex = 2;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 600);
            Controls.Add(panelFormulary);
            Controls.Add(panelMenuFormularyButtons);
            Controls.Add(panelMenuTopButtons);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormMenu";
            Text = "Form2";
            panelMenuTopButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelMenuFormularyButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelMenuTopButtons;
        private System.Windows.Forms.Panel panelMenuFormularyButtons;
        private System.Windows.Forms.Panel panelFormulary;
        private System.Windows.Forms.Button buttonGrammar;
        private System.Windows.Forms.Button buttonListening;
        private System.Windows.Forms.Button buttonReading;
        private System.Windows.Forms.Button buttonWriting;
        private System.Windows.Forms.Button buttonVocabulary;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        
    }
}