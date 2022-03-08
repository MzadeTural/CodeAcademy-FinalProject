using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace StudentInformationSysteam.Business.ViewModel.Account
{
  
  public  class LoginVM
    {
        public int Identifier { get; set; }
        public string UserName { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
         [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public bool RememberMe { get; set; }

    }
}
