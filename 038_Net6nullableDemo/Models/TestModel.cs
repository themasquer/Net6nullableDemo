namespace _038_Net6nullableDemo.Models
{
    public class TestModel
    {
        public int Id { get; set; }
        /*public string? Name { get; set; }*/ // proje özelliklerinde nullable enable olduğu için zorunluluk validasyonuna takılır. string? kullanmak gerekir. Bu durum referans özellikleri için de geçerlidir.
        public string Name { get; set; } // proje özelliklerinde nullable disable yaparsak string? kullanmaya gerek kalmaz. 
    }
}
