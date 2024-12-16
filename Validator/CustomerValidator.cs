using ScheduleApp.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

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
            string phonePattern = @"^[\d-]+$"; // Allows only digits and dashes
            return Regex.IsMatch(phoneNumber, phonePattern) &&
            phoneNumber.All(char.IsDigit) && phoneNumber.Length == 10;
        }

        public bool IsValidAddress(string address)
        {
            //  validate a street address (letters, numbers, spaces, commas, periods, hyphens)
            string addressPattern = @"^[a-zA-Z0-9\s,.-]+$";
            return Regex.IsMatch(address, addressPattern) &&
                !string.IsNullOrWhiteSpace(address);
        }

        public bool IsValidCity(string cityName)
        {
            return !string.IsNullOrWhiteSpace(cityName) &&
                   Regex.IsMatch(cityName, @"^[a-zA-Z\s]+$") &&
                   cityName.Length >= 2 && cityName.Length <= 50;
        }

        public bool IsValidPostalCode(string postalCode)
        {
            return Regex.IsMatch(postalCode, @"^\d{5}(-\d{4})?$");
        }

        public bool IsValidCountry(string countryName)
        {
            return !string.IsNullOrWhiteSpace(countryName) &&
                   Regex.IsMatch(countryName, @"^[a-zA-Z\s]+$");
        }

        public void ValidateCustomer(Customer customer)
        {
            if (!IsValidFirstName(customer.FirstName)) throw new Exception("Invalid first name, only letters or spaces.");
            if (!IsValidLastName(customer.LastName)) throw new Exception("Invalid last name, only letters or spaces.");
            if (!IsValidAddress(customer.Address.Address1)) throw new Exception("Invalid address.");
            if (!IsValidAddress(customer.Address.Address2)) throw new Exception("Invalid address.");
            if (!IsValidPostalCode(customer.Address.PostalCode)) throw new Exception("Invalid postal code, only 1 - 5 digits allowed.");
            if (!IsValidPhoneNumber(customer.Address.PhoneNumber)) throw new Exception("Invalid phone number! Only digits and dashes are allowed.");
            if (!IsValidCity(customer.Address.City.Name)) throw new Exception("Invalid city, check for typos.");
            if (!IsValidCountry(customer.Address.City.Country.Name)) throw new Exception("Invalid country, check for typos.");
        }
    }
}
