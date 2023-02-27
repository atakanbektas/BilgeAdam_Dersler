using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormOyunDers
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        int winCount = 0;


        private void Anasayfa_KeyDown(object sender, KeyEventArgs e)
        {
            Keys key = e.KeyCode;
            switch (key)
            {
                case Keys.Up:
                    YukariCik();
                    break;
                case Keys.Down:
                    AsagiIn();
                    break;
                case Keys.Left:
                    SolaGit();
                    break;
                case Keys.Right:
                    SagaGit();
                    break;
            }
            OyunBittiMi();
        }

        private void OyunBittiMi()
        {
            bool kazandiMi = pnlBox.Bounds.IntersectsWith(lblFinish.Bounds);
            bool kaybettiMi = pnlBox.Bounds.IntersectsWith(lblWall1.Bounds) || pnlBox.Bounds.IntersectsWith(lblWall2.Bounds) || pnlBox.Bounds.IntersectsWith(lblWall3.Bounds) || pnlBox.Bounds.IntersectsWith(lblWall4.Bounds) || pnlBox.Bounds.IntersectsWith(lblWall5.Bounds) || pnlBox.Bounds.IntersectsWith(lblWall6.Bounds) || pnlBox.Bounds.IntersectsWith(lblWall7.Bounds);
            if (kazandiMi)
            {
                lblWin.Text = (++winCount).ToString();
                DialogResult dr = new DialogResult();
                dr = MessageBox.Show(" Tekrar oynamak ister misiniz? ","KAZANDINIZ!",MessageBoxButtons.YesNo);
                if (dr==DialogResult.Yes)
                {
                    pnlBox.Location = new Point(138, 398);
                }
                else
                {
                    Application.Exit();
                }                
            }
            else if (kaybettiMi)
            {
                lblWin.Text = (--winCount).ToString();

                DialogResult dr = new DialogResult();
                dr = MessageBox.Show(" Tekrar oynamak ister misiniz? ", "KAYBETTİNİZ!", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    pnlBox.Location = new Point(138, 398);
                }
                else
                {
                    Application.Exit();
                }
            }
            lblWin.ForeColor = winCount >= 0 ? Color.Green : Color.Red;

        }

        private void SagaGit()
        {
            pnlBox.Left += 10;
        }

        private void SolaGit()
        {
            pnlBox.Left -= 10;
        }

        private void AsagiIn()
        {
            pnlBox.Top += 10;
        }

        private void YukariCik()
        {
            pnlBox.Top -= 10;
        }

        private void lblFinish_Click(object sender, EventArgs e)
        {

        }
    }
}
