using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Design_Pattern.Composite_Pattern
{
    public abstract class DishComposite : IComponent
    {
        protected readonly List<IComponent> children = new();

        public DishComposite(string name)
        {
            Name = name;
        }
        public string Name { get; }
        public virtual string Type => GetType().Name;
        public virtual int Count => children.Sum(child => child.Count);
        public int subCount => children.Count;
        public virtual IEnumerable Children
            => new ReadOnlyCollection<IComponent>(children);

        public virtual void Add(IComponent dishComponent)
        {
            children.Add(dishComponent);
        }
        public virtual void Remove(IComponent dishComponent)
        {
            children.Remove(dishComponent);
        }
    }
}
