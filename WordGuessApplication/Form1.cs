namespace WordGuessApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            List<String> Fruits = new List<String> { "Apple", "Banana", "Avocado", "Apricot", "Peach", "Orange", "Mango" };

            String randomFruit = Fruits[random.Next(Fruits.Count)];

            String guess = Answer.Text.Trim().ToLower();

            if (!Fruits.Contains(guess, StringComparer.OrdinalIgnoreCase))
            {
                Prompts.Items.Add("Your answer was: " + guess);
                History.Items.Add("Answer is NOT in the list of choices!");
            }

            if (guess == randomFruit.ToLower() && Fruits.Contains(guess, StringComparer.OrdinalIgnoreCase))
            {
                Prompts.Items.Add("Your answer was: " + guess);
                Result.Text = "That is correct!";
                History.Items.Add("right |Correct answer was: " + randomFruit);

            }
            else if (guess != randomFruit.ToLower() && Fruits.Contains(guess, StringComparer.OrdinalIgnoreCase))
            {
                Prompts.Items.Add("Your answer was: " + guess);
                Result.Text = "Wrong answer! ";
                History.Items.Add("wrong |Correct answer was: " + randomFruit);

            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Answer_TextChanged(object sender, EventArgs e)
        {

        }

        private void AnswerList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                click.PerformClick();
            }
        }
    }
}
