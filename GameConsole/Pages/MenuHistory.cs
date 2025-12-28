using GameConsole.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole.Pages
{
    internal class MenuHistory:MenuScreen
    {
        public MenuHistory() : base("Game histroy sorting by:")
        {
            Add(new MenuItem("Game Name", new HistoryScreen("Game Name")));
            Add(new MenuItem("Overall Score", new HistoryScreen("Overall Score")));
            Add(new MenuItem("Date", new HistoryScreen("Date")));
        }
    }
}
