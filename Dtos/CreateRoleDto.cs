using System.ComponentModel.DataAnnotations;

namespace AuthAPI903.Dtos
{
    public class CreateRoleDto
    {
        [Required(ErrorMessage = "Role Name is Required")]
        public string RoleName { get; set; } = null;
    }
}
