using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace ProyectoAprenderIngles
{
    public partial class FormWriting : Form
    {
        private string[] correctAnswers;
        private string connectionString = "Server=localhost\\SQLEXPRESS;Database=Wireframe;User id=bruno;Password = 1234;Trusted_Connection = true;TrustServerCertificate=True";

        public FormWriting()
        {
            InitializeComponent();
            this.Resize += Form2_Resize;
            LoadDataFromDatabase();
            CenterControls();
        }

        private void LoadDataFromDatabase()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT Texto1, Texto2, Texto3, Texto4 FROM Writing";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        labelWritingPhrasePiece1.Text = reader["Texto1"].ToString();
                        labelWritingPhrasePiece2.Text = reader["Texto2"].ToString();
                        labelWritingPhrasePiece3.Text = reader["Texto3"].ToString();
                        labelWritingPhrasePiece4.Text = reader["Texto4"].ToString();
                    }
                    reader.Close();

                    query = "SELECT Resp1, Resp2, Resp3 FROM Writing";
                    cmd = new SqlCommand(query, conn);
                    reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        correctAnswers = new string[]
                        {
                            reader["Resp1"].ToString().Trim(),
                            reader["Resp2"].ToString().Trim(),
                            reader["Resp3"].ToString().Trim()
                        };
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los datos: " + ex.Message);
                }
            }
        }
        private void CenterControls()
        {
            // Centrar el título
            labelWritingQuizTitle.Left = (ClientSize.Width - labelWritingQuizTitle.Width) / 2;

            // Centrar la instrucción
            labelWritingIndexQuestion.Left = (ClientSize.Width - labelWritingIndexQuestion.Width) / 2;

            // Calcular el ancho total de los controles en la frase
            int totalWidth = labelWritingPhrasePiece1.Width + textBoxBlankSpace1.Width +
                             labelWritingPhrasePiece2.Width + textBoxBlankSpace2.Width +
                             labelWritingPhrasePiece3.Width + textBoxBlankSpace3.Width +
                             labelWritingPhrasePiece4.Width;

            // Calcular la posición inicial para centrar el grupo
            int startX = (ClientSize.Width - totalWidth) / 2;

            // Posicionar los controles en orden
            labelWritingPhrasePiece1.Left = startX;
            textBoxBlankSpace1.Left = labelWritingPhrasePiece1.Right;
            labelWritingPhrasePiece2.Left = textBoxBlankSpace1.Right;
            textBoxBlankSpace2.Left = labelWritingPhrasePiece2.Right;
            labelWritingPhrasePiece3.Left = textBoxBlankSpace2.Right;
            textBoxBlankSpace3.Left = labelWritingPhrasePiece3.Right;
            labelWritingPhrasePiece4.Left = textBoxBlankSpace3.Right;

            // Alinear verticalmente los controles
            int baseY = labelWritingPhrasePiece1.Top;
            textBoxBlankSpace1.Top = textBoxBlankSpace2.Top = textBoxBlankSpace3.Top = baseY - 3;


            // Centrar el botón de envío
            buttonSubmit.Left = (ClientSize.Width - buttonSubmit.Width) / 2;
        }
        private void Form2_Resize(object sender, EventArgs e)
        {
            CenterControls();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            string[] userAnswers = {
                textBoxBlankSpace1.Text.Trim(),
                textBoxBlankSpace2.Text.Trim(),
                textBoxBlankSpace3.Text.Trim()
            };

            if (userAnswers.All(string.IsNullOrWhiteSpace))
            {
                MessageBox.Show("Por favor, responde todas las preguntas antes de enviar.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (userAnswers.Any(string.IsNullOrWhiteSpace))
            {
                MessageBox.Show("Por favor, completa todos los espacios en blanco.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool allCorrect = userAnswers.SequenceEqual(correctAnswers, StringComparer.OrdinalIgnoreCase);

            MessageBox.Show(allCorrect ? "¡Todas las respuestas son correctas!" : "Algunas respuestas son incorrectas. Inténtalo de nuevo.", "Resultado", MessageBoxButtons.OK, allCorrect ? MessageBoxIcon.Information : MessageBoxIcon.Warning);
        }
    }
}
