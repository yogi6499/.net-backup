using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MS3.PresentationLayer.Models
{
    public class Admin
    {
        private string username = "Admin";
        private string password = "123";
        private string usernameTest;
        private string passwordTest ;
        public string Username { get => username; }
        public string Password { get => password; }
        [Required(ErrorMessage ="Enter Valid User Name")]
        public string UsernameTest { get {return usernameTest; }   set { usernameTest = value; }  }
        [Required(ErrorMessage = "Enter Password")]
        
        public string PasswordTest { get { return passwordTest; } set { passwordTest = value; } }
    }
}