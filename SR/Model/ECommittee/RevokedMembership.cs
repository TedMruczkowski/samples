namespace Ecommittees.Model
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("revoked_memberships")]
    public partial class RevokedMembership
    {
        public int id { get; set; }

        public int? committee_id { get; set; }

        public int? person_id { get; set; }

        public DateTime? created_at { get; set; }

        public DateTime? updated_at { get; set; }
    }
}
