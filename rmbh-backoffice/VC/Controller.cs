using rmbh_backoffice.VC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rmbh_backoffice.VC
{
    public abstract class Controller
    {
        public abstract IView View { get; }

        public event EventHandler LoadSuccess, LoadFailed;

        public Controller()
        {
            LoadSuccess += OnLoadSucceededHandler;
            LoadFailed += OnLoadFailedHandler;
        }

        public abstract bool Loadable();

        public virtual void OnLoadSucceededHandler(Object sender, EventArgs e)
        {
            AppManager.Instance.Show(this);
        }

        public virtual void OnLoadFailedHandler(Object sender, EventArgs e)
        {
            if (MessageBox.Show("You don't have access to load this page.\nThe application will exit now.") == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        public void OnLoadSuccess(EventArgs e)
        {
            if (LoadSuccess != null)
                LoadSuccess(this, e);
        }

        public void OnLoadFailure(EventArgs e)
        {
            if (LoadFailed != null)
                LoadFailed(this, e);
        }
    }
}
