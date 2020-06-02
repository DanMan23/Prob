using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvControls
{
    public partial class AdvComboBox : System.Windows.Forms.ComboBox
    {
        private string _NullText;

        /// <summary>
        /// Задает текст, который отображается как подсказка, ести поле Text пустое.
        /// </summary>
        public string NullText
        {
            get
            {
                return _NullText;
            }
            set
            {
                _NullText = value;

                if (Text == null || Text == _NullText || Text == "")
                {
                    Text = _NullText;
                    ForeColor = System.Drawing.Color.Gray;
                }
                else ForeColor = System.Drawing.Color.Black;
            }
        }

        /// <summary>
        /// Признак того, что поле Text не заполнено значением. (Значение == тексту подсказки)
        /// </summary>
        public bool IsNull
        {
            get { return Text == _NullText; }
        }

        public AdvComboBox()
        {
            InitializeComponent();
        }

        public AdvComboBox(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        protected override void OnEnter(EventArgs e)
        {
            base.OnEnter(e);

            if (Text == _NullText)
            {
                Text = "";
                ForeColor = System.Drawing.Color.Gray;
            }
            else ForeColor = System.Drawing.Color.Black;
        }

        protected override void OnLeave(EventArgs e)
        {
            base.OnLeave(e);

            if (Text == null || Text == _NullText || Text == "")
            {
                Text = _NullText;
                ForeColor = System.Drawing.Color.Gray;
            }
            else ForeColor = System.Drawing.Color.Black;
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            if (Text == null || Text == _NullText)
            {
                Text = _NullText;
                ForeColor = System.Drawing.Color.Gray;
            }
            else ForeColor = System.Drawing.Color.Black;

        }
    }
}
