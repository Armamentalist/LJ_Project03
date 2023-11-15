
using System;
using Unity.VisualScripting;
using UnityEngine;

public class Jobs : MonoBehaviour
{
    [Header("Jobs")]
    //place any jobs here; String first, then int array second vvv
    public string Fighter;
    public int[] FighterStats;

    //place any jobs here ^^^
    public void Awake() { 
      
      
     //   JobListings();
    }
    public void JobListings()
    {
      //  void ForEach(string[] _statnames, string[] _jobs)
        //{
        //    Debug.Log(_jobs.Length + " " + _statnames.Length + " " + _stats.Length);
        //    print(_jobs.Length + " " + _statnames.Length + " " + _stats.Length);
       // }
    }
}
