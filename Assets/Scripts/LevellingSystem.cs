
using UnityEngine;

public class LevellingSystem : MonoBehaviour
{
    //May need to make these arrays in order to work with the other scripts
    [SerializeField] public float _currentExperience = 0;
    [SerializeField] public float _maxExperience = 100;
    [SerializeField] public float _currentLevel = 1;
    [SerializeField] public float _maxLevel = 10;
    public Jobs _class;

    public void Awake()
    {
    }
    //temp button pressing to test leveling up
    public void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.G))
        {
            _currentExperience += 27;
            Debug.Log("Level: " + _currentLevel +" / EXP: " + _currentExperience + "/" + _maxExperience);
        }
        LevelUp();
    }
    public void LevelUp()
    {
        if(_currentExperience > _maxExperience)
        {
            if(_currentLevel < _maxLevel)
            {
                _currentLevel += 1;
                Debug.Log("Character has leveled up. EXP: " + _currentExperience + "/" + _maxExperience);
                _currentExperience = _currentExperience - _maxExperience;
            }
        }
        else if( _currentLevel == _maxLevel) {
            Debug.Log("Character is max level");
        }
    }
}
