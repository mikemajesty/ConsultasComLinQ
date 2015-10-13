using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExemploLINQ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        EFI ctx = new EFI();  
        private void listagemSimplesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dados = from p in ctx.Products
                        select p;
            dgv.DataSource = dados.ToList();
        }

        private void orderByToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dados = from p in ctx.Products
                        orderby p.ProductName
                        select p;
            dgv.DataSource = dados.ToList();
        }

        private void whereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dados = from p in ctx.Products
                        where p.CategoryID == 5
                        orderby p.ProductName
                        select p;
            dgv.DataSource = dados.ToList();
        }

        private void whereStringToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dados = from p in ctx.Products
                        where p.Category.CategoryName == "Produce"
                        orderby p.ProductName
                        select p;
            dgv.DataSource = dados.ToList();
        }

        private void whereTiposAnonimosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dados = from p in ctx.Products
                        where p.Category.CategoryName == "Produce"
                        orderby p.ProductName
                        select new {
                        CodProduto = p.ProductID,
                        Produto = p.ProductName,
                        CodCategoria = p.CategoryID,
                        Categoria = p.Category.CategoryName
                        };
            dgv.DataSource = dados.ToList();
        }

        private void containsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dados = from c in ctx.Customers
                        where c.Country.Contains("B")
                        select c;
            dgv.DataSource = dados.ToList();
        }

        private void startWithToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dados = from c in ctx.Customers
                        where c.CompanyName.StartsWith("A")
                        select c;
            dgv.DataSource = dados.ToList();
        }

        private void endsWithToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dados = from c in ctx.Customers
                        where c.CompanyName.EndsWith("e")
                        select c;
            dgv.DataSource = dados.ToList();
        }

        private void listarAlgunsCamposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dados = from o in ctx.Orders
                        select new { o.OrderID, o.CustomerID, o.OrderDate };

            dgv.DataSource = dados.ToList();
        }

        private void campoCalculadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dados = from od in ctx.Order_Details
                        select new
                        {
                            od.OrderID,
                            od.Quantity,
                            od.UnitPrice,
                            Total = od.Quantity * od.UnitPrice
                        };
            dgv.DataSource = dados.ToList();
        }

        private void andOrToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dados = from p in ctx.Products
                        //where p.UnitsInStock == 0 && p.UnitPrice > 0
                        where p.UnitsInStock == 0 || p.UnitPrice > 0
                        select p;

            dgv.DataSource = dados.ToList();
        }

        private void groupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dados = from p in ctx.Products
                        group p by p.CategoryID into grupoCat
                        select new
                        {
                            Categoria = grupoCat.Key,
                            QtddeProduto = grupoCat.Count()
                        };
            dgv.DataSource = dados.ToList();
        }

        private void innerToolStripMenuItem_Click(object sender, EventArgs e)
        {
              var dados =from c in ctx.Customers  join o in ctx.Orders   on c.CustomerID equals o.CustomerID   into pedidos
              select new { cliente = c.CompanyName,  QtdPedidos = pedidos.Count() };
                    
                    
                     
                          
                         
                      
            dgv.DataSource = dados.ToList();

        }

        private void minMaxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dados = from p in ctx.Products
                        group p by p.CategoryID into grupoCat
                        select new
                        {
                            Categoria = grupoCat.Key,
                            Maximo = grupoCat.Max(p => p.UnitPrice),
                            Minimo = grupoCat.Min(p => p.UnitPrice)

                        };
            dgv.DataSource = dados.ToList();
        }

        private void médiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dados = from o in ctx.Order_Details
                        group o by o.OrderID into grupoOrder
                        select new
                        {
                            NumOrdem = grupoOrder.Key,
                            PrecoMédio = grupoOrder.Average(o => o.UnitPrice)

                        };
            dgv.DataSource = dados.ToList();
        }

        private void firstToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Product dados = ((from p in ctx.Products
                             where p.UnitsInStock == 4
                             select p).First());

            //Products prod = dados;
            List<Product> lista = new List<Product>();
            lista.Add(dados);
            dgv.DataSource = lista;
            //MessageBox.Show("produto: " +dados.ProductName+ " Qtd em Estoque: "+dados.UnitsInStock );
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
