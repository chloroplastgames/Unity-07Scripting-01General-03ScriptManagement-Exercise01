using System.Linq;
using UnityEngine;

public class ExecutionOrderSample2 : MonoBehaviour
{
    #region PRIVATE VARIABLES

    private int[] _randomValues;

    private readonly System.Random _random = new System.Random();

    #endregion

    #region UNITY METHOD
    private void Awake()
    {
        GenerateRandomValues();
    }
    #endregion

    #region OWN METHODS

    public int GetRandomValue()
    {
        var index = _random.Next(0, 19);
        return _randomValues[index];
    }

    private void GenerateRandomValues()
    { 
        _randomValues = Enumerable.Range(0, 20).Select(x => _random.Next(0, 300)).ToArray();
    }

    #endregion

}
