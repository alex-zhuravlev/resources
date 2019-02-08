using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resources
{
    public class ResourceForm: Form
    {
        protected const int DATA_PREVIEW_SIZE = 1024;

        public ResourceBlock ResourceBlock { get; set; } = null;
        public Resources.OnChildFormClosed OnClose { get; set; } = null;
    }
}
