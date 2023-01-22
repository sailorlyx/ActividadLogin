using System.ComponentModel.DataAnnotations;

namespace ActividadLogin.Models
{   
    public class UsuarioModel
    {
        [Required(ErrorMessage = "tienes que poner un email válido :cc")]
        [RegularExpression(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$", ErrorMessage = "losiento correo electronico pocho")]
        public string usuario { get; set; }

        [Required(ErrorMessage = "contraseña no válida :cc")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z]).{8,}$", ErrorMessage = "losiento contraseña pocha")]
        public string contra { get; set; }



    }
}
