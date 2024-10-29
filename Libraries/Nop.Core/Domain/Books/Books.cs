using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nop.Core.Domain.Seo;
using Nop.Core.Domain.Stores;

namespace Nop.Core.Domain.Books;
public class Books : BaseEntity, IStoreMappingSupported
{
    public string Name { get; set; }
    public DateTime CreatedOn { get; set; }
    public bool LimitedToStores { get; set; }
}
