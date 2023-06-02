using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckTorrent.Components
{
    internal class Labels
    {
       public Form1 form { get; set; }
       public Labels (Form1 form)
        {
            if(form != null)
            {
                this.form = form;
            }
        }
    }
}
