using BlazorBoilerplate.Infrastructure.Storage.DataModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorBoilerplate.Infrastructure.Storage.Base
{
    public abstract class BaseAuditableEntity
    {
        [Column(TypeName = "datetime2(7)")]
        public DateTime CreatedOn { get; set; }

        [Column(TypeName = "datetime2(7)")]
        public DateTime? ModifiedOn { get; set; }

        public ApplicationUser CreatedBy { get; set; }

        public Guid? CreatedById { get; set; }

        public ApplicationUser ModifiedBy { get; set; }

        public Guid? ModifiedById { get; set; }
    }
}
