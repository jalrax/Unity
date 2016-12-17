using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SmartLocalization;

public class MyLocalizedScripts : MonoBehaviour
{
    //Main Menu
    private int currentScreen;
    public string startKey = "Start";
    public string loadKey = "Load";
    public string optionsKey = "Options";
    public string quitKey = "Quit";

    public string backKey = "Back";

    //Start Menu
    public string easyKey = "Easy";
    public string mediumKey = "Medium";
    public string hardKey = "Hard";

    //Load Menu
    public string autoLoadKey = "Autosave";
    public string quickLoadKey = "Quicksave";

    //Options Menu
    public string enLangKey = "English";
    public string ruLangKey = "Russian";

    private void OnGUI()
    {
        if (currentScreen == 0)
        {
            if (GUI.Button(new Rect(Screen.width / 2 - 100, Screen.height / 2 - 50, 200, 45), LanguageManager.Instance.GetTextValue(startKey)))
            {
                currentScreen = 1;
            }
            if (GUI.Button(new Rect(Screen.width / 2 - 100, Screen.height / 2, 200, 45), LanguageManager.Instance.GetTextValue(loadKey)))
            {
                currentScreen = 2;
            }
            if (GUI.Button(new Rect(Screen.width / 2 - 100, Screen.height / 2 + 50, 200, 45), LanguageManager.Instance.GetTextValue(optionsKey)))
            {
                currentScreen = 3;
            }
            if (GUI.Button(new Rect(Screen.width / 2 - 100, Screen.height / 2 + 100, 200, 45), LanguageManager.Instance.GetTextValue(quitKey)))
            {
                QuitGame();
            }
        }

        if (currentScreen == 1)
        {
            if (GUI.Button(new Rect(Screen.width / 2 - 100, Screen.height / 2 - 50, 200, 45), LanguageManager.Instance.GetTextValue(easyKey))) { }
            if (GUI.Button(new Rect(Screen.width / 2 - 100, Screen.height / 2, 200, 45), LanguageManager.Instance.GetTextValue(mediumKey))) { }
            if (GUI.Button(new Rect(Screen.width / 2 - 100, Screen.height / 2 + 50, 200, 45), LanguageManager.Instance.GetTextValue(hardKey))) { }
            if (GUI.Button(new Rect(Screen.width / 2 - 100, Screen.height / 2 + 100, 200, 45), LanguageManager.Instance.GetTextValue(backKey)))
            {
                currentScreen = 0;
            }
        }

        if (currentScreen == 2)
        {
            if (GUI.Button(new Rect(Screen.width / 2 - 100, Screen.height / 2 - 50, 200, 45), LanguageManager.Instance.GetTextValue(autoLoadKey))) { }
            if (GUI.Button(new Rect(Screen.width / 2 - 100, Screen.height / 2, 200, 45), LanguageManager.Instance.GetTextValue(quickLoadKey))) { }
            if (GUI.Button(new Rect(Screen.width / 2 - 100, Screen.height / 2 + 100, 200, 45), LanguageManager.Instance.GetTextValue(backKey)))
            {
                currentScreen = 0;
            }
        }

        if (currentScreen == 3)
        {
            if (GUI.Button(new Rect(Screen.width / 2 - 100, Screen.height / 2 - 50, 200, 45), LanguageManager.Instance.GetTextValue(enLangKey)))
            {
                LanguageManager.Instance.ChangeLanguage("en");
            }
            if (GUI.Button(new Rect(Screen.width / 2 - 100, Screen.height / 2, 200, 45), LanguageManager.Instance.GetTextValue(ruLangKey)))
            {
                LanguageManager.Instance.ChangeLanguage("ru");
            }
            if (GUI.Button(new Rect(Screen.width / 2 - 100, Screen.height / 2 + 100, 200, 45), LanguageManager.Instance.GetTextValue(backKey)))
            {
                currentScreen = 0;
            }
        }
    }

    public void QuitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
       Application.Quit();
#endif
    }
}

