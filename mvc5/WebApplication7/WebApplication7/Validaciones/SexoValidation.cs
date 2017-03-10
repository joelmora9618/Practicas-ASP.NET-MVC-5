using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebApplication7.Validaciones
{
    public class SexoValidationAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            bool valid = true;
            try
            {
                if (!(value.Equals("M") || value.Equals("F")))
                {
                    valid = false;
                }
                
                return valid;   

            }catch(Exception)
            {
                return false;
            }
        }
    }
}