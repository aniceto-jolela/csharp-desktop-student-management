using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Krypton.Toolkit;

namespace cpqi.Helpers
{
    public static class ValidateView
    {
        public static bool ValidateFullName(KryptonTextBox txtFullName, ErrorProvider errorProvider)
        {
            var text = txtFullName.Text;
            if (string.IsNullOrWhiteSpace(text))
                return ErrorProviderView.SetError(txtFullName, "Nome completo é obrigatório.", errorProvider);

            if (text.Trim().Split(' ').Length < 2)
                return ErrorProviderView.SetError(txtFullName, "Informe pelo menos nome e sobrenome.", errorProvider);

            if (!RegexRules.FullName.IsMatch(text))
                return ErrorProviderView.SetError(txtFullName, "Use apenas letras e espaços.", errorProvider);

            return true;
        }
        public static bool ValidateBI(KryptonTextBox txtNBI, ErrorProvider errorProvider)
        {
            var text = txtNBI.Text?.Trim();
            if (string.IsNullOrWhiteSpace(text))
                return ErrorProviderView.SetError(txtNBI, "BI é obrigatório.", errorProvider);

            if (!RegexRules.BI.IsMatch(text))
                return ErrorProviderView.SetError(txtNBI, "Formato de BI inválido.", errorProvider);

            return true;
        }
        public static bool ValidateBIssueDates(KryptonDateTimePicker dtpIssuedOn, KryptonDateTimePicker dtpValidUntil, ErrorProvider errorProvider)
        {
            bool isValid = true;

            if (dtpIssuedOn.Value > DateTime.Today)
                isValid &= ErrorProviderView.SetError(dtpIssuedOn, "Data de emissão não pode ser futura.", errorProvider);

            if (dtpValidUntil.Value <= dtpIssuedOn.Value)
                isValid &= ErrorProviderView.SetError(dtpValidUntil, "Validade deve ser posterior à emissão.", errorProvider);

            return isValid;
        }
        public static bool ValidatePhone(KryptonTextBox txtPhone, ErrorProvider errorProvider)
        {
            var phone = txtPhone.Text;
            if (!string.IsNullOrWhiteSpace(phone))
            {
                if (!RegexRules.Phone.IsMatch(phone))
                    return ErrorProviderView.SetError(txtPhone, "Telefone inválido.", errorProvider);
            }
            return true;
        }
    }
}
