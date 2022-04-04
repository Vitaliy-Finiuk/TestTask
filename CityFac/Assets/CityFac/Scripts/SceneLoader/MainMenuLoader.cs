using IJunior.TypedScenes;
using UnityEngine;

namespace CityFac.Scripts
{
    public class MainMenuLoader : MonoBehaviour
    {

        #region LoadingScenes

        public void OnPlayButtonClick()
        {
            MainGame.Load("Main Game Scene Loaded");   
        }

        #endregion
    }
}
