using UnityEngine;

public class ExecutionOrderSample1 : MonoBehaviour
{
    #region PRIVATE VARIABLES

    private ExecutionOrderSample2 _sample2;

    private int _randomValue;

    #endregion

    #region UNITY METHODS
    private void Awake()
    {
        _sample2 = FindObjectOfType<ExecutionOrderSample2>(); 
    }

    private void Start()
    { 
        _randomValue = _sample2.GetRandomValue();
    }

    #endregion
}
