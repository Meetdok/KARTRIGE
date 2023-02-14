using KARTRIGE.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;


namespace KARTRIGE.ViewModels
{
    public class MainVM : BaseTools
    {
        CurrentPageControl currentPageControl;


        public Page CurrentPage
        {
            get => currentPageControl.Page;
        }

        public MainVM()
        {
            currentPageControl = new CurrentPageControl();
            currentPageControl.PageChanged += CurrentPageControl_PageChanged;

        }

        private void CurrentPageControl_PageChanged(object sender, EventArgs e)
        {
            Signal(nameof(CurrentPage));
        }
    }
}
