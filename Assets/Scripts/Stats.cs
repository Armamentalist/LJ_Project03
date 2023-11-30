
using UnityEngine;

public class Stats : MonoBehaviour
{
    //place any stats here vvv
    private int HP;
    private int STR;
    private int MAG;
    private int AGI;
    private int DEF;
    private int RES;
    //place any stats here ^^^
    private LevellingSystem _classPick;
    private LevellingSystem _CurLevel;
    
    public void Awake()
    {
        
        StartStats();
    }
    public void Update()
    {
        Improvement();
        if (Input.GetKeyDown(KeyCode.H))
        {
            Debug.Log("Stats; HP: " + HP + " STR: " + STR + " MAG: " + MAG + " AGI: " + AGI + " DEF: " + DEF + " RES: " + RES);
        }
     }
    public void StartStats()
    {
        _classPick = GetComponent<LevellingSystem>();
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
    }
    public void Improvement()
    {
        _classPick = GetComponent<LevellingSystem>();
        _CurLevel = GetComponent<LevellingSystem>();
        if (_CurLevel._currentExperience > _CurLevel._maxExperience)
        {
            if(_classPick._class == Jobs.Warrior)
            {
                HP += 2;
                STR += 1;
                DEF += 1;
               
            }
        }
    }

}