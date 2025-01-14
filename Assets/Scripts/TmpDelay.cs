using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TmpDelay : MonoBehaviour
{
   
    public GameObject DifficultyMenu;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void WaitSeconds()
    {
        Invoke("Wait", 3.7f);
        print("Done!");
    }
    
    public void Wait()
    {
        DifficultyMenu.SetActive(true);
        print("Done1");
    }

    public void Stop()
    {
        DifficultyMenu.SetActive(false);
        print("Done2");
    }
}
