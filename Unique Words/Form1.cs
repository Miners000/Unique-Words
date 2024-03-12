using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unique_Words
{
    public partial class Form1 : Form
    {

        List<string> AllWords = new List<string>()
        {
            "Farm", "Hill", "Antidisestablishmentarianism", "Defenestration",
            "Complex", "Hill", "Knowledge", "Construct", "Constructing",
            "Figure", "Glass", "Constuct", "Chess", "Piece", "Complex",
            "Couple", "Drink", "Sleep", "Master", "Testing", "Memory",
            "Chess", "New", "Among", "Us", "Myself", "Tiger", "Hill",
            "Now", "Current", "Currently", "Apology", "Game", "System",
            "Wikipedia", "Visual", "Defense", "People", "Intelligence",
            "Agency", "Spy", "Cellphone", "Bush", "Did", "It", "Global",
            "Conquer", "Seize", "Rocket", "League", "Photo", "Sport"
        };

        public Form1()
        {
            InitializeComponent();
        }

        private void uniqueWordButton_Click(object sender, EventArgs e)
        {
            var UniqueWords = AllWords.Distinct();

            foreach (string word in UniqueWords)
            {
                afterListBox.Items.Add(word);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach(string word in AllWords)
            {
                initialListBox.Items.Add(word);
            }
        }
    }
}
