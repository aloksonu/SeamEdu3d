using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


// Create an empty gameobject"LevelManager"
// And Attach this script with that.
// Attach this script with all buttons and assign loadScene(int index) method
public class LevelManager : MonoBehaviour
{
    public Button[] levelButtons;

    private void Awake()
    {
        if (PlayerPrefs.GetInt("levelUnlocked") == 0)
        {
            PlayerPrefs.SetInt("levelUnlocked",1);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < levelButtons.Length; i++) {
            levelButtons[i].interactable = false;
        }
        for (int i = 0; i < PlayerPrefs.GetInt("levelUnlocked"); i++)
        {
            levelButtons[i-1].interactable = true;
        }
    }

   //public void loadScene(int index)
   // {
   //     SceneManager.LoadScene(index);
   // }
}
