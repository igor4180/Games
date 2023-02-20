using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GamesDll;

namespace GamesContext
{
    public class GamesContext : DbContext
    {
		public GamesContext(string nameOrConnectionString) : base(nameOrConnectionString)
		{
		}

		public GamesContext(string nameOrConnectionString, DbCompiledModel model) : base(nameOrConnectionString, model)
		{
		}

		public GamesContext(DbConnection existingConnection, bool contextOwnsConnection) : base(existingConnection, contextOwnsConnection)
		{
		}

		public GamesContext(ObjectContext objectContext, bool dbContextOwnsObjectContext) : base(objectContext, dbContextOwnsObjectContext)
		{
		}

		public GamesContext(DbConnection existingConnection, DbCompiledModel model, bool contextOwnsConnection) : base(existingConnection, model, contextOwnsConnection)
		{
		}

		protected GamesContext()
		{
		}

		protected GamesContext(DbCompiledModel model) : base(model)
		{
		}

		DbSet<Games> games { get; set; }
    }
}
