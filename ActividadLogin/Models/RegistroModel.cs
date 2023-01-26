using System.ComponentModel.DataAnnotations;

namespace ActividadLogin.Models
{
    public class RegistroModel
    {
        [Required(ErrorMessage = "tienes que poner tu nombre :c")]

        public string nombre { get; set; }

        [Required(ErrorMessage = "tienes que poner tu móvil :c")]
        [RegularExpression(@"^(6|7)[0-9]{8}$", ErrorMessage = "teléfono móvil no válido")]
        public int tlf { get; set; }

        [Required(ErrorMessage = "tienes que poner tu dni :c")]
        [RegularExpression(@"^[0-9]{8}[A-Z]$", ErrorMessage = "dni no válido")]
        public string dni { get; set; }

        [Required(ErrorMessage = "tienes que poner un nombre de email :c")]
        [RegularExpression(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$", ErrorMessage = "correo electronico no valido")]
        public string email { get; set; }

        [Required(ErrorMessage = "tienes que poner una contraseña :c")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z]).{8,}$", ErrorMessage = "la contra tiene que ser de minimo 8 caracteres e incluir mayuscula y minuscula")]
        public string contra { get; set; }

    }
}
