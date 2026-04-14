using NUnit.Framework;
using System;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public List<Level> levels;

    public int curLevelNo;
    private Level _curLevel;
    public void RestartLevelManager()
    {
        DeletePreviousLevel();
        CreateNewLevel();
    }

    private void CreateNewLevel()
    {
        var normalizedLevelNo = (curLevelNo-1) % levels.Count;
        _curLevel = Instantiate(levels[normalizedLevelNo]); // instantiate kodu herhangi bir obje oluþturmak istediðim kullanýlýr
        _curLevel.transform.position = Vector3.zero;
    }

    private void DeletePreviousLevel()
    {
        if(_curLevel != null) 
        {
            Destroy(_curLevel.gameObject); // silme kodu
        }
    }
}
