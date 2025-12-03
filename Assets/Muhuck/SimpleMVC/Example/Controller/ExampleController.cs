namespace Muhuck.MVC
{
    using UnityEngine;

    public class ExampleController : Controller
    {
        private ExampleModel model;
        [SerializeField] private ExampleView view;

        void Start()
        {
            Initialize();
        }

        public override void Initialize()
        {
            model = new ExampleModel();
            model.OnDataChanged += OnModelUpdated;

            view.OnAddButtonClicked += HandleAddButton;

            OnModelUpdated();
        }

        private void OnModelUpdated()
        {
            view.SetData(model.count);
        }

        private void HandleAddButton()
        {
            model.AddCount();
        }
    }
}
