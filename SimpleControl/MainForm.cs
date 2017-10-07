using SimpleControl.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleControl
{
    public partial class MainForm : Form
    {
        private IRemoteControl _remoteControl;
        private Image[] disabledImages = new Image[5];
        private Image[] enabledImages = new Image[5];

        public MainForm()
        {
            InitializeComponent();
            InitializeIcons();
        }

        private void InitializeIcons()
        {
            enabledImages[(int)IconOrder.Stop] = Image.FromFile(@"icons\if_6_-_Cross_1815573.png");
            enabledImages[(int)IconOrder.Up] = Image.FromFile(@"icons\if_1_-_Up_1815558.png");
            enabledImages[(int)IconOrder.Down] = Image.FromFile(@"icons\if_2_-_Down_1815568.png");
            enabledImages[(int)IconOrder.Left] = Image.FromFile(@"icons\if_4_-_Left_1815571.png");
            enabledImages[(int)IconOrder.Right] = Image.FromFile(@"icons\if_3_-_Right_1815570.png");
            
            for(int i=0; i < 5; i++)
            {
                disabledImages[i] = ToolStripRenderer.CreateDisabledImage(enabledImages[i]);
            }

            setIconsDisabled();
        }

        private void setIconsDisabled()
        {
            IconStop.Image = ToolStripRenderer.CreateDisabledImage(disabledImages[(int)IconOrder.Stop]);
            IconUp.Image = ToolStripRenderer.CreateDisabledImage(disabledImages[(int)IconOrder.Up]);
            IconDown.Image = ToolStripRenderer.CreateDisabledImage(disabledImages[(int)IconOrder.Down]);
            IconLeft.Image = ToolStripRenderer.CreateDisabledImage(disabledImages[(int)IconOrder.Left]);
            IconRight.Image = ToolStripRenderer.CreateDisabledImage(disabledImages[(int)IconOrder.Right]);
        }

        private void setEnabledIcon(IconOrder icon)
        {
            setIconsDisabled();
            switch(icon)
            {
                case IconOrder.Stop:
                    IconStop.Image = enabledImages[(int)IconOrder.Stop];
                    break;
                case IconOrder.Up:
                    IconUp.Image = enabledImages[(int)IconOrder.Up];
                    break;
                case IconOrder.Down:
                    IconDown.Image = enabledImages[(int)IconOrder.Down];
                    break;
                case IconOrder.Left:
                    IconLeft.Image = enabledImages[(int)IconOrder.Left];
                    break;
                case IconOrder.Right:
                    IconRight.Image = enabledImages[(int)IconOrder.Right];
                    break;
            }

        }

        private void setInputsState(bool enabled)
        {
            IpAddressTextBox.Enabled = enabled;
            PortNumberTextBox.Enabled = enabled;
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            Debug.WriteLine("Main from KeyDown event!");
            if (_remoteControl == null)
            {
                return;
            }

            //sendControllCommand(e.KeyCode);
            
        }

        private void sendControllCommand(Keys key)
        {
            try
            {
                switch (key)
                {
                    case Keys.Space:
                        _remoteControl.Stop();
                        setEnabledIcon(IconOrder.Stop);
                        break;
                    case Keys.Up:
                        _remoteControl.Forward();
                        setEnabledIcon(IconOrder.Up);
                        break;
                    case Keys.Down:
                        _remoteControl.Backward();
                        setEnabledIcon(IconOrder.Down);
                        break;
                    case Keys.Left:
                        _remoteControl.Left();
                        setEnabledIcon(IconOrder.Left);
                        break;
                    case Keys.Right:
                        _remoteControl.Right();
                        setEnabledIcon(IconOrder.Right);
                        break;
                }
            }
            catch (RemoteControlException rcError)
            {
                _remoteControl.Dispose();
                ConnectButton.Text = "Connect";
                setIconsDisabled();
                setInputsState(true);
                MessageBox.Show($"Błąd połączenia: {rcError.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_remoteControl != null)
                _remoteControl.Dispose();
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            if (ConnectButton.Text == "Connect")
            {
                try
                {
                    _remoteControl = new RemoteControl(IpAddressTextBox.Text, Int32.Parse(PortNumberTextBox.Text));
                    ConnectButton.Text = "Disconnect";
                    setInputsState(false);
                    tableLayoutPanel1.Focus();
                }
                catch(Exception err)
                {
                    MessageBox.Show($"Błąd połączenia: {err.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ConnectButton.Text = "Connect";
                    setInputsState(true);
                }
                
            }
            else
            {
                _remoteControl.Dispose();
                ConnectButton.Text = "Connect";
                setInputsState(true);
            }
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void panel1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (_remoteControl == null)
            {
                return;
            }

            sendControllCommand(e.KeyCode);
        }
    }
}
