using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz
{

    public partial class Form1 : Form
    {

        List<Question> questions = new List<Question>();
        List<Answer> answers = new List<Answer>();

        

        public Form1()
        {
          
            InitializeComponent();
            
        }
        private void Clear()
        {
            aTbx.Clear();

        }

        
        private void secondTbx_Leave(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(firstTbx.Text);
            double num2 = Convert.ToDouble(secondTbx.Text);

            if (opTbx.Text == "*")
            {
                answerTbx.Text = (num1 * num2).ToString();
            }

            else if (opTbx.Text == "-")
            {
                answerTbx.Text = (num1 - num2).ToString();
            }
            else if (opTbx.Text == "/")
            {
                answerTbx.Text = (num1 / num2).ToString();
            }
            else if (opTbx.Text == "+")
            {
                answerTbx.Text = (num1 + num2).ToString();
            }
        }
        private void clearBtn_Click(object sender, EventArgs e)
        {
            firstTbx.Clear();
            secondTbx.Clear();
            answerTbx.Clear();

        }
        private void sendBtn_Click(object sender, EventArgs e)
        {
            
            if (firstTbx.Text == "")
            {
                MessageBox.Show("Enter Numbers");
            }
            else
            {
                Clear();
               
                submitBtn.Enabled = true;
                qTbx.Text = string.Format("{0}{1}{2}", firstTbx.Text, opTbx.Text, secondTbx.Text);

            }
        }

        private void submitBtn_Click_1(object sender, EventArgs e)
        {
            {
                string num1 = firstTbx.Text;
                string op = opTbx.Text;
                string num2 = secondTbx.Text;
                string answer = aTbx.Text;
                string plus = opTbx.Text;
                string minus = opTbx.Text;
                string divide = opTbx.Text;
                string squestion = qTbx.Text;
                string sanswer = aTbx.Text;
                if (qTbx.Text == "" || aTbx.Text == "")
                {
                    MessageBox.Show("Enter Number");
                }



                else if (aTbx.Text == answerTbx.Text)
                {

                    MessageBox.Show("CORRECT!!!");
                    submitBtn.Enabled = false;
                    Question q = new Question(num1, op, num2, answer, plus, minus, divide);
                    string newQuestion = q.GetStudentAnswer();
                    questionLbx.Items.Add(newQuestion);
                    questions.Add(q);

                }
                else
                {
                    MessageBox.Show("Try Again!!!");
                    Answer s = new Answer(squestion, sanswer);
                    string wrongQuestion = s.GetSAnswer();
                    wrongLbx.Items.Add(wrongQuestion);
                    answers.Add(s);
                }
            }

        }



        private void sortPlus_Click(object sender, EventArgs e)
        {

            QuestionDB.QuickSortP(questions, 0, questions.Count - 1);
            questionLbx.Items.Clear();
            foreach (Question q in questions)
            {
                questionLbx.Items.Add(q.GetStudentAnswer());
            }
        }

        private void sortMinus_Click(object sender, EventArgs e)
        {
            QuestionDB.QuickSortM(questions, 0, questions.Count - 1);
            questionLbx.Items.Clear();
            foreach (Question q in questions)
            {
                questionLbx.Items.Add(q.GetStudentAnswer());
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
    class Question
    {
        string num1;
        string op;
        string num2;
        string answer;
        string minus;
        string plus;
        string divide;

        public Question()
        {
            this.num1 = "";
            this.op = "";
            this.num2 = "";
            this.answer = "";
            this.minus = "-";
            this.plus = "+";
            this.divide = "/";
        }
        public Question(string num1, string op, string num2, string answer, string minus, string plus, string divide)
        {
            this.num1 = num1;
            this.op = op;
            this.num2 = num2;
            this.answer = answer;
            this.minus = minus;
            this.plus = plus;
            this.divide = divide;

        }
        public string Num1
        {
            get { return this.num1; }
            set { this.num1 = value; }
        }
        public string Op
        {
            get { return this.op; }
            set { this.op = value; }
        }
        public string Num2
        {
            get { return this.num2; }
            set { this.num2 = value; }
        }
        public string Answer
        {
            get { return this.answer; }
            set { this.answer = value; }
        }
        public string Minus
        {
            get { return this.minus; }
            set { this.minus = value; }
        }
        public string Plus
        {
            get { return this.plus; }
            set { this.plus = value; }
        }
        public string Divide
        {
            get { return this.divide; }
            set { this.divide = value; }
        }

    

        public string GetStudentAnswer()
        {
            return num1 + op + num2 + "=" + answer;

        }
    }
    class Question2
    {
        string num1;
        string op;
        string num2;
        string answer;


        public Question2()
        {
            this.num1 = "";
            this.op = "";
            this.num2 = "";
            this.answer = "";

        }
        public Question2(string num1, string op, string num2, string answer)
        {
            this.num1 = num1;
            this.op = op;
            this.num2 = num2;
            this.answer = answer;


        }
        public string Num1
        {
            get { return this.num1; }
            set { this.num1 = value; }
        }
        public string Op
        {
            get { return this.op; }
            set { this.op = value; }
        }
        public string Num2
        {
            get { return this.num2; }
            set { this.num2 = value; }
        }
        public string Answer
        {
            get { return this.answer; }
            set { this.answer = value; }
        }
  
    }
        class QuestionDB
    {

       
        public static int BinarySearchM(List<Question> arr, string searchItem)
        {
            int first = 0;

            int last = arr.Count - 1;
            // middle position of the array
            int mid = (first + last) / 2;
            // found or not
            bool found = false;
            while (!found && first <= last)
            {

                // check if search item is in the middle of the array
                if (arr[mid].Minus.CompareTo(searchItem) == 0)
                {
                    found = true;
                }
                // if not found move first and last to the relevant positions
                else
                {
                    if (arr[mid].Minus.CompareTo(searchItem) >= 0)
                        last = mid - 1;
                    else
                        first = mid + 1;

                    mid = (first + last) / 2;
                }

            }
            if (found)
                return mid;
            else
                return -1;

        }
        public static void QuickSortM(List<Question> arr, int first, int last)
        {
            if (first < last)
            {
                // if there are more values to sort partition the array
                int p = PartitionM(arr, first, last);
                // sort the right partition
                QuickSortM(arr, first, p - 1);
                // sort the left partition
                QuickSortM(arr, p + 1, last);
            }
        }
        public static int PartitionM(List<Question> arr, int first, int last)
        {

            // set the last element as the pivot value
            string pivot = arr[last].Minus;
            // set the one end of the array
            int i = first;
            // compare elements from begining to end with pivot element
            for (int j = first; j < last; j++)
            {
                if (pivot.CompareTo(arr[j].Minus) >= 0)
                {
                    swapM(arr[i], arr[j]);
                    i++;
                }
            }
            swapM(arr[i], arr[last]);
            return i;
        }
        public static void swapM(Question a, Question b)
        {
            // need to consider each field while swapping

            Question t = new Question(a.Num1, a.Op, a.Num2, a.Answer, a.Minus, a.Plus, a.Divide);
            a.Num1 = b.Num1; a.Op = b.Op; a.Num2 = b.Num2; a.Answer = b.Answer; a.Minus = b.Minus; a.Plus = b.Plus; a.Divide = b.Divide;
            b.Num1 = t.Num1; b.Op = t.Op; b.Num2 = t.Num2; b.Answer = t.Answer; b.Minus = t.Minus; b.Plus = t.Plus = t.Divide = b.Divide;
        }
        public static int BinarySearchP(List<Question> arr, string searchItem)
        {
            int first = 0;

            int last = arr.Count - 1;
            // middle position of the array
            int mid = (first + last) / 2;
            // found or not
            bool found = false;
            while (!found && first <= last)
            {

                // check if search item is in the middle of the array
                if (arr[mid].Plus.CompareTo(searchItem) == 0)
                {
                    found = true;
                }
                // if not found move first and last to the relevant positions
                else
                {
                    if (arr[mid].Plus.CompareTo(searchItem) >= 0)
                        last = mid - 1;
                    else
                        first = mid + 1;

                    mid = (first + last) / 2;
                }

            }
            if (found)
                return mid;
            else
                return -1;

        }
        public static void QuickSortP(List<Question> arr, int first, int last)
        {
            if (first < last)
            {
                // if there are more values to sort partition the array
                int p = PartitionP(arr, first, last);
                // sort the right partition
                QuickSortM(arr, first, p - 1);
                // sort the left partition
                QuickSortM(arr, p + 1, last);
            }
        }
        public static int PartitionP(List<Question> arr, int first, int last)
        {
            // set the last element as the pivot value
            string pivot = arr[last].Plus;
            // set the one end of the array
            int i = first;
            // compare elements from begining to end with pivot element
            for (int j = first; j < last; j++)
            {
                if (pivot.CompareTo(arr[j].Plus) >= 0)
                {
                    swapP(arr[i], arr[j]);
                    i++;
                }
            }
            swapP(arr[i], arr[last]);
            return i;
        }
        public static void swapP(Question a, Question b)
        {
            // need to consider each field while swapping

            Question t = new Question(a.Num1, a.Op, a.Num2, a.Answer, a.Minus, a.Plus, a.Divide);
            a.Num1 = b.Num1; a.Op = b.Op; a.Num2 = b.Num2; a.Answer = b.Answer; a.Minus = b.Minus; a.Plus = b.Plus; a.Divide = b.Divide;
            b.Num1 = t.Num1; b.Op = t.Op; b.Num2 = t.Num2; b.Answer = t.Answer; b.Minus = t.Minus; b.Plus = t.Plus = t.Divide = b.Divide;
        }


    }
        class Answer
        {
            string squestion;
            string sanswer;
            public Answer()
            {
                this.squestion = "";
                this.sanswer = "";
            }
            public Answer(string squestion, string sanswer)
            {
                this.sanswer = sanswer;
                this.squestion = squestion;
            }
            public string Question
            {
                get { return this.squestion; }
                set { this.squestion = value; }
            }
            public string sAnswer
            {
                get { return this.sanswer; }
                set { this.sanswer = value; }
            }
            public string GetSAnswer()
            {
                return squestion + " = " + sanswer;
            }
        }


    

}







































