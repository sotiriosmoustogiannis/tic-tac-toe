using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication16
{
    public class Player
    {
        public string username;
        
        public Player(String user1)
        {
            username = user1;
        }
        
        public Player()
        {
            username = "";
        }
        
        public string getUser()
        {
            return username;
        }
        public void setUser(string user1)
        {
            this.username = user1;
        }
      
        public void Play(Button btn,bool who)
        {
            if (who)
            {
                btn.Text = "X";
            }
            else
            {
                btn.Text = "O";
            }
            
        }
        public void Play2(Button btn, bool who,String rdb)
        {
            if (who)
            {
                btn.Text = rdb.ToString();
            }
            else
            {
                btn.Text = rdb.ToString();
            }
        }
    }
 }
