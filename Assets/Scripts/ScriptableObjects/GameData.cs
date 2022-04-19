using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
[CreateAssetMenu]
public class GameData : ScriptableObject
{
    // Variabelen
    public string selectedCategoryName;
    public BoardData selectedBoardData;
}
