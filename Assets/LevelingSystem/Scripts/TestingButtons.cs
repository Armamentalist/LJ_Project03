using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class TestingButtons : MonoBehaviour
{
    private LevellingSystem _Level;
    private Stats _stats;

    void Update()
    {
        //temp button pressing to test leveling up; Can be removed for gaining EXP by other means
        if (Input.GetKeyDown(KeyCode.G))
        {
            _Level = GetComponent<LevellingSystem>();
            _Level._currentExperience += 27;
            Debug.Log("Level: " + _Level._currentLevel + " / EXP: " + _Level._currentExperience + "/" + _Level._maxExperience);
        }
        //temp button to test stats
        if (Input.GetKeyDown(KeyCode.H))
        {
            _stats = GetComponent<Stats>();
            Debug.Log("Stats; HP: " + _stats.HP + " STR: " + _stats.STR + " MAG: " + _stats.MAG + 
                " AGI: " + _stats.AGI + " DEF: " + _stats.DEF + " RES: " + _stats.RES);
        }
    }
}
