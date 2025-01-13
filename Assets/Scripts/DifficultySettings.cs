using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DifficultySettings : MonoBehaviour
{
    [SerializeField] TMP_Dropdown difficultyDropdown;
    int difficulty;

    private void Awake()
    {
        if (PlayerPrefs.HasKey("difficulty") != true)
        {
            PlayerPrefs.SetInt("difficulty", 0);
        }

        difficulty = PlayerPrefs.GetInt("difficulty");
        difficultyDropdown.value = difficulty;

    }

    public void Difficulty(int selection)
    {
        PlayerPrefs.SetInt("difficulty", selection);
    }
}
