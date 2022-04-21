using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Using_LINQ
{
	internal class Fruit
	{
		private string name;
		private int id;
		public Fruit(string name, int id)
		{
			this.name = name;
			this.id = id;
		}
		public string Name
		{
			get { return name; }
			set { name = value; }
		}
		public int ID
		{
			get { return id; }
			set { id = value; }
		}
	}
}
