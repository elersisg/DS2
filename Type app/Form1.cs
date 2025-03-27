namespace Type_app
{
    public partial class Form1 : Form
    {
        
        private bool isCapsLockOn = false;
        private bool isCtrlPressed = false;
        private bool isShiftPressed = false;
        private bool isAltPressed = false;
        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        private void button23_Click(object sender, EventArgs e)
        {

        }

        private void btnenter_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Focus();

            //Se le asigna a cada boton su letra 

            btnA.Tag = "a";
            btnB.Tag = "b";
            btnC.Tag = "c";
            btnD.Tag = "d";
            btnE.Tag = "e";
            btnF.Tag = "f";
            btnG.Tag = "g";
            btnH.Tag = "h";
            btnI.Tag = "i";
            btnJ.Tag = "j";
            btnK.Tag = "k";
            btnL.Tag = "l";
            btnM.Tag = "m";
            btnN.Tag = "n";
            btnO.Tag = "o";
            btnP.Tag = "p";
            btnQ.Tag = "q";
            btnR.Tag = "r";
            btnS.Tag = "s";
            btnT.Tag = "t";
            btnU.Tag = "u";
            btnV.Tag = "v";
            btnW.Tag = "w";
            btnX.Tag = "x";
            btnY.Tag = "y";
            btnZ.Tag = "z";

            btn1.Tag = "1";
            btn2.Tag = "2";
            btn3.Tag = "3";
            btn4.Tag = "4";
            btn5.Tag = "5";
            btn6.Tag = "6";
            btn7.Tag = "7";
            btn8.Tag = "8";
            btn9.Tag = "9";
            btn0.Tag = "0";

            btnapostrofemayor.Tag = "`";
            btnguion.Tag = "-";
            btnigual.Tag = "=";
            btnapostrofe.Tag = "'";
            btnleftslash.Tag = "/";
            btnpuntocoma.Tag = ";";
            btnrightslash.Tag = "\\";
            btnkeyIn.Tag = "[";
            btnkeyOut.Tag = "]";
            btncomma.Tag = ",";
            btndot.Tag = ".";

            btnUp.Tag = "up";
            btndown.Tag = "down";
            btnizquierda.Tag = "left";
            btnderecha.Tag = "right";
            btnShift.Tag = "Shift";
            btnControl.Tag = "Ctrl";
            btnAlt.Tag = "Alt";
            btnenter.Tag = "Enter";
            btntab.Tag = "Tab";

            textBox1.KeyPress += textBox1_KeyPress;
            textBox1.KeyUp += textBox1_KeyUp;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void TextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            var buttons = this.Controls.OfType<Button>();

            // Resetea el color de los botones
            foreach (var button in buttons)
            {
                button.BackColor = Color.FromKnownColor(KnownColor.Control);
            }

            if (e.KeyCode == Keys.ControlKey && isCtrlPressed)
            {
                btnControl.BackColor = Color.LightGreen;
            }
            if (e.KeyCode == Keys.ShiftKey && isShiftPressed)
            {
                btnShift.BackColor = Color.LightGreen;
            }
            if (e.KeyCode == Keys.Alt && isAltPressed)
            {
                btnAlt.BackColor = Color.LightGreen;
            }
            if (e.KeyCode == Keys.Enter)
            {
                btnenter.BackColor = Color.LightGreen;
            }
            if (e.KeyCode == Keys.CapsLock)
            {
                btnCapsLock.BackColor = Color.LightGreen;
            }

        }

        private void clearTextboxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void invertColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Color tempColor = textBox1.ForeColor;
            textBox1.ForeColor = textBox1.BackColor;
            textBox1.BackColor = tempColor;
        }

        private void textToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                textBox1.ForeColor = colorDialog.Color;
            }
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                textBox1.Font = fontDialog.Font;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char keyChar = e.KeyChar;

            //Caps Lock
            if (isCapsLockOn && Char.IsLetter(keyChar))
            {
                keyChar = Char.IsUpper(keyChar) ? Char.ToLower(keyChar) : Char.ToUpper(keyChar);
            }

            var buttons = this.Controls.OfType<Button>();
            var keyPressedButton = (from button in buttons
                                    where button.Tag != null && button.Tag.ToString().ToLower() == keyChar.ToString().ToLower()
                                    select button).FirstOrDefault();

            if (keyPressedButton != null)
            {
                keyPressedButton.BackColor = Color.LightGreen;
            }

        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            var buttons = this.Controls.OfType<Button>();

            // Resetea el color de los botones
            foreach (var button in buttons)
            {
                button.BackColor = Color.FromKnownColor(KnownColor.Control);
            }

            if (e.KeyCode == Keys.ControlKey && isCtrlPressed)
            {
                btnControl.BackColor = Color.LightGreen;
            }
            if (e.KeyCode == Keys.ShiftKey && isShiftPressed)
            {
                btnShift.BackColor = Color.LightGreen;
            }
            if (e.KeyCode == Keys.Alt && isAltPressed)
            {
                btnAlt.BackColor = Color.LightGreen;
            }
            if (e.KeyCode == Keys.Enter)
            {
                btnenter.BackColor = Color.LightGreen;
            }
            if (e.KeyCode == Keys.CapsLock)
            {
                btnCapsLock.BackColor = Color.LightGreen;
            }

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {

            var buttons = this.Controls.OfType<Button>();

            // Resetea el color de los botones
            foreach (var button in buttons)
            {
                button.BackColor = Color.FromKnownColor(KnownColor.Control);
            }

            //Teclas especiales
            if (e.Control)
            {
                btnControl.BackColor = Color.LightGreen;
                isCtrlPressed = true;
            }
            else
            {
                isCtrlPressed = false;
            }

            if (e.Shift)
            {
                btnShift.BackColor = Color.LightGreen;
                isShiftPressed = true;
            }
            else
            {
                isShiftPressed = false;
            }

            if (e.Alt)
            {
                btnAlt.BackColor = Color.LightGreen;
                isAltPressed = true;
            }
            else
            {
                isAltPressed = false;
            }

            if (e.KeyCode == Keys.Enter)
            {
                btnenter.BackColor = Color.LightGreen;
            }
            if (e.KeyCode == Keys.CapsLock)
            {
                btnCapsLock.BackColor = Color.LightGreen;
            }

            // Flechitas
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down || e.KeyCode == Keys.Left || e.KeyCode == Keys.Right)
            {
                var specialKeyButton = (from button in buttons
                                        where button.Tag != null && button.Tag.ToString() == e.KeyCode.ToString()
                                        select button).FirstOrDefault();

                if (specialKeyButton != null)
                {
                    specialKeyButton.BackColor = Color.LightGreen;
                }
            }

            // Teclas de función (F1-F12)
            if (e.KeyCode >= Keys.F1 && e.KeyCode <= Keys.F12)
            {
                var functionKeyButton = (from button in buttons
                                         where button.Text == e.KeyCode.ToString()
                                         select button).FirstOrDefault();

                if (functionKeyButton != null)
                {
                    functionKeyButton.BackColor = Color.LightGreen;
                }
            }
        }

        private void textBox1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            var buttons = this.Controls.OfType<Button>();

            // Reseteamos el color de todos los botones
            foreach (var button in buttons)
            {
                button.BackColor = Color.FromKnownColor(KnownColor.Control);
            }

            if (e.Control)
            {
                btnControl.BackColor = Color.LightGreen;
                isCtrlPressed = true;
            }
            else
            {
                isCtrlPressed = false;
            }

            if (e.Shift)
            {
                btnShift.BackColor = Color.LightGreen;
                isShiftPressed = true;
            }
            else
            {
                isShiftPressed = false;
            }

            if (e.Alt)
            {
                btnAlt.BackColor = Color.LightGreen;
                isAltPressed = true;
            }
            else
            {
                isAltPressed = false;
            }

            if (e.KeyCode == Keys.Enter)
            {
                btnenter.BackColor = Color.LightGreen;
            }
            if (e.KeyCode == Keys.CapsLock)
            {
                btnCapsLock.BackColor = Color.LightGreen;
            }

            // Teclas de función (F1-F12)
            if (e.KeyCode >= Keys.F1 && e.KeyCode <= Keys.F12)
            {
                var functionKeyButton = (from button in buttons
                                         where button.Text == e.KeyCode.ToString()
                                         select button).FirstOrDefault();

                if (functionKeyButton != null)
                {
                    functionKeyButton.BackColor = Color.LightGreen;
                }
            }

            // Tecla "Tab"
            if (e.KeyCode == Keys.Tab)
            {
                var tabButton = buttons.FirstOrDefault(button => button.Text == "Tab");

                if (tabButton != null)
                {
                    tabButton.BackColor = Color.LightGreen;
                }
            }
        }
    }
}