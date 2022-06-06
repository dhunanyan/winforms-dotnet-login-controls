using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomControls.Controls
{
    [DefaultEvent("_TextChanged")]
    public partial class CustomTextBoxPassword : UserControl
    {
        //Styles Fields
        private Color borderColor = Color.DodgerBlue;
        private int borderSize = 2;
        private bool underlinedStyle = false;

        public CustomTextBoxPassword()
        {
            InitializeComponent();
        }

        //Events
        public event EventHandler _TextChanged;

        //Styles Props
        [Category("CustomStyles")]
        public Color BorderColor
        {
            get
            {
                return borderColor;
            }
            set
            {
                borderColor = value;
                Invalidate();
            }
        }

        [Category("CustomStyles")]
        public int BorderSize
        {
            get
            {
                return borderSize;
            }
            set
            {
                borderSize = value;
                Invalidate();
            }
        }

        [Category("CustomStyles")]
        public bool UnderlinedStyle
        {
            get
            {
                return underlinedStyle;
            }
            set
            {
                underlinedStyle = value;
                this.Invalidate();
            }
        }

        [Category("CustomStyles")]
        public bool PasswordChar
        {
            get
            {
                return textBoxPassword.UseSystemPasswordChar;
            }
            set
            {
                textBoxPassword.UseSystemPasswordChar = value;
            }
        }

        [Category("CustomStyles")]
        public bool Multiline
        {
            get
            {
                return textBoxPassword.Multiline;
            }
            set
            {
                textBoxPassword.Multiline = value;
            }
        }

        [Category("CustomStyles")]
        public override Color ForeColor
        {
            get
            {
                return base.ForeColor;
            }
            set
            {
                base.ForeColor = value;
                textBoxPassword.ForeColor = value;
            }
        }

        [Category("CustomStyles")]
        public override Color BackColor
        {
            get
            {
                return base.BackColor;
            }
            set
            {
                base.BackColor = value;
                textBoxPassword.BackColor = value;
            }
        }

        [Category("CustomStyles")]
        public override Font Font
        {
            get
            {
                return base.Font;
            }
            set
            {
                base.Font = value;
                textBoxPassword.Font = value;
                if (DesignMode)
                {
                    UpdateControlHeight();
                }
            }
        }
        [Category("CustomStyles")]
        public string CustomText
        {
            get
            {
                return textBoxPassword.Text;
            }
            set
            {
                textBoxPassword.Text = value;
            }
        }

        //Validations Props
        [Category("CustomValidation")]
        public bool IsCharCountPassed { get; set; }
        [Category("CustomValidation")]
        public bool IsCharSpecialPassed { get; set; }
        [Category("CustomValidation")]
        public bool IsCharCapitalPassed { get; set; }
        [Category("CustomValidation")]
        public bool IsCharDigitPassed { get; set; }


        //Styles Overrired
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graph = e.Graphics;

            using(Pen penBorder = new Pen(borderColor, borderSize))
            {
                penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;

                if (underlinedStyle)
                {
                    graph.DrawLine(penBorder, 0, Height - 1, Width, Height - 1);
                }
                else
                {
                    graph.DrawRectangle(penBorder, 0, 0, Width - 0.5F, Height - 0.5F);
                }
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            UpdateControlHeight();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            UpdateControlHeight();
        }

        private void UpdateControlHeight()
        {
            if(textBoxPassword.Multiline == false)
            {
                int txtHeight = TextRenderer.MeasureText("Text", Font).Height + 1;
                textBoxPassword.Multiline = true;
                textBoxPassword.MinimumSize = new Size(0, txtHeight);
                textBoxPassword.Multiline = false;

                Height = textBoxPassword.Height + Padding.Top + Padding.Bottom;
            }
        }

        private void TextBoxPassword_TextChanged(object sender, EventArgs e)
        {
            SetIsCharCountPassed();
            SetIsCharCapitalPassed();
            SetIsCharDigitPassed();
            SetIsCharSpecialPassed();
            if (_TextChanged != null)
            {
                _TextChanged.Invoke(sender, e);
            }
        }

        private void SetIsCharCountPassed()
        {
            IsCharCountPassed = textBoxPassword.Text.Length > 7;
        }

        private void SetIsCharCapitalPassed()
        {
            IsCharCapitalPassed = textBoxPassword.Text.Any(char.IsUpper);
        }

        private void SetIsCharDigitPassed()
        {
            IsCharDigitPassed = textBoxPassword.Text.Any(char.IsDigit);
        }
        private void SetIsCharSpecialPassed()
        {
            IsCharSpecialPassed =
                textBoxPassword.Text.Contains('-') ||
                textBoxPassword.Text.Contains('_') ||
                textBoxPassword.Text.Contains('.') ||
                textBoxPassword.Text.Contains(',') ||
                textBoxPassword.Text.Contains('?') ||
                textBoxPassword.Text.Contains('!') ||
                textBoxPassword.Text.Contains('+') ||
                textBoxPassword.Text.Contains('#') ||
                textBoxPassword.Text.Contains('@') ||
                textBoxPassword.Text.Contains('$') ||
                textBoxPassword.Text.Contains('%') ||
                textBoxPassword.Text.Contains('^') ||
                textBoxPassword.Text.Contains('&') ||
                textBoxPassword.Text.Contains('(') ||
                textBoxPassword.Text.Contains(')') ||
                textBoxPassword.Text.Contains('/');
        }
    }
}
