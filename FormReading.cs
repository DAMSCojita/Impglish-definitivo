using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProyectoAprenderIngles
{
    public partial class FormReading : Form
    {
        private int currentQuestionIndex = 0;
        private SqlConnection connection;

        private List<string[]> labelQuestions = new List<string[]>(); // Preguntas comboBox1
        private List<string[]> labelQuestions2 = new List<string[]>(); // Preguntas comboBox2
        private List<string[]> options = new List<string[]>(); // Opciones comboBox1
        private List<string[]> options2 = new List<string[]>(); // Opciones comboBox2
        private List<string[]> stories = new List<string[]>(); // Historias
        private List<string> comboAnswers = new List<string>(); // Respuestas correctas comboBox1
        private List<string> comboAnswers2 = new List<string>(); // Respuestas correctas comboBox2

        public FormReading()
        {
            InitializeComponent();
            InitializeDatabase();
            LoadDataFromDatabase();
            UpdateQuestion();
            CenterControls();
            this.Resize += Form2_Resize;
        }

        private void InitializeDatabase()
        {
            try
            {
                connection = new SqlConnection("Server=Localhost\\SQLEXPRESS;Database=Wireframe;User Id=Bruno;Password=1234;Trusted_Connection=True;TrustServerCertificate=True");
                connection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error connecting to database: " + ex.Message);
            }
        }

        private void LoadDataFromDatabase()
        {
            try
            {
                string query = "SELECT Frase, " +
               "RespuestaPregunta1_1, RespuestaPregunta1_2, RespuestaPregunta1_3, " +
               "RespuestaPregunta2_1, RespuestaPregunta2_2, RespuestaPregunta2_3, " +
               "Pregunta1, Pregunta2, " +
               "RespuestaCorrecta1, RespuestaCorrecta2 " +
               "FROM Reading";

                using (SqlCommand command = new SqlCommand(query, connection))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        stories.Add(new string[] { reader["Frase"].ToString() });
                        labelQuestions.Add(new string[] { reader["Pregunta1"].ToString() });
                        labelQuestions2.Add(new string[] { reader["Pregunta2"].ToString() });

                        options.Add(new string[] {
                            "Choose an option",
                            reader["RespuestaPregunta1_1"].ToString(),
                            reader["RespuestaPregunta1_2"].ToString(),
                            reader["RespuestaPregunta1_3"].ToString()
                        });

                        options2.Add(new string[] {
                            "Choose an option",
                            reader["RespuestaPregunta2_1"].ToString(),
                            reader["RespuestaPregunta2_2"].ToString(),
                            reader["RespuestaPregunta2_3"].ToString()
                        });

                        comboAnswers.Add(reader["RespuestaCorrecta1"].ToString());
                        comboAnswers2.Add(reader["RespuestaCorrecta2"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }

        private void Form2_Resize(object sender, EventArgs e)
        {
            CenterControls();
        }

        private void CenterControls()
        {
            int padding = 10;
            labelReadingQuizTitle.Left = (ClientSize.Width - labelReadingQuizTitle.Width) / 2;
            labelReadingQuizTitle.Top = 30;
            labelReadingIndexQuestion.Left = (ClientSize.Width - labelReadingIndexQuestion.Width) / 2;
            textBoxStoryIndex.Left = (ClientSize.Width - textBoxStoryIndex.Width) / 2;
        }

        private void checkReading_Click(object sender, EventArgs e)
        {
            string selectedAnswer = comboBoxIndexAnswers1.SelectedItem?.ToString();
            string selectedAnswer2 = comboBoxIndexAnswers2.SelectedItem?.ToString();

            if (selectedAnswer == "Choose an option" || selectedAnswer2 == "Choose an option")
            {
                MessageBox.Show("Aún no has respondido todas las preguntas.");
                return;
            }

            if (selectedAnswer == comboAnswers[currentQuestionIndex] && selectedAnswer2 == comboAnswers2[currentQuestionIndex])
            {
                MessageBox.Show("¡Has elegido las respuestas correctas!");
                currentQuestionIndex++;
                NextQuestionB.Enabled = true;
            }
            else
            {
                MessageBox.Show("Alguna de tus respuestas no es correcta!");
                NextQuestionB.Enabled = false;
            }
        }

        private void NextQuestionB_Click(object sender, EventArgs e)
        {
            if (currentQuestionIndex < options.Count)
            {
                UpdateQuestion();
                NextQuestionB.Enabled = false;
            }
            else
            {
                MessageBox.Show("¡Has completado todas las preguntas!");
                NextQuestionB.Enabled = false;
            }
        }

        private void UpdateQuestion()
        {
            if (currentQuestionIndex < options.Count)
            {
                comboBoxIndexAnswers1.Items.Clear();
                comboBoxIndexAnswers1.Items.AddRange(options[currentQuestionIndex]);
                comboBoxIndexAnswers1.SelectedIndex = 0;

                comboBoxIndexAnswers2.Items.Clear();
                comboBoxIndexAnswers2.Items.AddRange(options2[currentQuestionIndex]);
                comboBoxIndexAnswers2.SelectedIndex = 0;

                labelReadingIndexComboQuestion1.Text = labelQuestions[currentQuestionIndex][0];
                labelReadingIndexComboQuestion2.Text = labelQuestions2[currentQuestionIndex][0];

                textBoxStoryIndex.Text = stories[currentQuestionIndex][0];
            }
        }
    }
}
