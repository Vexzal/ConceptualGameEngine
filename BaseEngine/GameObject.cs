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
        public Dictionary<Type, Component> components= new Dictionary<Type, Component>();

        public GameObject()
        {
            AddComponent(new TransformComponent());
        }
        public void AddComponent(Component component)
        {
            component.gameObject = this;
            components.Add(component.GetType(), component);
            component.Initialize();
                  
            
        }
        public void RemoveComponent(Component component)
        {
            component.gameObject = null;
            components.Remove(component.GetType());
        }
        public T GetComponent<T>() where T : Component
        {
            
            //dictionary 
            if(components.ContainsKey(typeof(T)))
            {
                return (T)components[typeof(T)];
            }
            
            return default(T);            

        }
    }
}
