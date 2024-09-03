namespace WordGuessApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            List<String> Fruits = new List<String> { "Apple", "Banana",/* "Avocado", "Apricot", "Peach", "Orange", "Mango"*/ };

            String randomFruit = Fruits[random.Next(Fruits.Count)];

            String guess = Answer.Text.Trim().ToLower();

            if (!Fruits.Contains(guess, StringComparer.OrdinalIgnoreCase))
            {
                Prompts.Items.Add("Your answer was: " + guess);
                AnswerList.Items.Add("Answer is NOT in the list of choices!" );
            }
            
            if (guess == randomFruit.ToLower() && Fruits.Contains(guess, StringComparer.OrdinalIgnoreCase))
            {
                Prompts.Items.Add("Your answer was: " + guess);
                Result.Text = "That is correct!";
                AnswerList.Items.Add("right |Correct answer was: " + randomFruit);
                
            }
            else if(guess != randomFruit.ToLower() && Fruits.Contains(guess, StringComparer.OrdinalIgnoreCase))
            {
                Prompts.Items.Add("Your answer was: " + guess);
                Result.Text = "Wrong answer! ";
                AnswerList.Items.Add("wrong |Correct answer was: " + randomFruit);
                
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
    }
}
