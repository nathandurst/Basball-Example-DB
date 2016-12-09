using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using System.Data.Entity.Validation;

namespace DisplayTable
{
    public partial class DisplayPlayerTable : Form
    {
        public DisplayPlayerTable()
        {
            InitializeComponent();
        }

        private BaseballExample.BaseballEntities dbcontext = 
            new BaseballExample.BaseballEntities();

        private void DisplayPlayerTable_Load(object sender, EventArgs e)
        {
            dbcontext.Players
                .OrderBy(player => player.LastName)
                .ThenBy(player => player.FirstName)
                .Load();

            playerBindingSource.DataSource = dbcontext.Players.Local;
        }

    }
}
