using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rmbh_backoffice.VC
{
    public interface IView
    {
        string Title { get; set; }

        Form Form { get; }

        void Close();
    }
}
