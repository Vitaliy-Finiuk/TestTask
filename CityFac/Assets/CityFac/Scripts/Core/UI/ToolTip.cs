using UnityEngine;

namespace CityFac.Scripts.UI
{
    public class ToolTip : MonoBehaviour
    {
        [SerializeField] private string _message;

        private void OnMouseEnter()
        {
            ToolTipHandler.Instance.SetAndShowToolTip(_message);
        }

        private void OnMouseExit()
        {
            ToolTipHandler.Instance.HideToolTip();
        }
    }
}