using SalesCRMApp.Controllers;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SalesCRMApp.Models
{
    public class UserViewModel
    {
        public string Id { get; set; }

        [DisplayName("First Name")]
        public string FirstName { get; set; }

        [DisplayName("Last Name")]
        public string LastName { get; set; }

        [DisplayName("E-Mail")]
        [EmailAddress(ErrorMessage = "Please enter a valid email address")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [DisplayName("Phone no")]
        public string Phone { get; set; }

        public List<AppRolesController> UserInRoles { get; set; }
        public bool IsLockedOut { get; set; }
    }
}