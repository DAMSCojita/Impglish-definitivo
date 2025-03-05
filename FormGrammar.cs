using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ProyectoAprenderIngles
{
    public partial class FormGrammar : Form
    {
        private List<Question> questions;
        private int currentQuestionIndex;

        public FormGrammar()
        {
            InitializeComponent();
            questions = new List<Question>();
            LoadQuestionsFromDatabase();
            currentQuestionIndex = 0;
            CenterControls();
            this.Resize += Form2_Resize;
        }

        private void LoadQuestionsFromDatabase()
        {
            string connectionString = "Server=Localhost\\SQLEXPRESS;Database=Wireframe;User Id=Bruno;Password=1234;Trusted_Connection=True;TrustServerCertificate=True";
            string query = "SELECT Frase, RespCorrecta, Resp1, Resp2, Resp3 FROM Grammar";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            questions.Add(new Question
                            {
                                QuestionText = reader["Frase"].ToString(),
                                CorrectAnswer = reader["RespCorrecta"].ToString(),
                                Answers = new string[]
                                {
                                    reader["Resp1"].ToString(),
                                    reader["Resp2"].ToString(),
                                    reader["Resp3"].ToString()
                                }
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            NextQuestionB.Enabled = false;
            LoadQuestion();
        }

        private void LoadQuestion()
        {
            if (questions.Count == 0)
            {
                MessageBox.Show("No hay preguntas en la base de datos.");
                return;
            }

            var currentQuestion = questions[currentQuestionIndex];

            labelGrammarIndexQuestion.Text = currentQuestion.QuestionText;

            var shuffledAnswers = currentQuestion.Answers.OrderBy(a => Guid.NewGuid()).ToArray();
            answerA1.Text = shuffledAnswers[0];
            answerA2.Text = shuffledAnswers[1];
            answerA3.Text = shuffledAnswers[2];

            textBoxInputAnswer.Clear();
            textBoxCheckAnswer.Text = string.Empty;
        }

        private void Form2_Resize(object sender, EventArgs e)
        {
            CenterControls();
        }

        private void CenterControls()
        {
            labelGrammarQuizTitle.Left = (this.ClientSize.Width - labelGrammarQuizTitle.Width) / 2;
            labelGrammarQuizTitle.Top = 30;

            labelGrammarIndexQuestion.Left = (this.ClientSize.Width - labelGrammarIndexQuestion.Width) / 2;
            labelGrammarIndexQuestion.Top = 130;

            answerA1.Left = (this.ClientSize.Width - 3 * answerA1.Width - 20) / 2;
            answerA1.Top = 200;

            answerA2.Left = answerA1.Left + answerA1.Width + 10;
            answerA2.Top = answerA1.Top;

            answerA3.Left = answerA2.Left + answerA2.Width + 10;
            answerA3.Top = answerA1.Top;

            textBoxInputAnswer.Left = (this.ClientSize.Width - textBoxInputAnswer.Width) / 2;
            textBoxInputAnswer.Top = 160;

            buttonCheck.Left = textBoxInputAnswer.Right + 10;
            buttonCheck.Top = textBoxInputAnswer.Top;

            textBoxCheckAnswer.Left = (this.ClientSize.Width - textBoxCheckAnswer.Width) / 2;
            textBoxCheckAnswer.Top = 270;

            NextQuestionB.Left = (this.ClientSize.Width - NextQuestionB.Width) / 2;
            NextQuestionB.Top = 320;
        }

        private void checkGrammar_Click(object sender, EventArgs e)
        {
            string correctAnswer = questions[currentQuestionIndex].CorrectAnswer;
            string userAnswer = textBoxInputAnswer.Text.Trim();

            if (userAnswer.Equals(correctAnswer, StringComparison.OrdinalIgnoreCase))
            {
                textBoxCheckAnswer.Text = "You have put the correct answer: " + correctAnswer;
                NextQuestionB.Enabled = true;
            }
            else
            {
                textBoxCheckAnswer.Text = "Incorrect, try again.";
            }
        }

        private void NextQuestionB_Click(object sender, EventArgs e)
        {
            if (++currentQuestionIndex < questions.Count)
            {
                LoadQuestion();
                NextQuestionB.Enabled = false;
            }
            else
            {
                MessageBox.Show("Quiz complete!");
            }
        }

        public class Question
        {
            public string QuestionText { get; set; }
            public string[] Answers { get; set; }
            public string CorrectAnswer { get; set; }
        }
    }
}
