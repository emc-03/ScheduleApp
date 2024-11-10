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
        public void ValidateCustomer(Customer customer)
        {
            if (string.IsNullOrWhiteSpace(customer.FirstName))
            {
                throw new ArgumentException("First name is required.");
            }
            else if (!Regex.IsMatch(customer.FirstName, @"^[a-zA-Z\s]+$") ||
               customer.FirstName.Length < 2 || customer.FirstName.Length > 25)
            {
                throw new ArgumentException("First name must only contain letters and be between 2 and 25 characters.");
            }

            if (string.IsNullOrWhiteSpace(customer.LastName))
            {
                throw new ArgumentException("Last name is required.");
            }
            else if (!Regex.IsMatch(customer.LastName, @"^[a-zA-Z\s]+$") ||
               customer.LastName.Length < 2 || customer.LastName.Length > 25)
            {
                throw new ArgumentException("Last Name must only contain letters and be between 2 and 25 characters.");
            }
            if (string.IsNullOrWhiteSpace(customer.Address.PhoneNumber) || !IsValidPhoneNumber(customer.Address.PhoneNumber))
            {
                throw new ArgumentException("A valid phone number is required.");
            }

            // Do I need to create a seperate method for Address ? 
            if (customer.Address == null || string.IsNullOrWhiteSpace(customer.Address.Address1))
            {
                throw new ArgumentException("A valid address is required.");
            }
            if (customer.Address == null || string.IsNullOrWhiteSpace(customer.Address.Address2))
            {
                throw new ArgumentException("A valid address is reguired.");
            }

            if (customer.Address.City == null || 
                string.IsNullOrWhiteSpace(customer.Address.City))
            {
                throw new ArgumentException("A valid city is required.");
            }
            else if (!Regex.IsMatch(customer.Address.City, @"^[a-zA-Z\s]+$") || 
                customer.Address.City.Length < 2 || customer.Address.City.Length > 50)
            {
                throw new ArgumentException("City must only contain letters and be between 2 and 50 characters.");
            }

            if (customer.Address.PostalCode == null || string.IsNullOrWhiteSpace(customer.Address.PostalCode))
            {
                throw new ArgumentException("A valid postal code is required.");
            }
            else if (!IsValidPostalCode(customer.Address.PostalCode))
            {
                throw new ArgumentException("Invalid postal code format.");
            }

            if (customer.Address.City.Country == null || string.IsNullOrWhiteSpace(customer.Address.City.Country)
)
                {
                throw new ArgumentException("A valid country is required.");
            }
                else if (!Regex.IsMatch(customer.Address.City.Country, @"^[a-zA-Z\s]+$"))
                {
                    throw new ArgumentException("Country must only contain letters.");
                }
            }
        private bool IsValidPhoneNumber(string phone)
        {

            return phone.All(char.IsDigit) && phone.Length == 10;
        }

        private bool IsValidPostalCode(string postalCode)
        {
  // postal code format: 5 digits, or 5 digits + 4 (for U.S. ZIP codes)
            return Regex.IsMatch(postalCode, @"^\d{5}(-\d{4})?$");
        }
    }
   
}
