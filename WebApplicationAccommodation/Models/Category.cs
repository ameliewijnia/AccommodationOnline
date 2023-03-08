namespace WebApplicationAccommodation.Models
{
    public class Category
    {
        //create all the properties you want on the tabel eg ID, name etc

        public int Id { get; set; }
        public int DisplayOrder { get; set; }
        public DateTime CreatedDateTime { get; set; } = DateTime.Now;
}
}
