using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        String location;
        Form1 form1;
        string[] songData;
        public Form2(Form1 f1, string[] sd)
        {
            songData = sd;
            InitializeComponent();
            Title_textBox.Text = songData[0];
            Artist_textBox.Text = songData[1];
            Album_textBox.Text = songData[2];
            Genre_textBox.Text = songData[3];
            Track_textBox.Text = songData[4];
            Year_textBox.Text = songData[5];
            location = songData[6];
            form1 = f1;
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            fileLookup.editMeta(form1, this, songData);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
