using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CaptchaTest.Models
{
    public class FormModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string Comment { get; set; }
    }
}