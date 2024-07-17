using UnityEngine.Events;

namespace Events
{
    public  class MainMenuEvents
    {

        public static MainMenuEvents Instance { get; } = new MainMenuEvents();
        public  UnityAction SettingsBTN;
        public UnityAction SettingsExitBTN;
        public  UnityAction NewGameBTN;
        // public static UnityAction<float> SoundValueChanged;
        // public static UnityAction<bool> VibrationValueChanged;
    }
}