using System.ComponentModel.DataAnnotations.Schema;

namespace ExtraedgePractice.Model
{
    [Table("Book")]
    public class Book
    {
        //  [id]
        //,[name]
        //,[author]
        //,[price]
        //,[isActive]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public int Price { get; set; }
        public int IsActive { get; set; }
    }
}
