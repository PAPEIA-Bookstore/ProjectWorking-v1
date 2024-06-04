using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace login_register
{
    public class Review
    {
        public int id;
        public string username;
        public string isbn;
        public string text;
        public int stars;
        public string time;

        public Review(int id, string username, string isbn, string text, int stars, string time)
        {
            this.id = id;
            this.username = username;
            this.isbn = isbn;
            this.text = text;
            this.stars = stars;
            this.time = time;
        }

    }

}
