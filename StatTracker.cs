using Rocket.Core.Logging;
using Rocket.Core.Plugins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatTracker
{
    public class StatTracker : RocketPlugin
    {
        public static StatTracker Instance;

        protected override void Load()
        {
            DatabaseMgr.Instance.InfoTesting();
        }

        protected override void Unload()
        {
           
        }

        public void FixedUpdate()
        {

        }
    }
}
