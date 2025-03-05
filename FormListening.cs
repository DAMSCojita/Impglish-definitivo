using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace ProyectoAprenderIngles
{
    public partial class FormListening : Form
    {
        private List<Question> questions = new List<Question>();
        private int currentQuestionIndex = 0; // Índice de la pregunta actual

        public FormListening()
        {
            InitializeComponent();
            LoadQuestionsFromDatabase(); // Cargar preguntas desde la base de datos
            CenterControls();
            this.Resize += Form2_Resize;
        }

        private void LoadQuestionsFromDatabase()
        {
            string connectionString = "Server=Localhost\\SQLEXPRESS;Database=Wireframe;User Id=Bruno;Password=1234;Trusted_Connection=True;TrustServerCertificate=True";
            string query = "SELECT Pregunta, Respuesta FROM Listening";

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
                                QuestionText = reader["Pregunta"].ToString(),
                                CorrectAnswer = reader["Respuesta"].ToString(),
                                AudioFile = "default.mp3"
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
        private void Form2_Resize(object sender, EventArgs e)
        {
            CenterControls(); // Recalcular las posiciones de los controles al cambiar el tamaño
        }

        private void CenterControls()
        {
            // Centrar la etiqueta de título
            labelListeningQuizTitle.Left = (this.ClientSize.Width - labelListeningQuizTitle.Width) / 2;
            labelListeningQuizTitle.Top = 30;

            // Centrar la pregunta
            labelListeningIndexQuestion.Left = (this.ClientSize.Width - labelListeningIndexQuestion.Width) / 2;
            labelListeningIndexQuestion.Top = 130;

            // Centrar el cuadro de texto de respuesta
            textBoxAnswer.Left = (this.ClientSize.Width - textBoxAnswer.Width) / 2;
            textBoxAnswer.Top = 160;

            // Posicionar el botón "Comprobar respuesta"
            buttonCheck.Left = textBoxAnswer.Right + 10;
            buttonCheck.Top = textBoxAnswer.Top;

            // Posicionar el botón "Reproducir"
            buttonPlay.Left = textBoxAnswer.Left - buttonPlay.Width - 10;
            buttonPlay.Top = textBoxAnswer.Top;

            // Centrar la etiqueta de respuesta correcta
            labelCheck.Left = (this.ClientSize.Width - labelCheck.Width) / 2;
            labelCheck.Top = 240;

            // Centrar el cuadro de texto de la respuesta correcta
            textBoxCheckAnswer.Left = (this.ClientSize.Width - textBoxCheckAnswer.Width) / 2;
            textBoxCheckAnswer.Top = 270;

            // Centrar el botón de siguiente pregunta
            NextQuestionB.Left = (this.ClientSize.Width - NextQuestionB.Width) / 2;
            NextQuestionB.Top = 320;
        }
        private void LoadQuestion()
        {
            if (questions.Count == 0)
            {
                MessageBox.Show("No hay preguntas en la base de datos.");
                return;
            }

            var currentQuestion = questions[currentQuestionIndex];
            labelListeningIndexQuestion.Text = currentQuestion.QuestionText;
            textBoxAnswer.Clear();
            textBoxCheckAnswer.Text = string.Empty;
            buttonPlay.Text = "Reproducir audio";
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
                MessageBox.Show("¡Quiz completado!");
            }
        }

        private void checkListening_Click(object sender, EventArgs e)
        {
            string correctAnswer = questions[currentQuestionIndex].CorrectAnswer;
            string userAnswer = textBoxAnswer.Text.Trim();

            if (userAnswer.Equals(correctAnswer, StringComparison.OrdinalIgnoreCase))
            {
                textBoxCheckAnswer.Text = "Respuesta correcta: " + correctAnswer;
                NextQuestionB.Enabled = true;
            }
            else
            {
                textBoxCheckAnswer.Text = "Incorrecto, intenta nuevamente.";
            }
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            string audioFile = questions[currentQuestionIndex].AudioFile;
            string audioPath = Path.Combine(Application.StartupPath, "Resources", audioFile);

            if (File.Exists(audioPath))
            {
                WindowsMediaPlayer player = new WindowsMediaPlayer();
                player.URL = audioPath;
                player.controls.play();
            }
            else
            {
                MessageBox.Show("El archivo de audio no se encontró.");
            }
        }

        public class Question
        {
            public string QuestionText { get; set; }
            public string CorrectAnswer { get; set; }
            public string AudioFile { get; set; }
        }
    }
}
