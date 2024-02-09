using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SMS.Other
{
    class ValidationLab
    {
        // Text Box Validation
        public static bool TextBoxValidation(TextBox textBox, ErrorProvider errorProvider, string regx = null)
        {
            if (string.IsNullOrEmpty(textBox.Text))
            {
                errorProvider.SetError(textBox, "Please Fill the Field...!");
                textBox.Focus();
                return false;
            }
            else
            {
                if (regx != null)
                {
                    Regex reg = new Regex(regx);

                    bool result = reg.IsMatch(textBox.Text.Trim());

                    if (result)
                    {
                        errorProvider.Clear();
                        return true;
                    }
                    else
                    {
                        errorProvider.SetError(textBox, "This is invalid...!");
                        textBox.Focus();
                        return false;
                    }
                }
                else
                {
                    return true;
                }
            }
        }

        // Combo Box Validation
        public static bool ComboBoxValidation(ComboBox comboBox, ErrorProvider errorProvider)
        {
            if (comboBox.SelectedItem == null)
            {
                errorProvider.SetError(comboBox, "Please Fill the Field...!");
                comboBox.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }

        // Check Box Validation
        public static bool CheckBoxValidation(CheckBox checkBox, ErrorProvider errorProvider)
        {
            if (checkBox.Checked)
            {
                return true;
            }
            else
            {
                errorProvider.SetError(checkBox, "Please Fill the Field...!");
                checkBox.Focus();
                return false;
            }
        }

        // Check List Box Validation
        public static bool CheckListBoxValidation(CheckedListBox checkedListBox, ErrorProvider errorProvider)
        {
            if (checkedListBox.CheckedItems == null)
            {
                errorProvider.SetError(checkedListBox, "Please Fill the Field...!");
                checkedListBox.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }



        // Check Email Validation
        public static bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                // Normalize the domain
                email = Regex.Replace(email, @"(@)(.+)$", DomainMapper,
                                      RegexOptions.None, TimeSpan.FromMilliseconds(200));

                // Examines the domain part of the email and normalizes it.
                string DomainMapper(Match match)
                {
                    // Use IdnMapping class to convert Unicode domain names.
                    var idn = new IdnMapping();

                    // Pull out and process domain name (throws ArgumentException on invalid)
                    string domainName = idn.GetAscii(match.Groups[2].Value);

                    return match.Groups[1].Value + domainName;
                }
            }
            catch (RegexMatchTimeoutException e)
            {
                return false;
            }
            catch (ArgumentException e)
            {
                return false;
            }

            try
            {
                return Regex.IsMatch(email,
                    @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
                    RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }

        }




    }
}
