using System;
using System.Collections.Generic;
using System.Text;

namespace Account
{
    interface IAcccount
    {
        bool CheckPassword(string pass);
        void ShowInfo();
    }
}
