
using UnityEngine;

public class Stats : MonoBehaviour
{
    //Note: stats need to be public in order to be editted by level ups
    //place any stats here vvv
    public int HP;
    public int STR;
    public int MAG;
    public int AGI;
    public int DEF;
    public int RES;
    //place any stats here ^^^
    private LevellingSystem _classPick;
    
    public void Awake()
    {
        
        StartStats();
    }

    public void StartStats()
    {
        _classPick = GetComponent<LevellingSystem>();
        //Add if statments here with each stat to set starting stats for each class vvv
        if (_classPick._class == Jobs.Warrior)
        {
            HP = 10;
            STR = 5;
            MAG = 2;
            AGI = 3;
            DEF = 5;
            RES = 1;
            Debug.Log("Stats; HP: "+HP+" STR: " +STR+ " MAG: " + MAG+" AGI: " +AGI+ " DEF: "+DEF + " RES: " +RES);
        }
        if (_classPick._class == Jobs.Thief)
        {
            HP = 8;
            STR = 2;
            MAG = 1;
            AGI = 5;
            DEF = 2;
            RES = 3;
            Debug.Log("Stats; HP: " + HP + " STR: " + STR + " MAG: " + MAG + " AGI: " + AGI + " DEF: " + DEF + " RES: " + RES);
        }
        if (_classPick._class == Jobs.Mage)
        {
            HP = 6;
            STR = 1;
            MAG = 5;
            AGI = 4;
            DEF = 1;
            RES = 3;
            Debug.Log("Stats; HP: " + HP + " STR: " + STR + " MAG: " + MAG + " AGI: " + AGI + " DEF: " + DEF + " RES: " + RES);
        }
        if (_classPick._class == Jobs.Cleric)
        {
            HP = 12;
            STR = 2;
            MAG = 3;
            AGI = 3;
            DEF = 4;
            RES = 3;
            Debug.Log("Stats; HP: " + HP + " STR: " + STR + " MAG: " + MAG + " AGI: " + AGI + " DEF: " + DEF + " RES: " + RES);
        }
        //Add if statments here with each stat to set starting stats for each class ^^^
    }

}