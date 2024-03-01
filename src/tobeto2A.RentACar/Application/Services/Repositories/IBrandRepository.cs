using Domain.Entities;
using NArchitecture.Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Org.BouncyCastle.Asn1.Cmp.Challenge;

namespace Application.Services.Repositories;
public interface IBrandRepository : IAsyncRepository<Brand, Guid>, IRepository<Brand, Guid>
{

}