using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace TradePanel
{

    public partial class TradePanelForm : Form
    {
        private const int CP_NOCLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }

        public TradePanelForm()
        {
            InitializeComponent();
        }
    }
}
