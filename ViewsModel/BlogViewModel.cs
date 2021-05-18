using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.ViewsModel
{
    public class BlogViewModel
    {
        private IList<Article> article;

        public IList<Article> Articles
        {
            get { return article; }
            set { article = value; }
        }


    }
}