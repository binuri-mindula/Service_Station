namespace Test_app.Models
{
    public class VehicalService
    {
        //POCO - Plain Old Class Object
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Cost { get; set; }
        public bool IsDeleted { get; set; }
    }
}
