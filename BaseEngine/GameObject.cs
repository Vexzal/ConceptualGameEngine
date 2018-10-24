using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseEngine.Components;

namespace BaseEngine
{
    public class GameObject
    {
        public string name;
        public List<Component> components = new List<Component>();
        public Dictionary<Type, Component> componentss = new Dictionary<Type, Component>();
        public GameObject()
        {
            //obsolete
            //components.Add(new TransformComponent());
            AddComponent(new TransformComponent());
        }
        public void AddComponent(Component component)
        {
            component.gameObject = this;
            components.Add(component);
            component.Initialize();
            //dictionary
            componentss.Add(component.GetType(), component);
            
        }
        public void RemoveComponent(Component component)
        {
            component.gameObject = null;
            components.Remove(component);
        }
        public T GetComponent<T>() where T : Component
        {
            //implementation one
            if(components.OfType<T>().Any())
            {
                //return components.OfType<T>().ToList()[0];                

            }
            //dictionary 
            if(componentss.ContainsKey(typeof(T)))
            {
                return (T)componentss[typeof(T)];
            }
            //implementation two            
            foreach(Component component in components)
            {
                if (component is T)
                    return (T)component;
            }
            return default(T);
            //    if(component is T)
            //    {
            //        return (T)component;
            //    }
            //}
            //default



        }
    }
}
