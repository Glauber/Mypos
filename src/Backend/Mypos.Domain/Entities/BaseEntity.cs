using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mypos.Domain.Entities
{
    public abstract class BaseEntity
    {
        [Key]
        public int Id { get; set; }

		private DateTime _createAt;

		public DateTime CreateAt
		{
			get { return _createAt; }
			set { _createAt = !value.Equals(default(DateTime)) ? value : DateTime.UtcNow; }
		}

        private DateTime _updateAt;

        public DateTime UpdateAt
        {
            get { return _updateAt; }
            set { _updateAt = !value.Equals(default(DateTime)) ? value : DateTime.UtcNow; }
        }

    }
}
