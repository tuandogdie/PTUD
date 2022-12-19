﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjQuanLyLuongSanPham.Controls
{
    [DefaultEvent("_TextChanged")]
    public partial class TextBox : UserControl
    {
        public TextBox()
        {
            InitializeComponent();
        }
        // Events
        public event EventHandler _TextChanged;

        private Color borderColor = Color.MediumSlateBlue;
        private int borderSize = 2;
        private bool underlinedStyle = false;

        [Category("Advance")]
        public Color BorderColor
        {
            get
            {
                return borderColor;
            }

            set
            {
                borderColor = value;
                this.Invalidate();
            }
        }

        [Category("Advance")]
        public int BorderSize
        {
            get
            {
                return borderSize;
            }

            set
            {
                borderSize = value;
                this.Invalidate();
            }
        }

        [Category("Advance")]
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

        [Category("Advance")]
        public bool Multiline
        {
            get { return textbox1.Multiline; }
            set { textbox1.Multiline = value; }
        }

        [Category("Advance")]
        public override string Text
        {
            get
            {
                return textbox1.Text;
            }

            set
            {
                textbox1.Text = value;
            }
        }

        public bool UseSystemPasswordChar { get; internal set; }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graph = e.Graphics;
            using (Pen penBorder = new Pen(BorderColor, BorderSize))
            {
                penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;
                if (underlinedStyle)
                    graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                else
                    graph.DrawRectangle(penBorder, 0, 0, this.Width - 0.5F, this.Height - 0.5F);

            }

        }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if(this.DesignMode)
            UpdateControlHeight();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            UpdateControlHeight();
        }
        private void UpdateControlHeight()
        {
            if(textbox1.Multiline == false)
            {
                int txtHeight = TextRenderer.MeasureText("Text", this.Font).Height + 1;
                textbox1.Multiline = true;
                textbox1.MinimumSize = new Size(0, txtHeight);
                textbox1.Multiline = false;

                this.Height = textbox1.Height + this.Padding.Top + this.Padding.Bottom;
            }
        }

        private void textbox1_TextChanged(object sender, EventArgs e)
        {
            if (_TextChanged != null)
                _TextChanged.Invoke(sender, e);
        }
    }
}
