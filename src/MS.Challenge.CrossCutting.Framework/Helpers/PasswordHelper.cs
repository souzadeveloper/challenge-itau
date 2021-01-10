using MS.Challenge.CrossCutting.Framework.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS.Challenge.CrossCutting.Framework.Helpers
{
    public static class PasswordHelper
    {
        public static bool IsValid(string password)
        {
            /* Uma Senha será válida se:
               Possuir nove ou mais caracteres
               Possuir ao menos 1 dígito
               Possuir ao menos 1 letra minúscula
               Possuir ao menos 1 letra maiúscula
               Possuir ao menos 1 caractere especial: !@#$%^&*()-+
               Não possuir caracteres repetidos dentro do conjunto
               Não possuir espaços em branco
            */
            return (password.Trim().Length >= 9 &&
                StringUtils.ContainsDigit(password) &&
                StringUtils.ContainsLowerCase(password) &&
                StringUtils.ContainsUpperCase(password) &&
                CheckEspecialChar(password) &&
                CheckDuplicateChar(password));
        }

        private static bool CheckEspecialChar(string value)
        {
            var specialChars = "!@#$%^&*()-+";

            /* Verifica se todos os caracteres são válidos */
            for (int i = 0; i < value.Length; i++)
            {
                if (!char.IsLetterOrDigit(value[i]) && !specialChars.Contains(value[i].ToString()))
                {
                    return false;
                }
            }

            /* Verifica se existe pelo menos 1 caracter especial */
            for (int i = 0; i < value.Length; i++)
            {
                if (specialChars.Contains(value[i].ToString()))
                {
                    return true;
                }
            }

            return false;
        }

        private static bool CheckDuplicateChar(string value)
        {
            var validChars = "";

            for (int i = 0; i < value.Length; i++)
            {
                if (validChars.Contains(value[i].ToString()))
                {
                    return false;
                }

                validChars = string.Concat(validChars, value[i].ToString());
            }

            return true;
        }
    }
}
