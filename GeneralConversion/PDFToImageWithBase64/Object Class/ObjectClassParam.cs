using System.ComponentModel.DataAnnotations;

namespace PDFToImageWithBase64.ObjectClass
{
    public class PDFToImageWithBase64Parameter
    {
        //[Required(ErrorMessage = "Base64 harus diisi.")]
        public string? Base64 { get; set; }
    }
}
