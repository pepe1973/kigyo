using System;
using System.Windows.Forms;
using System.IO;

namespace SnakeTester
{
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
        }

        private void TestForm_Load(object sender, EventArgs e)
        {
            // 1. Add your SnakeBrainBase implementation project as reference to this project.
            // 2. Create an instance of your brain implementation:
            var mySnakeBrainOne = new TemplateBrain.TemplateBrain();
            var mySnakeBrainTwo = new TemplateBrain.TemplateBrain();
            // 3. Use the following methods to specify the brains:
            snakeTesterPanel.SetBrain1(mySnakeBrainOne);
            snakeTesterPanel.SetBrain2(mySnakeBrainTwo);
            // Note: if you don't specify any brain, the SnakeLib.Brains.SimpleSnakeBrain will be used.
            // This one just goes ahead and goes around anything in the arena.
            // 4. Specify a different arena file if you want like this:
            Directory.SetCurrentDirectory(@"..\..\..\..");
            snakeTesterPanel.SetFieldPlan(Directory.GetCurrentDirectory() + @"\arena\Simpler.arena");
            // 5. Have fun!
        }
    }
}
