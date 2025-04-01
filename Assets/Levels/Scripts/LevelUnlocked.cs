using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelUnlocked : MonoBehaviour
{
  
    public void levelUnlocked(int nextLevel)
    {
        PlayerPrefs.SetInt("levelUnlocked", nextLevel);
    }
}
