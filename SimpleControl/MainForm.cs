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
        private MovementDirection _movementDirection = MovementDirection.Stop;

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

        private void panel1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (_remoteControl == null)
            {
                return;
            }

            changeMovementDirectionOnKeyDown(e.KeyCode);
        }

        private void changeMovementDirectionOnKeyDown(Keys key)
        {
            try
            {
                switch (key)
                {
                    case Keys.Space:
                        changeMovementToStop();
                        break;
                    case Keys.Up:
                        changeMovementToForward();
                        break;
                    case Keys.Down:
                        changeMovementToBackward();
                        break;
                    case Keys.Left:
                        changeMovementToLeft();
                        break;
                    case Keys.Right:
                        changeMovementToRight();
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

        private void changeMovementToStop()
        {
            if (_movementDirection != MovementDirection.Stop)
            {
                _remoteControl.Stop();
                setEnabledIcon(IconOrder.Stop);
                _movementDirection = MovementDirection.Stop;
            }
        }

        private void changeMovementToForward()
        {
            if (_movementDirection != MovementDirection.Forward)
            {
                _remoteControl.Forward();
                setEnabledIcon(IconOrder.Up);
                _movementDirection = MovementDirection.Forward;
            }
        }

        private void changeMovementToBackward()
        {
            if (_movementDirection != MovementDirection.Backward)
            {
                _remoteControl.Backward();
                setEnabledIcon(IconOrder.Down);
                _movementDirection = MovementDirection.Backward;
            }
        }

        private void changeMovementToLeft()
        {
            if (_movementDirection != MovementDirection.Left)
            {
                _remoteControl.Left();
                setEnabledIcon(IconOrder.Left);
                _movementDirection = MovementDirection.Left;
            }
        }

        private void changeMovementToRight()
        {
            if (_movementDirection != MovementDirection.Right)
            {
                _remoteControl.Right();
                setEnabledIcon(IconOrder.Right);
                _movementDirection = MovementDirection.Right;
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

        private void MainForm_KeyUp(object sender, KeyEventArgs e)
        {
            changeMovementToStop();
        }
    }
}
