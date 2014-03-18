using System;

namespace LetsBuyLocal.SDK.Models
{
    /// <summary>
    /// Represents an entity, any entity represented in these models.
    /// </summary>
    public class BaseEntity
    {
        /// <summary>
        /// Gets or sets the identifier for the entity.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public virtual string Id { get; set; }

        public DateTime? Created { get; set; }

        public DateTime LastModified { get; set; }
    }
}
