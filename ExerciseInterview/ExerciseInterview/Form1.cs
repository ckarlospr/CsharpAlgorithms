using System.Text.RegularExpressions;

namespace ExerciseInterview
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string data = "  #$&(Carlos    (&/(%&/$Perez345    Ramirez       ";
            data = data.ToLower();
            data = Regex.Replace(data, @"\s+", "");
            string pattern = @"[a-z]";
            var regex = new Regex(pattern);
            
            MessageBox.Show(data);
            List<char> list = new List<char>();

            foreach (char c in data)
            {
                if (regex.IsMatch(c.ToString()))
                {
                    if(!list.Contains(c))
                        list.Add(c);
                }
            }

            list.Sort();

            string dd = "";
            foreach(char c in list)
            {
                int count = 0;
                string p = c.ToString();
                foreach(char d in data)
                {
                    if(c == d) { count++; }    
                }
                dd = dd + "\n" + p + " " + count;
                p = "";
                count = 0;
            }

            MessageBox.Show(dd);
        }
    }
}