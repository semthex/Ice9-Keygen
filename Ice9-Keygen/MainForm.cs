using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using SharpMik;
using SharpMik.Drivers;
using SharpMik.Player;

namespace Ice9_Keygen
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private bool isMoving = false;
        private Point offset;

        private int currentTrackIndex = 0;

        Module m_Mod;
        MikMod m_Player;

        private void MainForm_Load(object sender, EventArgs e)
        {
            m_Player = new MikMod();

            m_Player.PlayerStateChangeEvent += new ModPlayer.PlayerStateChangedEvent(m_Player_PlayerStateChangeEvent);

            ModDriver.Mode = (ushort)(ModDriver.Mode | SharpMikCommon.DMODE_NOISEREDUCTION);
            m_Player.Init<NaudioDriver>("");

            m_Mod = m_Player.LoadModule(GetNextTrack());

            if (m_Mod != null)
            {
                m_Player.Play(m_Mod);
            }
        }

        private readonly List<MemoryStream> tracks = new List<MemoryStream>
        {
            new MemoryStream(Ice9_Keygen.XmAudioResource.sleepy_sunflower),
            new MemoryStream(Ice9_Keygen.XmAudioResource.unreeeal_superhero_3),
            new MemoryStream(Ice9_Keygen.XmAudioResource.Valium_candies),
            new MemoryStream(Ice9_Keygen.XmAudioResource.orion_spaceforce23),
        };

        private MemoryStream GetNextTrack()
        {
            currentTrackIndex = (currentTrackIndex + 1) % tracks.Count;
            return tracks[currentTrackIndex];
        }

        private void m_Player_PlayerStateChangeEvent(ModPlayer.PlayerState state)
        {
            int place = (int)(100.0f * m_Player.GetProgress());

            if (place == 99)
            {
                m_Player.UnLoadModule(m_Mod);

                m_Mod = m_Player.LoadModule(GetNextTrack());

                if (m_Mod != null)
                {
                    m_Player.SetPosition(0);
                    m_Player.Play(m_Mod);
                }
            }
        }

        private void chkMusic_CheckedChanged(object sender, EventArgs e)
        {
            if (m_Player.IsPlaying())
            {
                ModPlayer.Player_TogglePause();
            }
        }

        private void MoveWindow(MouseEventArgs e)
        {
            if (isMoving)
            {
                Point newLocation = this.PointToScreen(new Point(e.X, e.Y));
                newLocation.Offset(-offset.X, -offset.Y);
                this.Location = newLocation;
            }
        }

        private string GenerateSerial(string name)
        {
            string serial = "";
            int modifier = 0;

            for (int i = 0; i < name.Length - 1; i++)
            {
                if (name[i] <= 0x5A && name[i] >= 0x41)
                {
                    modifier += (name[i] + 0x2C);
                }
                else
                {
                    modifier += name[i];
                }
            }

            modifier += 0x29A;
            modifier *= 0x3039;
            modifier -= 0x17;
            modifier *= 0x9;

            do
            {
                int remainder = modifier % 0xA;
                modifier /= 0xA;
                remainder += 0x30;
                serial = (char)remainder + serial;

            } while (modifier != 0);


            for (int i = 3; i < name.Length; i++)
            {
                serial += name[i];
            }

            return serial;
        }

        private void llbGitHub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/JulianOzelRose");
        }

        private void pnlTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            isMoving = true;
            offset = new Point(e.X, e.Y);
        }

        private void pnlTitleBar_MouseMove(object sender, MouseEventArgs e)
        {
            MoveWindow(e);
        }

        private void pnlTitleBar_MouseUp(object sender, MouseEventArgs e)
        {
            if (isMoving)
            {
                isMoving = false;
            }
        }

        private void picKeygenArt_MouseDown(object sender, MouseEventArgs e)
        {
            isMoving = true;
            offset = new Point(e.X, e.Y);
        }

        private void picKeygenArt_MouseMove(object sender, MouseEventArgs e)
        {
            MoveWindow(e);
        }

        private void picKeygenArt_MouseUp(object sender, MouseEventArgs e)
        {
            if (isMoving)
            {
                isMoving = false;
            }
        }

        private void txtTitle_MouseDown(object sender, MouseEventArgs e)
        {
            isMoving = true;
            offset = new Point(e.X, e.Y);
        }

        private void txtTitle_MouseMove(object sender, MouseEventArgs e)
        {
            MoveWindow(e);
        }

        private void txtTitle_MouseUp(object sender, MouseEventArgs e)
        {
            if (isMoving)
            {
                isMoving = false;
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;

            if (name.Length < 4 || name.Length > 10)
            {
                txtSerial.Clear();

                ErrorForm errorForm = new ErrorForm(name.Length);
                errorForm.ShowDialog();
            }
            else
            {
                string serial = GenerateSerial(name);
                txtSerial.Text = serial;
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSerial.Text))
            {
                Clipboard.SetText(txtSerial.Text);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}