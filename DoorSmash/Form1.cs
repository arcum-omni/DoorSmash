using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoorSmash
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Product p = new Product("Eggs");
            //p.Description = "Unfertilized Chicken Embryos";
            //p.Price = 1.99;
            //p.ProductID = 1;

            // object initialization syntax
            Product p = new Product("Eggs")
            {
                Description = "Unfertilized Chicken Embryos",
                Price = 1.99,
                ProductID = 1
            };

            Restaurant r = new Restaurant();
            r.Products.Add(p);

        }
    }
}
