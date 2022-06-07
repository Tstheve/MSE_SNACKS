using System;
using System.Collections.Generic;
using System.Text;

namespace pizzeria.core.Domain.Interface
{
    internal interface IRead
    { }
    public interface ILeer<Entity, Entuty>
    {
        Entity GetById(Entity entity);
        List<Entity> GetAll();
    }   
}
