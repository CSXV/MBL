using System;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

namespace MyBookLibrary_BusinessLayer {
  public class clsUtilites {
    public static string ComputeHash(string input) {
      using(SHA256 sHA256 = SHA256.Create()) {
        byte[] hashBytes = sHA256.ComputeHash(Encoding.UTF8.GetBytes(input));

        return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
      }
    }

    public static bool EmailValidation(string email) {
      string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

      Regex regex = new Regex(pattern);

      return regex.IsMatch(email);
    }
  }
}
