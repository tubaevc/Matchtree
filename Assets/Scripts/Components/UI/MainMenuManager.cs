using DefaultNamespace;
using Events;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using Zenject;


namespace Components.UI
{
    public class MainMenuManager: MonoBehaviour
    {
        [SerializeField] private GameObject _mainMenuPanel;
        [SerializeField] private GameObject _settingsMenuPanel;
        private MainMenuEvents _mainMenuEvents;

        [Inject]
        public void Construct(MainMenuEvents mainMenuEvents)
        {
            _mainMenuEvents = mainMenuEvents;
        }

        private void Start()
        {
            SetPanelActive(_mainMenuPanel);
        }

        public void OnNewGameButtonClicked()
        {
            Debug.Log("New Game button clicked!");
            UnityEngine.SceneManagement.SceneManager.LoadScene("GameScene");
        }
        private void SetPanelActive(GameObject panel)
        {
            _mainMenuPanel.SetActive(_mainMenuPanel == panel);
            _settingsMenuPanel.SetActive(_settingsMenuPanel == panel);
        }

        private void OnEnable()
        {
            _mainMenuEvents.SettingsBTN += OnSettingsBTN;
            _mainMenuEvents.SettingsExitBTN += OnSettingsExitBTN;
            _mainMenuEvents.NewGameBTN += OnNewGameBTN;
            
        }

        private void OnDisable()
        {
            _mainMenuEvents.SettingsBTN -= OnSettingsBTN;
            _mainMenuEvents.SettingsExitBTN -= OnSettingsExitBTN;
            _mainMenuEvents.NewGameBTN -= OnNewGameBTN;
        }

        private void OnSettingsBTN()
        {
            SetPanelActive(_settingsMenuPanel);
        }

        private void OnSettingsExitBTN()
        {
            SetPanelActive(_mainMenuPanel);
        }

        public void OnNewGameBTN()
        {
            Debug.Log("new game button clicked");
            SceneManager.LoadScene(EnvVar.MainSceneName);
        }
       
    }
}