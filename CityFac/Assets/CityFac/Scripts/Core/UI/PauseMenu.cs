using IJunior.TypedScenes;
using UnityEngine;

namespace CityFac.Scripts.UI
{
    public class PauseMenu : MonoBehaviour
    {
        private const string MenuLoaded = "Menu Loaded";

        [SerializeField] private GameObject _pauseMenuUI;
        
        private bool _gameIsPaused;

        private void Start()
        {
            _gameIsPaused = false;
        }

        private void Update()
        {
            PauseHandler();
        }

        private void PauseHandler()
        {
            if (PlayerInput.MenuPauseInput())
            {
                if (_gameIsPaused)
                    Resume();
                else
                    Pause();
            }
        }

        #region Menu

        private void Pause()
        {
            _pauseMenuUI.SetActive(true);
            Time.timeScale = 0f;
            _gameIsPaused = true;
        }

        public void Resume()
        {
            _pauseMenuUI.SetActive(false);
            Time.timeScale = 1f;
            _gameIsPaused = false;
        }

        public void LoadMenu()
        {
            Menu.Load(MenuLoaded);
        }

        public void Quit()
        {
            Application.Quit();
            Debug.Log("Quit");
        }

        #endregion
    }
}
