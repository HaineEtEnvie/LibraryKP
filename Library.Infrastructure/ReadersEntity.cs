namespace Library.Infrastructure
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ReadersEntity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ReadersEntity()
        {
            Extradition = new HashSet<ExtraditionEntity>();
        }

        public long id { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string firstname { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string secondname { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string lastname { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string phonenumber { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string adress { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ExtraditionEntity> Extradition { get; set; }
    }
}
