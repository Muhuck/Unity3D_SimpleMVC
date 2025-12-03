namespace Muhuck.MVC
{
    using System;
    using TMPro;
    using UnityEngine;
    using UnityEngine.UI;

    public class ExampleView : View
    {
        [SerializeField] private TextMeshProUGUI txtSample;
        [SerializeField] private Button addButton;
        public event Action OnAddButtonClicked;
        private int currentCount;

        void Awake()
        {
            addButton.onClick.AddListener(() =>
            {
               OnAddButtonClicked?.Invoke(); 
            });
        }

        public void SetData(int count)
        {
            currentCount = count;
            Refresh();
        }

        public override void Refresh()
        {
            if(txtSample != null)
            {
                txtSample.text = "Count : " + currentCount;
            }
        }
    }
}