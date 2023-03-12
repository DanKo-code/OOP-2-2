using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Winf_FillingObject_File_ShittyValidation
{
    public class inventoryNumberValAtr : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if(value != null)
            {
                string invNumber = value.ToString();
                if (new Regex(@"^ИН \d{6}$").IsMatch(invNumber))
                    return true;
                else
                    this.ErrorMessage = "Неверный формат инвентарного номера";
            }
            return false;
        }
    }
}
