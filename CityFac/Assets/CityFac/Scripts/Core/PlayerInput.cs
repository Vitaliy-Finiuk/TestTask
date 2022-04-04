using UnityEngine;

namespace CityFac.Scripts
{
    public class PlayerInput : MonoBehaviour
    {
        public static bool MenuPauseInput()
        {
            return Input.GetKeyDown(KeyCode.Escape);
        }
    }
}