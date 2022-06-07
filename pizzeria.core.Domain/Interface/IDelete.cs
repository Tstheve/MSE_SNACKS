using System;
using System.Collections.Generic;
using System.Text;

namespace pizzeria.core.Domain.Interface
{
    internal interface IDelete
    {
    }
    public interface IDelete<Entity>
    { void Delete(Entity entity);
    }
}
