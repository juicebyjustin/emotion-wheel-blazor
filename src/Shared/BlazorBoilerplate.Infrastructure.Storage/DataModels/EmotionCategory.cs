using BlazorBoilerplate.Infrastructure.Storage.Permissions;
using BlazorBoilerplate.Infrastructure.Storage.DataInterfaces;
using System.ComponentModel.DataAnnotations;
using BlazorBoilerplate.Infrastructure.Storage.Base;

namespace BlazorBoilerplate.Infrastructure.Storage.DataModels
{
    [Permissions(Actions.Delete)]
    public partial class EmotionCategory : BaseAuditableEntity, IAuditable, ISoftDelete
    {
        [Key]
        public long Id { get; set; }

        [Required(ErrorMessage = "FieldRequired")]
        [MaxLength(128)]
        public string Title { get; set; }
    }
}