using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication7.DAL;
using WebApplication7.Models;

namespace WebApplication7.DAL
{
    public class WebApplication7Initializer : System.Data.Entity.DropCreateDatabaseAlways<WebApplication7Context>
    {
        protected override void Seed(WebApplication7Context context)
        {
            var Ch1s = new List<Ch1>
            {
            new Ch1{ID=1,name="Bank"},
            new Ch1{ID=2,name="Bank"},
            new Ch1{ID=3,name="Bank"},
                        };
            Ch1s.ForEach(s => context.Ch1.Add(s));
            context.SaveChanges();

        }
    }
}