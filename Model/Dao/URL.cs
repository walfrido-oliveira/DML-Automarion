using System.ComponentModel.DataAnnotations;
namespace Walfrido.DML.Automation.Model.Dao
{
    class URL : IURL
    {
        [Required (ErrorMessage ="The field Database is required.")]
        public string DataBase { get; set; }
        [Required(ErrorMessage = "The field Hostname is required.")]
        public string Hostname { get; set; }
        [Required(ErrorMessage = "The field Password is required.")]
        public string Password { get; set; }
        [Required(ErrorMessage = "The field Port is required.")]
        public string Port { get; set; }
        [Required(ErrorMessage = "The field User is required.")]
        public string User { get; set; }

        public string GetURL()
        {
            return "Server=" + Hostname + ";Port=" + Port + ";DataBase=" + DataBase + ";Uid=" + User + ";Pwd=" + Password;
        }
    }
}
