using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication16
{
   public  class VsComputer
    {
        public string pl;
     

        public VsComputer(string pl1)
        {
            this.pl = pl1;
            
        }
        public VsComputer()
        {
            this.pl = null;
        }
        public void setPl(string pl1)
        {
            this.pl = pl1;
        }
        public string getPl()
        {
            return pl;
        }

    

    }
   
}
