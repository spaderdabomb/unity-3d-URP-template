using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class MainMenu : MonoBehaviour
{
    [SerializeField] UIDocument mainMenuDocument;

    private Button settingsButton;
    private Button achievementsButton;
    private Button playButton;
    private void Awake()
    {
        VisualElement root = mainMenuDocument.rootVisualElement;

        settingsButton = root.Q<Button>("SettingsButton");
        achievementsButton = root.Q<Button>("AchievementsButton");
        playButton = root.Q<Button>("PlayButton");

        settingsButton.clickable.clicked += ShowSettingsMenu;
        achievementsButton.clickable.clicked += ShowAchievementsMenu;
        playButton.clickable.clicked += PlayGame;
    }

    private void ShowSettingsMenu()
    {
        print("Showing settings menu");
    }

    private void ShowAchievementsMenu()
    {
        print("Showing achievements menu");
    }

    private void PlayGame()
    {
        SceneManager.LoadScene("GameScene");
    }
}
