using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CentosBM.Models;
using CentosBM.SubForms;
using CentosBM.Forms;
using CentosBM.Connects;
namespace CentosBM.UserControls
{
    public partial class CategoriesItems : UserControl
    {
        public Category category { get; set; }
        public CategoryForm form;
        public CategoriesItems(CategoryForm form)
        {
            InitializeComponent();
            category = new Category();
            this.form = form;
        }

        public void Load_Data(Category a)
        {
            labelCategoriesName.Text = a.Name;
        }

        private void CategoriesItems_Load(object sender, EventArgs e)
        {
            Load_Data(category);
        }
       
        private void btnEditing_Click(object sender, EventArgs e)
        {
            FormEditCategory formEditCategory = new FormEditCategory();
            formEditCategory.category = category;
            formEditCategory.ShowDialog();
            form.DeleteCategory();
            form.Load_Data();
          
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            FormDetailCategory formDetailCategory = new FormDetailCategory();
            formDetailCategory.category = category;
            formDetailCategory.ShowDialog();
        }
    }
}
