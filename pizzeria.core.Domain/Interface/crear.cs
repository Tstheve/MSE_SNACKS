using System;
using System.Collections.Generic;
using System.Text;

namespace pizzeria.core.Domain.Interface
{
    internal interface crear
    {

    }
        public interface ICrear<Entity>
    {
        Entity create(Entity entity);
    }
}
