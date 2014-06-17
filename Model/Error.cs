namespace FrbaCommerce.Model
{
    public class Error
    {
        public string Descripcion { get; set; }

        public Error(string desc)
        {
            Descripcion = desc;
        }
    }
}
