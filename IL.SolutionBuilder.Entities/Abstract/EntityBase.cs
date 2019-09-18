using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using IL.Core.Entities;
using IL.SolutionBuilder.Entities.Concrete;

namespace IL.SolutionBuilder.Entities.Abstract
{
    public class EntityBase : IEntity
    {

        private string _created;
        private string _createdBy;
        private string _modified;
        private string _modifiedBy;
        private bool _isDeleted;

        /// <summary>
        /// Gets or sets the entity identifier
        /// </summary>
        [Key]
        public int Id  { get; set; }

        /// <summary>
        /// Gets or sets the entity created time
        /// </summary>
        public string Created
        {
            get
            {
                if (string.IsNullOrEmpty(_created))
                {
                    _created = DateTime.Now.ToUniversalTime().ToString("yyyy-MM-dd'T'HH:mm:ss.fffK", CultureInfo.InvariantCulture);
                }
                return _created;
            }
            set => _created = value;

        }

        /// <summary>
        /// Gets or sets the entity created by
        /// </summary>
        public string CreatedBy
        {
            get => _createdBy ?? (_createdBy = "Default User");
            set => _createdBy = value;
        }

        /// <summary>
        /// Gets or sets the entity modified time
        /// </summary>
        public string Modified
        {
            get
            {
                _modified = DateTime.Now.ToUniversalTime().ToString("yyyy-MM-dd'T'HH:mm:ss.fffK", CultureInfo.InvariantCulture);
                return _modified;
            }
            set => _modified = value;
        }

        /// <summary>
        /// Gets or sets the entity modified by
        /// </summary>
        public string ModifiedBy
        {
            get => _modifiedBy ?? (_modifiedBy = "Default User");
            set => _modifiedBy = value;
        }

        /// <summary>
        /// Gets or sets the entity is deleted
        /// </summary>
        public bool IsDeleted
        {
            get
            {
                _isDeleted = false;
                return _isDeleted;
            }
            set => _isDeleted = value;
        }
    }
}
