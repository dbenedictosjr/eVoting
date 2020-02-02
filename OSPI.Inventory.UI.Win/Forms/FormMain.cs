using OSPI.Inventory.Infrastructure.Interfaces;
using OSPI.Inventory.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OSPI.Inventory.UI.Win.Forms
{
    public partial class FormMain : Form
    {
        private readonly ICategory1Service _Category1Service;

        public FormMain(ICategory1Service Category1Service)
        {
            InitializeComponent();
            this._Category1Service = Category1Service;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to .Net core windows forms");
        }

        public async Task<IEnumerable<Category1Model>> GetAllAsync()
        {
            return await _Category1Service.GetAllAsync();
        }
    }
}
