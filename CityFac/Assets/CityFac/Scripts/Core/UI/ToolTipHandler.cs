using TMPro;
using UnityEngine;

namespace CityFac.Scripts.UI
{
    public class ToolTipHandler : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI _textComponent;

        public static ToolTipHandler Instance;


        private void Awake()
        {
            if (Instance != null && Instance != this)
                Destroy(this.gameObject);
            else
                Instance = this;
        }

        private void Start()
        {
            gameObject.SetActive(false);
        }
        

        public void SetAndShowToolTip(string message)
        {
            gameObject.SetActive(true);
            _textComponent.text = message;
        }

        public void HideToolTip()
        {
            gameObject.SetActive(false);
            _textComponent.text = string.Empty;
        }
    }
}