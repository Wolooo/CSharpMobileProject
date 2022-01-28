using Legends.Tables;
using System;
using System.Collections.Generic;
using System.Text;

namespace Legends.ViewModel
{
    public class FlyoutMenuViewModel
    {
        public string Username
        {
            get
            {
                return RegUserTable._Username;
            }
            set
            {
                Username = RegUserTable._Username;
            }
        }



        public FlyoutMenuViewModel()
        {

        }
    }
}
