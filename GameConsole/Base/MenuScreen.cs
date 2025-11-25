using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole.Base
{
	internal class MenuScreen : Screen
	{
		private List<MenuItem> items;
		public MenuScreen(string title) : base(title)
		{
			items=new List<MenuItem>();
		}
		public void Add(MenuItem item)
		{
			if(item!!=null)
			items.Add(item);
		}
		public void Add(string displayName, Screen sc)
		{
			items.Add(new MenuItem(displayName, sc));
		}
	}
}
