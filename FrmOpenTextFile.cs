using System.IO;

namespace ReadingFile
{
    public partial class btnCreate : Form
    {
        public btnCreate()
        {
            InitializeComponent();
        }

        private void DisplayList()
        {
            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.Title = "Browse Text Files";
            openFileDialog1.DefaultExt = "txt";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.ShowDialog();
            var path = openFileDialog1.FileName;

            lvShowText.View = View.Details;
            lvShowText.Columns.Clear();
            lvShowText.Columns.Add("Text");

            using (StreamReader streamReader = File.OpenText(path))
            {
                string _getText = "";
                while ((_getText = streamReader.ReadLine()) != null)
                {
                    Console.WriteLine(_getText);
                    lvShowText.Items.Add(_getText);
                }

                lvShowText.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);

            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            DisplayList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FrmRegistration().Show();
        }
    }
}
