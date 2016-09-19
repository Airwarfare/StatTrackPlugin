using Rocket.API;
using Rocket.Core.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatTracker
{
    class StatTrackerCommand : IRocketCommand
    {
        public List<string> Aliases
        {
            get
            {
                return new List<string>();
            }
        }

        public AllowedCaller AllowedCaller
        {
            get
            {
                return AllowedCaller.Player;
            }
        }

        public string Help
        {
            get
            {
                return "duh";
            }
        }

        public string Name
        {
            get
            {
                return "data";
           }
        }

        public List<string> Permissions
        {
            get
            {
                return new List<string>();
            }
        }

        public string Syntax
        {
            get
            {
                return "lol";
            }
        }

        public void Execute(IRocketPlayer caller, string[] command)
        {
            Logger.Log("1");
            DatabaseMgr.Instance.InfoTesting();
        }
    }
}
