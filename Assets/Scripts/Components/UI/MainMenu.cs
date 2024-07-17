using Events;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Components.UI
{
    public class MainMenu : MonoBehaviour
    {
        [SerializeField] private Button newGameButton;
        [SerializeField] private Button settingsButton;

        private MainMenuEvents _mainMenuEvents;

        [Inject]
        public void Construct(MainMenuEvents mainMenuEvents)
        {
            _mainMenuEvents = mainMenuEvents;
        }

        private void Start()
        {
            newGameButton.onClick.AddListener(OnNewGameButtonClicked);
            settingsButton.onClick.AddListener(OnSettingsButtonClicked);
        }

        private void OnNewGameButtonClicked()
        {
            _mainMenuEvents.NewGameBTN?.Invoke();
            Debug.Log("new game clicked");
        }

        private void OnSettingsButtonClicked()
        {
            _mainMenuEvents.SettingsBTN?.Invoke();
        }

      
    }
}