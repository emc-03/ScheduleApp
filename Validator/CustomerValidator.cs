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
            return phoneNumber.All(char.IsDigit) && phoneNumber.Length == 10;
        }

        public bool IsValidAddress(string address)
        {
            return !string.IsNullOrWhiteSpace(address);
        }

        public bool IsValidCity(string city)
        {
            return !string.IsNullOrWhiteSpace(city) &&
                   Regex.IsMatch(city, @"^[a-zA-Z\s]+$") &&
                   city.Length >= 2 && city.Length <= 50;
        }

        public bool IsValidPostalCode(string postalCode)
        {
            return Regex.IsMatch(postalCode, @"^\d{5}(-\d{4})?$");
        }

        public bool IsValidCountry(string country)
        {
            return !string.IsNullOrWhiteSpace(country) &&
                   Regex.IsMatch(country, @"^[a-zA-Z\s]+$");
        }

        public void ValidateCustomer(string firstName, string lastName, string address1, string address2, string postalCode, string phoneNumber, string city, string country)
        {
            if (!IsValidFirstName(firstName)) throw new Exception("Invalid first name, only letters or spaces.");
            if (!IsValidLastName(lastName)) throw new Exception("Invalid last name, only letters or spaces.");
            if (!IsValidAddress(address1)) throw new Exception("Invalid address.");
            if (!IsValidPostalCode(postalCode)) throw new Exception("Invalid postal code, only 1 - 5 digits allowed.");
            if (!IsValidPhoneNumber(phoneNumber)) throw new Exception("Invalid phone number, no special characters.");
            if (!IsValidCity(city)) throw new Exception("Invalid city, check for typos.");
            if (!IsValidCountry(country)) throw new Exception("Invalid country, check for typos.");
        }
    }
}
