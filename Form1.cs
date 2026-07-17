using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Color_Picker_Project
{
    public partial class frmColorPicker : Form
    {
        byte BlueGrade = 0, GreenGrade = 0, RedGrade = 0;
        Random randomRGB = new Random();

        public async void PlayOkSound()
        {
            SoundPlayer Ok = new SoundPlayer(Properties.Resources.OK_FINAL_SOUND);
            Ok.Play();

            await Task.Delay(500);
        }

        private void GetRandomlyRGBValues()
        {

            tbRed.Value = randomRGB.Next(0, 255);
            tbGreen.Value = randomRGB.Next(0, 255);
            tbBlue.Value = randomRGB.Next(0, 255);
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            PlayOkSound();

            GetRandomlyRGBValues();

            ChangeValuesAndColor();

        }

        public frmColorPicker()
        {
            InitializeComponent();
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            PlayOkSound();
            Clipboard.SetText(btnHex.Text);
        }

        public void ChangeValuesAndColor()
        {
            lbRed.Text = tbRed.Value.ToString();
            RedGrade = Convert.ToByte(tbRed.Value);

            lbGreen.Text = tbGreen.Value.ToString();
            GreenGrade = Convert.ToByte(tbGreen.Value);

            lbBlue.Text = tbBlue.Value.ToString();
            BlueGrade = Convert.ToByte(tbBlue.Value);

            btnColor.BackColor = Color.FromArgb(RedGrade, GreenGrade, BlueGrade);

            string Hex = $"#{RedGrade:X2}{GreenGrade:X2}{BlueGrade:X2}";

            btnHex.Text = Hex;
        }

        private void tb_Scroll(object sender, EventArgs e)
        {
            ChangeValuesAndColor();
        }
    }
}
