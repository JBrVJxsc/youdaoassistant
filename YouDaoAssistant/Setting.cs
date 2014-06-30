using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouDaoAssistant
{
    public class Setting
    {
        private int timeKnow = 900;
        private int timeDoNotKnow = 1500;

        public int TimeKnow
        {
            get
            {
                return timeKnow;
            }
            set
            {
                timeKnow = value;
            }
        }

        public int TimeDoNotKnow
        {
            get
            {
                return timeDoNotKnow;
            }
            set
            {
                timeDoNotKnow = value;
            }
        }
    }
}
