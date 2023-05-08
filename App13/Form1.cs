using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonLambda_Click(object sender, EventArgs e)
        {
            //Lambda Expression
            //Arrow function
            //lazy

            var arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var result1 = new List<int>();
            foreach (int i in arr)
            {
                result1.Add(i * 10);
            }
            //
            var result1JADID = MyMap(arr, x => x * 10);
            var result1Linq =arr.Select(x => x * 10);

            var result2 = new List<int>();
            foreach (int i in arr)
            {
                result2.Add(i * i);
            }
            var result2JADID = MyMap(arr, x => x * x);
        }

        delegate int MyLambda(int a);
        private List<int> MyMapDelegate(int[] arr, MyLambda fnc)
        {
            var result = new List<int>();
            foreach (int i in arr)
            {
                var x = fnc(i);
                result.Add(x);
            }
            return result;

        }

        private List<int> MyMap(int[] arr, Func<int, int> fnc)
        {
            var result = new List<int>();
            foreach (int i in arr)
            {
                var x = fnc(i);
                result.Add(x);
            }
            return result;
        }

        private void buttonEmbded_Click(object sender, EventArgs e)
        {
            //Embded
            // Sqlite
            // SQL Server Compact Edition CE
            // ...

            // ADO.net
            // ORM > Entity Framework

            var conectionStr = "URI=file:app.db";
            using (var connection = new SQLiteConnection(conectionStr))
            {
                var command = new SQLiteCommand("select * from product", connection);
                connection.Open();
                var reader = command.ExecuteReader();
                var result = new List<Product>();
                while (reader.Read())
                {
                    result.Add(new Product { 
                        Id = Convert.ToInt32(reader["id"]), 
                        Name = reader["name"] as string, 
                        Price = Convert.ToInt32(reader["price"]) });
                }
                dataGridView1.DataSource = result;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }    
        public int Price { get; set; }
    }
}
