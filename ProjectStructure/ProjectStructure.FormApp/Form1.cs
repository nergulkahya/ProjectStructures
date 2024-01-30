using ProjectStructure.Support.Algoritma;

namespace ProjectStructure.FormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvertToText_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           string code= GuidCodeGeneration.GuidCode();
            Console.WriteLine(code);
            Console.ReadLine();
        }
    }
}