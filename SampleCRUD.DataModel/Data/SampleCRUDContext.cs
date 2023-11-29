using Duende.IdentityServer.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCRUD.DataModel.Data
{
    public partial class SampleCRUDContext : ApiAuthorizationDbContext<ApplicationUser>
    {

        public SampleCRUDContext(DbContextOptions options, IOptions<OperationalStoreOptions> operationalStoreOptions)
         : base(options, operationalStoreOptions)
        {

        }
        public virtual DbSet<SettingDataModel> Setting { get; set; }


    }
}
