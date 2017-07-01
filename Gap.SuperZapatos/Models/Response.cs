namespace Gap.SuperZapatos.Models
{
    public class Response<T>
    {
        public bool Success { get; set; }
        public int Total_Elements { get; set; }
        //public  T nameof(T) { get; set; }
    }
}