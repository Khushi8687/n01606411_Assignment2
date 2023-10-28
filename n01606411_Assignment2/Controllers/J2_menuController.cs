using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n01606411_Assignment2.Controllers
{
    public class J2_menuController : ApiController
    {
       
        public string Getdicegame (int m, int n)
        {
            int count = 0;
                for (int dice1 = 1; dice1 <= m; dice1++)
            {
                for (int dice2 = 1; dice2 <= n; dice2++)
                {
                    if (dice1 + dice2 == 10)
                    {
                        count++;
                    }

                }
            }
            return "There are" + count + " total ways to get sum 10";
        }
    }
}
