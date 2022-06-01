namespace ShopAdmin
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Mobile
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        public string Company { get; set; }

        public int Flash { get; set; }

        public int SSD { get; set; }

        public int Processor { get; set; }

        public double Price { get; set; }
    }
}
