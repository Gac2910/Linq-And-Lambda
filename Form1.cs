using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Using_LINQ
{
	public partial class Using_LINQ : Form
	{
		public Using_LINQ()
		{
			InitializeComponent();
		}

		// list of all fruits in application
		private List<Fruit> fruitList = new List<Fruit> { };

		// initialize fruits
		private void Using_LINQ_Load(object sender, EventArgs e) => Display_All_Fruits();
		private void Display_All_Fruits()
		{
			string[] fruitNames = new string[] { "Apple", "Banana", "Cantaloupe", "Cherry", "Lemon", "Peach", "Plantain", "Apricot", "Grape", "Pineapple", "Tangarine", "Mango", "Guava", "Orange", "Grapefruit", "Watermelon", "Clementine" };
			list_box.Items.Clear();
			Random rnd = new Random();
			for (int i = 0; i < fruitNames.Length; i++)
			{
				fruitList.Add(new Fruit(fruitNames[i], rnd.Next(100, 1000)));
				list_box.Items.Add(fruitList[i].Name);
			}
		}

		// refresh fruits using fruitList
		private void Refresh_Fruits()
		{

			list_box.Items.Clear();
			foreach (Fruit fruit in fruitList)
			{
				list_box.Items.Add(fruit.Name);
			}
			fruit_update.Clear();
			fruit_input.Clear();
		}

		// insert fruit
		private void fruit_input_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (Keys.Enter == (Keys)e.KeyChar) InsertFruit();
		}
		private void submit_btn_Click(object sender, EventArgs e) => InsertFruit();
		private void InsertFruit()
		{
			string fruit = fruit_input.Text.Trim();
			if (string.IsNullOrEmpty(fruit)) return;
			Random rnd = new Random();
			fruitList.Add(new Fruit(fruit, rnd.Next(100, 1000)));
			Refresh_Fruits();
		}


		// update fruit
		private void list_box_SelectedIndexChanged(object sender, EventArgs e)
		{
			string selectedFruit = list_box.SelectedItem.ToString();
			fruit_update.Text = selectedFruit;
		}
		private void fruit_update_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (Keys.Enter == (Keys)e.KeyChar) UpdateFruit();
		}
		private void update_btn_Click(object sender, EventArgs e) => UpdateFruit();
		private void UpdateFruit()
		{
			if (list_box.SelectedItems.Count == 0) return;
			string selectedFruit = list_box.SelectedItem.ToString();
			string updatedFruit = fruit_update.Text.Trim();
			fruitList.FirstOrDefault(x => x.Name == selectedFruit).Name = updatedFruit;
			Refresh_Fruits();
		}

		// delete fruit
		private void delete_btn_Click(object sender, EventArgs e)
		{
			if (list_box.SelectedItems.Count == 0) return;
			string selectedFruit = list_box.SelectedItem.ToString();
			fruitList.RemoveAll(x => x.Name == selectedFruit);
			Refresh_Fruits();
		}

		// query fruit
		private void fruit_query_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (Keys.Enter == (Keys)e.KeyChar) QueryFruit();
		}
		private void query_btn_Click(object sender, EventArgs e) => QueryFruit();
		private void QueryFruit()
		{
			string fruitName = fruit_query.Text.Trim().ToLower();
			if (string.IsNullOrEmpty(fruitName)) return;
			list_box.Items.Clear();
			IEnumerable<Fruit> query =
						from fruit in fruitList
						where fruit.Name.ToLower().Contains(fruitName)
						select fruit;

			foreach (Fruit fruit in query)
			{
				list_box.Items.Add(fruit.Name);
			}
			fruit_query.Clear();
		}

		// reset fruit list
		private void reset_btn_Click(object sender, EventArgs e) => Refresh_Fruits();

		// delete all fruits
		private void deleteAll_btn_Click(object sender, EventArgs e)
		{
			fruitList.Clear();
			list_box.Items.Clear();
		}

		// re-initialize fruits
		private void resetApp_btn_Click(object sender, EventArgs e)
		{
			fruitList.Clear();
			Display_All_Fruits();
		}
	}
}
