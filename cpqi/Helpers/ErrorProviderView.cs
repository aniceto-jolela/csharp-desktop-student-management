using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cpqi.Helpers
{
    public static class ErrorProviderView
    {
        public static bool SetError(Control control, string message, ErrorProvider errorProvider)
        {
            errorProvider.SetError(control, message);
            return false;
        }
    }
}
