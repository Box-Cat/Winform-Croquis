using System.Windows.Forms;

namespace Croquis
{
    public partial class Form1 : Form
    {
        List<Bitmap> bitmapsList = new List<Bitmap>();
        int idx = 0;
        int hour = 0;
        int min = 0;
        int sec = 0;
        int tempHour = 0;
        int tempMin = 0;
        int tempSec = 0;
        bool sizeToggled = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            if (this.Width <= 300) this.Width = 300;
            if (this.Height <= 300) this.Height = 300;
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "( *.bmp; *.jpg; *.png; *.jpeg) | *.BMP; *.JPG; *.PNG; *.JPEG";
            open.Multiselect = true;
            if (open.ShowDialog() == DialogResult.OK && open.FileNames.Length > 0)
            {
                for (int i = 0; i < open.FileNames.Length; i++)
                {
                    bitmapsList.Add(new Bitmap(open.FileNames[i]));
                }
                picBox.Image = bitmapsList[bitmapsList.Count - 1];
            }
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            if (idx == 0)
            {
                idx = bitmapsList.Count - 1;
                picBox.Image = bitmapsList[idx];
            }
            else
            {
                picBox.Image = bitmapsList[--idx];
            }
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            if (idx == bitmapsList.Count - 1)
            {
                idx = 0;
                picBox.Image = bitmapsList[idx];
            }
            else
            {
                picBox.Image = bitmapsList[++idx];
            }
        }

        private void textBoxHour_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)
                || e.KeyChar == Convert.ToChar(Keys.Back)
                || e.KeyChar == Convert.ToChar(Keys.Delete)
                ))
            {
                e.Handled = true;
            }
            hour = int.Parse(textBoxHour.Text);
        }

        private void textBoxMin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)
                || e.KeyChar == Convert.ToChar(Keys.Back)
                || e.KeyChar == Convert.ToChar(Keys.Delete)
                ))
            {
                e.Handled = true;
            }
            min = int.Parse(textBoxMin.Text);
        }

        private void textBoxSec_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)
                || e.KeyChar == Convert.ToChar(Keys.Back)
                || e.KeyChar == Convert.ToChar(Keys.Delete)
                ))
            {
                e.Handled = true;
            }
            sec = int.Parse(textBoxSec.Text);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer.Enabled = true;
            timer.Start();
            // TryParse로 입력값을 안전하게 변환
            if (!int.TryParse(textBoxHour.Text, out hour)) hour = 0;
            if (!int.TryParse(textBoxMin.Text, out min)) min = 0;
            if (!int.TryParse(textBoxSec.Text, out sec)) sec = 0;
            tempHour = hour;
            tempMin = min;
            tempSec = sec;

            if (min >= 60 || sec >= 60)
            {
                MessageBox.Show("시간과 분은 60 이상일 수 없습니다.", "잘못된 입력", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            if (timer.Enabled == false)
            {
                timer.Enabled = true;
                timer.Start();
            }
            else
            {
                timer.Enabled = false;
                timer.Stop();
            }
        }


        private void btnStop_Click(object sender, EventArgs e)
        {
            hour = 0;
            min = 0;
            sec = 0;

            textBoxHour.Text = hour.ToString();
            textBoxMin.Text = min.ToString();
            textBoxSec.Text = sec.ToString();

            timer.Stop();
            timer.Enabled = false;
        }


        private void timer_Tick(object sender, EventArgs e)
        {
            if (hour == 0 && min == 0 && sec == 0)
            {
                if (idx == bitmapsList.Count - 1)
                {
                    idx = 0;
                    picBox.Image = bitmapsList[idx];
                }
                else
                {
                    idx++;
                    picBox.Image = bitmapsList[idx];
                }
                hour = tempHour;
                min = tempMin;
                sec = tempSec;
                textBoxHour.Text = hour.ToString();
                textBoxMin.Text = min.ToString();
                textBoxSec.Text = sec.ToString();

            }
            else if (sec == 0)
            {
                if (hour != 0 && min == 0)
                {
                    hour--;
                    min = 59;
                }
                else
                {
                    min--;
                }
                sec = 59;
            }
            else 
            {
                sec--;
            }

            textBoxHour.Text = hour.ToString();
            textBoxMin.Text = min.ToString();
            textBoxSec.Text = sec.ToString();
        }

        private void checkBoxSize_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSize.Checked)
            {
                picBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                picBox.SizeMode = PictureBoxSizeMode.Normal;
            }
        }
    }
}
