using Accord.MachineLearning.VectorMachines.Learning;
using Accord.Statistics.Kernels;
using System;
using System.Windows.Forms;

namespace VCTWinnerPredictor
{


    public partial class Form1 : Form
    {

        public string teamAName;
        public string teamBName;

        public string teamAPath;
        public string teamBPath;

        public int aIndex;
        public int bIndex;

        public Form1()
        {
            InitializeComponent();
            DataLoad dataLoad = new DataLoad();
        }

        public void algorithmRun(int aLWins, int aRWins, int aRoster, int aRanking, int bLWins, int bRWins, int bRoster, int bRanking)
        {

            double[][] inputs =
            {
                new double[] {CalculateWinPrecentage(aLWins), CalculateWinPrecentage(aRWins), aRoster, aRanking },
                new double[] {CalculateWinPrecentage(bLWins), CalculateWinPrecentage(bRWins), bRoster, bRanking },
            };

            int[] labels = { 1, 0 };

            var teacher = new SequentialMinimalOptimization<Gaussian>()
            {
                Complexity = 100,
                Kernel = new Gaussian()
            };

            var svm = teacher.Learn(inputs, labels);

            // Predict outcome for a match between Team A and Team B
            bool predictedWinner = svm.Decide(inputs[0]); // Predict for Team A

            // Display predicted winner
            string predictedWinnerName = predictedWinner ? teamAName : teamBName;
            //label1.Text = ("Predicted winner: " + predictedWinnerName);
        }

        static double CalculateWinPrecentage(int wins)
        {
            int totalMatches = 50;

            double winPrecentage = (double)wins / totalMatches * 100;

            return winPrecentage;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            teamA.Text = "Selected team: " + teamACombo.Text.ToString();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            teamB.Text = "Selected team: " + teamBCombo.Text.ToString();
        }

        private void generateButton_Click(object sender, EventArgs e)
        {

        }
    }
}