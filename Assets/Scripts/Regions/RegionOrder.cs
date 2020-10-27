using System;
using UnityEngine;

public class RegionOrder : MonoBehaviour
{
    #region PUBLIC VARIABLES

    public string publicVariableSample;

    public int PublicPropertySample { get; set; }

    #endregion

    #region EVENT

    public Action EventSample;

    #endregion

    #region PRIVATE VARIABLES

    private string _privateVariableSample;

    #endregion

    #region UNITY METHOD

    private void Awake()
    {

    }

    public void Start()
    {

    }

    #endregion 

    #region OWN METHODS

    private void PrivateSampleMethod()
    {

    } 

    public void PublicSampleMethod()
    {

    }

    private void OnEventSample()
    {
        if (EventSample != null)
        {
            EventSample.Invoke();
        }
    }

    #endregion
}
