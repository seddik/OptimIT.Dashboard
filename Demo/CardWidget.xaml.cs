
using OptimIT.Dashboard;
using System;
using System.Windows.Navigation;

namespace Widgets
{

    public partial class CardWidget
    {

        public CardWidget()
        {
            InitializeComponent();
        }

    }
    public partial class CardWidgetVM : WidgetBase
    {
        public CardWidgetVM() : base(WidgetSize.OneByOne)
        {

        }
        public override string WidgetTitle { get => "Card Title " + DateTime.Now.ToString(); set => new Action(() => { })(); }
    }

}