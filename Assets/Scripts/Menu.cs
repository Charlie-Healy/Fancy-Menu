using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    
    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
        Application.Quit();
        print("Game has quit");
    }

    public void StartMenuGo()
    {
        SceneManager.LoadScene(0);
    }

    public void PlayLevelOne()
    { 
        SceneManager.LoadScene(2);
    }

    
}
