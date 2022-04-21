namespace Using_LINQ
{
	partial class Using_LINQ
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.fruit_input = new System.Windows.Forms.TextBox();
			this.submit_btn = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.update_btn = new System.Windows.Forms.Button();
			this.fruit_update = new System.Windows.Forms.TextBox();
			this.list_box = new System.Windows.Forms.ListBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.delete_btn = new System.Windows.Forms.Button();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.fruit_query = new System.Windows.Forms.TextBox();
			this.query_btn = new System.Windows.Forms.Button();
			this.reset_btn = new System.Windows.Forms.Button();
			this.deleteAll_btn = new System.Windows.Forms.Button();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.resetApp_btn = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.groupBox5.SuspendLayout();
			this.SuspendLayout();
			// 
			// fruit_input
			// 
			this.fruit_input.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.fruit_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.fruit_input.Location = new System.Drawing.Point(10, 35);
			this.fruit_input.Margin = new System.Windows.Forms.Padding(7);
			this.fruit_input.Name = "fruit_input";
			this.fruit_input.Size = new System.Drawing.Size(228, 35);
			this.fruit_input.TabIndex = 2;
			this.fruit_input.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fruit_input_KeyPress);
			// 
			// submit_btn
			// 
			this.submit_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.submit_btn.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.submit_btn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.submit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.submit_btn.Location = new System.Drawing.Point(10, 80);
			this.submit_btn.Name = "submit_btn";
			this.submit_btn.Size = new System.Drawing.Size(144, 44);
			this.submit_btn.TabIndex = 3;
			this.submit_btn.Text = "Insert";
			this.submit_btn.UseVisualStyleBackColor = false;
			this.submit_btn.Click += new System.EventHandler(this.submit_btn_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.fruit_input);
			this.groupBox1.Controls.Add(this.submit_btn);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(12, 11);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(262, 144);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Insert";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.fruit_update);
			this.groupBox2.Controls.Add(this.update_btn);
			this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(12, 161);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(262, 143);
			this.groupBox2.TabIndex = 5;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Update (click a fruit)";
			// 
			// update_btn
			// 
			this.update_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.update_btn.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.update_btn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.update_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.update_btn.Location = new System.Drawing.Point(10, 80);
			this.update_btn.Name = "update_btn";
			this.update_btn.Size = new System.Drawing.Size(144, 44);
			this.update_btn.TabIndex = 4;
			this.update_btn.Text = "Update";
			this.update_btn.UseVisualStyleBackColor = false;
			this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
			// 
			// fruit_update
			// 
			this.fruit_update.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.fruit_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.fruit_update.Location = new System.Drawing.Point(10, 35);
			this.fruit_update.Margin = new System.Windows.Forms.Padding(7);
			this.fruit_update.Name = "fruit_update";
			this.fruit_update.Size = new System.Drawing.Size(228, 35);
			this.fruit_update.TabIndex = 3;
			this.fruit_update.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fruit_update_KeyPress);
			// 
			// list_box
			// 
			this.list_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.list_box.FormattingEnabled = true;
			this.list_box.ItemHeight = 18;
			this.list_box.Location = new System.Drawing.Point(548, 7);
			this.list_box.Name = "list_box";
			this.list_box.Size = new System.Drawing.Size(189, 418);
			this.list_box.TabIndex = 6;
			this.list_box.SelectedIndexChanged += new System.EventHandler(this.list_box_SelectedIndexChanged);
			// 
			// groupBox3
			// 
			this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.groupBox3.Controls.Add(this.delete_btn);
			this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox3.Location = new System.Drawing.Point(12, 310);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(262, 114);
			this.groupBox3.TabIndex = 7;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Delete (click a fruit)";
			// 
			// delete_btn
			// 
			this.delete_btn.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.delete_btn.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.delete_btn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.delete_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.delete_btn.Location = new System.Drawing.Point(10, 39);
			this.delete_btn.Name = "delete_btn";
			this.delete_btn.Size = new System.Drawing.Size(144, 44);
			this.delete_btn.TabIndex = 5;
			this.delete_btn.Text = "Delete";
			this.delete_btn.UseVisualStyleBackColor = false;
			this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
			// 
			// groupBox4
			// 
			this.groupBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.groupBox4.Controls.Add(this.query_btn);
			this.groupBox4.Controls.Add(this.fruit_query);
			this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox4.Location = new System.Drawing.Point(280, 12);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(262, 144);
			this.groupBox4.TabIndex = 8;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Query";
			// 
			// fruit_query
			// 
			this.fruit_query.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.fruit_query.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.fruit_query.Location = new System.Drawing.Point(10, 34);
			this.fruit_query.Margin = new System.Windows.Forms.Padding(7);
			this.fruit_query.Name = "fruit_query";
			this.fruit_query.Size = new System.Drawing.Size(228, 35);
			this.fruit_query.TabIndex = 3;
			this.fruit_query.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fruit_query_KeyPress);
			// 
			// query_btn
			// 
			this.query_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.query_btn.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.query_btn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.query_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.query_btn.Location = new System.Drawing.Point(10, 79);
			this.query_btn.Name = "query_btn";
			this.query_btn.Size = new System.Drawing.Size(144, 44);
			this.query_btn.TabIndex = 4;
			this.query_btn.Text = "Search By Name";
			this.query_btn.UseVisualStyleBackColor = false;
			this.query_btn.Click += new System.EventHandler(this.query_btn_Click);
			// 
			// reset_btn
			// 
			this.reset_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.reset_btn.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.reset_btn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.reset_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.reset_btn.Location = new System.Drawing.Point(10, 29);
			this.reset_btn.Name = "reset_btn";
			this.reset_btn.Size = new System.Drawing.Size(144, 44);
			this.reset_btn.TabIndex = 5;
			this.reset_btn.Text = "Refresh Fruit List";
			this.reset_btn.UseVisualStyleBackColor = false;
			this.reset_btn.Click += new System.EventHandler(this.reset_btn_Click);
			// 
			// deleteAll_btn
			// 
			this.deleteAll_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.deleteAll_btn.BackColor = System.Drawing.Color.LightCoral;
			this.deleteAll_btn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.deleteAll_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.deleteAll_btn.Location = new System.Drawing.Point(10, 108);
			this.deleteAll_btn.Name = "deleteAll_btn";
			this.deleteAll_btn.Size = new System.Drawing.Size(144, 44);
			this.deleteAll_btn.TabIndex = 6;
			this.deleteAll_btn.Text = "Delete All Fruits";
			this.deleteAll_btn.UseVisualStyleBackColor = false;
			this.deleteAll_btn.Click += new System.EventHandler(this.deleteAll_btn_Click);
			// 
			// groupBox5
			// 
			this.groupBox5.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.groupBox5.Controls.Add(this.resetApp_btn);
			this.groupBox5.Controls.Add(this.reset_btn);
			this.groupBox5.Controls.Add(this.deleteAll_btn);
			this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox5.Location = new System.Drawing.Point(280, 167);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(262, 257);
			this.groupBox5.TabIndex = 9;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "More Options";
			// 
			// resetApp_btn
			// 
			this.resetApp_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.resetApp_btn.BackColor = System.Drawing.Color.LightCoral;
			this.resetApp_btn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.resetApp_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.resetApp_btn.Location = new System.Drawing.Point(10, 182);
			this.resetApp_btn.Name = "resetApp_btn";
			this.resetApp_btn.Size = new System.Drawing.Size(144, 44);
			this.resetApp_btn.TabIndex = 7;
			this.resetApp_btn.Text = "Reset Application";
			this.resetApp_btn.UseVisualStyleBackColor = false;
			this.resetApp_btn.Click += new System.EventHandler(this.resetApp_btn_Click);
			// 
			// Using_LINQ
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(749, 436);
			this.Controls.Add(this.groupBox5);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.list_box);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Margin = new System.Windows.Forms.Padding(7);
			this.Name = "Using_LINQ";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Fruits Using LINQ";
			this.Load += new System.EventHandler(this.Using_LINQ_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.groupBox5.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.TextBox fruit_input;
		private System.Windows.Forms.Button submit_btn;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox fruit_update;
		private System.Windows.Forms.Button update_btn;
		private System.Windows.Forms.ListBox list_box;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Button delete_btn;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.Button query_btn;
		private System.Windows.Forms.TextBox fruit_query;
		private System.Windows.Forms.Button deleteAll_btn;
		private System.Windows.Forms.Button reset_btn;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.Button resetApp_btn;
	}
}

