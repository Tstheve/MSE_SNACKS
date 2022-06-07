using System;
using System.Collections.Generic;
using System.Text;

namespace pizzeria.core.Domain.Interface
{
    internal interface IUpdate
    {
    }
    public interface IUpdate<Entity>
    { Entity Update(Entity entity);
    }
}
