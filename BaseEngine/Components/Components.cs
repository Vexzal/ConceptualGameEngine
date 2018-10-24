using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseEngine;

namespace BaseEngine.Components
{
    public abstract class Component
    {
        public GameObject gameObject;
        public abstract void OnAddComponent();
        public abstract void Initialize();

        public Component()
        {
            
        }
        public Component(GameObject _gameObject)
        {
            gameObject = _gameObject;
        }


    }
}
