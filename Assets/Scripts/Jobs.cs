
using System;
using Unity.VisualScripting;
using UnityEngine;

public class Jobs : MonoBehaviour
{
    public string[] _jobs;
    public float[] _stats;
    public string[] _statnames;
    [SerializeField] public int _statlength;
    [SerializeField] public int _jobAmt;

    
    public void Awake() { 
        _jobs = new string[_jobAmt];
        _stats = new float[_statlength];
        _statnames = new string[_statlength];
      
        JobListings();
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
