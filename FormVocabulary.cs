using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProyectoAprenderIngles
{
    public partial class FormVocabulary : Form
    {
        private List<Question> questions = new List<Question>();
        private int currentQuestionIndex = 0;

        public FormVocabulary()
        {
            InitializeComponent();
            LoadQuestionsFromDatabase(); // Cargar datos de la base de datos
            LoadQuestion();
            this.Resize += Form2_Resize;
        }

        private void LoadQuestionsFromDatabase()
        {
            string connectionString = "Server=localhost\\SQLEXPRESS;Database=Wireframe;User id=bruno;Password = 1234;Trusted_Connection = true;TrustServerCertificate=True";
            string query = "SELECT Pregunta, Resp1, Resp2, Resp3, RespCorrecta FROM dbo.Vocabulary";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Question question = new Question
                            {
                                QuestionText = reader["Pregunta"].ToString(),
                                Answers = new string[]
                                {
                                    reader["Resp1"].ToString(),
                                    reader["Resp2"].ToString(),
                                    reader["Resp3"].ToString()
                                },
                                CorrectAnswer = reader["RespCorrecta"].ToString()
                            };
                            questions.Add(question);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar preguntas: " + ex.Message);
                }
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (questions.Count > 0)
            {
                LoadQuestion();
                NextQuestionB.Enabled = false;
            }
            else
            {
                MessageBox.Show("No hay preguntas disponibles en la base de datos.");
            }
        }

        private void LoadQuestion()
        {
            var currentQuestion = questions[currentQuestionIndex];
            labelVocabularyIndexQuestion.Text = currentQuestion.QuestionText;
            answerA1.Text = currentQuestion.Answers[0];
            answerA2.Text = currentQuestion.Answers[1];
            answerA3.Text = currentQuestion.Answers[2];
            textBoxInputAnswer.Clear();
            textBoxCheckAnswer.Text = string.Empty;
        }

        private void checkVocabulary_Click(object sender, EventArgs e)
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


        public class Question
        {
            public string QuestionText { get; set; }
            public string[] Answers { get; set; }
            public string CorrectAnswer { get; set; }
        }

        private void NextQuestionB_Click(object sender, EventArgs e)
        {
            currentQuestionIndex++;
            if (currentQuestionIndex < questions.Count)
            {
                LoadQuestion();
                NextQuestionB.Enabled = false;
            }
            else
            {
                MessageBox.Show("Quiz complete!");
            }
        }

        private void Form2_Resize(object sender, EventArgs e)
        {
            CenterControls();
        }

        private void CenterControls()
        {
            labelVocabularyQuizTitle.Left = (this.ClientSize.Width - labelVocabularyQuizTitle.Width) / 2;
            labelVocabularyIndexQuestion.Left = (this.ClientSize.Width - labelVocabularyIndexQuestion.Width) / 2;
            answerA1.Left = (this.ClientSize.Width - 3 * answerA1.Width - 20) / 2;
            answerA2.Left = answerA1.Left + answerA1.Width + 10;
            answerA3.Left = answerA2.Left + answerA2.Width + 10;
            textBoxInputAnswer.Left = (this.ClientSize.Width - textBoxInputAnswer.Width) / 2;
            buttonCheck.Left = textBoxInputAnswer.Right + 10;
            labelCorrectAnswer.Left = (this.ClientSize.Width - labelCorrectAnswer.Width) / 2;
            textBoxCheckAnswer.Left = (this.ClientSize.Width - textBoxCheckAnswer.Width) / 2;
            NextQuestionB.Left = (this.ClientSize.Width - NextQuestionB.Width) / 2;
        }



    }
}
