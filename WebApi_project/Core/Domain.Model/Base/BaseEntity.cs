﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Domain.Model.Base
{
    /// <summary>
    /// Abstraction over all entities.
    /// </summary>
    public abstract class BaseEntity
    {
        /// <summary>
        /// Id of entity.
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Time of creation.
        /// </summary>
        public DateTime InsTs { get; set; }

        /// <summary>
        /// Time of update.
        /// </summary>
        public DateTime? UpdTs { get; set; }
    }
}
