using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinPopup : MonoBehaviour
{

    public GameObject winPopup;

    void Start()
    {
        winPopup.SetActive(false); // Zorgt ervoor dat de popup niet gelijk geactiveerd wordt als de game start.
    }

    private void OnEnable()
    {
        GameEvents.OnBoardCompleted += ShowWinPopup;
    }

    private void OnDisable()
    {
        GameEvents.OnBoardCompleted -= ShowWinPopup;
    }

    private void ShowWinPopup()
    {
        winPopup.SetActive(true);
    }

    public void LoadNextLevel()
    {
        GameEvents.LoadNextLevelMethod();
    }

}
