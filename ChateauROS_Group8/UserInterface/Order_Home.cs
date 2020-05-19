using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;
using Logic;

namespace UserInterface
{
    public partial class Order_Home : Form
    {
        Menu_Service menu_Service = new Menu_Service();
        Category_Service category_Service = new Category_Service();
        MenuItem_Service menuItem_Service = new MenuItem_Service();

        public Order_Home()
        {
            InitializeComponent();
        }

        private void Order_Home_Load(object sender, EventArgs e)
        {
            PopulateTreeView();
        }

        private void PopulateTreeView()
        {
            List<Models.Menu> allMenus = menu_Service.GetAllMenus(); //retrieves all menus from DB
            allMenus.OrderBy(menu => menu.MenuID);
            int menuNumber = allMenus.First().MenuID;
            foreach (Models.Menu menu in allMenus)
            {
                trv_AllMenuItems.Nodes.Add(menu.MenuName);
                FillMenu(menuNumber);
                menuNumber++;
            }
        }

        private void FillMenu(int menuNumber) //try catch statements
        {
            List<Models.MenuItem> allMenuItems = menuItem_Service.GetAllMenuItems(); //retrieves all menuItems from DB
            allMenuItems.OrderBy(item => item.CategoryID); //orders them by category (e.g. starters, hot drinks, etc)

            List<Category> categoriesForMenu = category_Service.GetCategoriesByMenu(menuNumber);
            Models.Menu currentMenu = menu_Service.GetMenuByID(menuNumber);

            int currentCategory = allMenuItems.First().CategoryID;
            Category currentCatObj = category_Service.GetCategoryByID(currentCategory);
            var treeNodes = new List<TreeNode>();
            var childNodes = new List<TreeNode>();
            foreach (Models.MenuItem item in allMenuItems)
            {
                if (currentCategory == item.CategoryID) //puts dishes from same category into the same tree directory
                {
                    childNodes.Add(new TreeNode(item.DishName));
                }
                else
                {
                    if (childNodes.Count > 0 && currentCatObj.MenuID == menuNumber)
                    {
                        treeNodes.Add(new TreeNode(currentCatObj.CategoryName, childNodes.ToArray()));
                        childNodes = new List<TreeNode>();
                    }
                    childNodes.Add(new TreeNode(item.DishName));
                    currentCategory = item.CategoryID;
                    currentCatObj = category_Service.GetCategoryByID(currentCategory);
                }
            }
            if (childNodes.Count > 0 && currentCatObj.MenuID == menuNumber)
            {
                treeNodes.Add(new TreeNode(currentCatObj.CategoryName, childNodes.ToArray()));
            }
            trv_AllMenuItems.Nodes[menuNumber - 1].Nodes.AddRange(treeNodes.ToArray());
        }

        private void trv_AllMenuItems_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
    }
}
