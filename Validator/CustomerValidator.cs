using ScheduleApp.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScheduleApp.Validator
{
    public class CustomerValidator
    {
        public bool IsValidFirstName(string firstName)
        {
            return !string.IsNullOrWhiteSpace(firstName) &&
                   Regex.IsMatch(firstName, @"^[a-zA-Z\s]+$") &&
                   firstName.Length >= 2 && firstName.Length <= 25;
        }

        public bool IsValidLastName(string lastName)
        {
            return !string.IsNullOrWhiteSpace(lastName) &&
                   Regex.IsMatch(lastName, @"^[a-zA-Z\s]+$") &&
                   lastName.Length >= 2 && lastName.Length <= 25;
        }

        public bool IsValidPhoneNumber(string phoneNumber)
        {
            // Allow common phone number formats:
            // (XXX) XXX-XXXX, XXX-XXX-XXXX, XXX.XXX.XXXX, XXX XXX XXXX, or just XXXXXXXXXX
            string phonePattern = @"^\(?\d{3}\)?[-.\s]?\d{3}[-.\s]?\d{4}$";

            // Ensure the input is not null or empty and matches the phone pattern
            return !string.IsNullOrWhiteSpace(phoneNumber) &&
                   Regex.IsMatch(phoneNumber, phonePattern);
        }

        public bool IsValidAddress(string address)
        {
            // validate a street address (letters, numbers, spaces, commas, periods, hyphens)
            string addressPattern = @"^[a-zA-Z0-9\s,.\-#]+$";
            return Regex.IsMatch(address, addressPattern) &&
                !string.IsNullOrWhiteSpace(address);
        }

        public bool IsValidAddressTwo(string address2)
        {
            string addressTwoPattern = @"^[a-zA-Z0-9\s,.\-#]+$";

            if (string.IsNullOrWhiteSpace(address2))
            {
                // Show a message box to confirm if the input being empty is intentional
                var result = MessageBox.Show(
                    "Address Line 2 is empty. Click Cancel to Update Form.",
                    "Confirm Empty Address",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question
                );

                // If the user clicks "OK", return true; otherwise, return false
                return result == DialogResult.OK;
            }

            // Validate the input against the pattern
            return Regex.IsMatch(address2, addressTwoPattern);
        }

        public bool IsValidCity(string cityName)
        {
            string cityPattern = @"^[a-zA-Z\s.-]+$";
            return !string.IsNullOrWhiteSpace(cityName) &&
                   Regex.IsMatch(cityName, cityPattern) &&
                   cityName.Length >= 2 && cityName.Length <= 50;
        }

        public bool IsValidPostalCode(string postalCode)
        {
            string postalPattern = @"^\d{5}(-\d{4})?$";
            return !string.IsNullOrWhiteSpace(postalCode) &&
                Regex.IsMatch(postalCode, postalPattern) &&
                postalCode.Length >= 2 && postalCode.Length <= 10;

        }

        public bool IsValidCountry(string countryName)
        {
            string countryPattern = @"^[a-zA-Z\s.-]+$";
            return !string.IsNullOrWhiteSpace(countryName) &&
                Regex.IsMatch(countryName, countryPattern) &&
                countryName.Length >= 2 && countryName.Length <= 50;
        }


        public bool ValidateCustomer(Customer customer)
        {
            if (!IsValidFirstName(customer.FirstName)) throw new Exception("Invalid first name, only letters or spaces.");
            if (!IsValidLastName(customer.LastName)) throw new Exception("Invalid last name, only letters or spaces.");
            if (!IsValidPhoneNumber(customer.Address.PhoneNumber)) throw new Exception("Invalid phone number! Only digits and dashes are allowed.");
            if (!IsValidAddress(customer.Address.Address1)) throw new Exception("Invalid address.");
            if (!IsValidAddressTwo(customer.Address.Address2)) throw new Exception("Invalid address.");
            if (!IsValidPostalCode(customer.Address.PostalCode)) throw new Exception("Invalid postal code, only 1 - 5 digits allowed.");
            if (!IsValidCity(customer.Address.City.Name)) throw new Exception("Invalid city, check for typos.");
            if (!IsValidCountry(customer.Address.City.Country.Name)) throw new Exception("Invalid country, check for typos.");



            return true; // all validation passed 

        }
    }
}
