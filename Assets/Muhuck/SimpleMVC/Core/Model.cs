namespace Muhuck.MVC
{
    using System;

    public abstract class Model
    {
        public event Action OnDataChanged;

        protected void NotifyChanged(){
            OnDataChanged?.Invoke();
        }
    }

    
}

