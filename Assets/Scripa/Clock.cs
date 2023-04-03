using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class Clock : MonoBehaviour
{
    

    const float hoursToDegrees = -30f, minutesToDegrees = -6f, secondsToDegrees = -6f;

    [SerializeField]
    Transform hoursArmPivot;

    [SerializeField]
    Transform MinuteArmPivot;

    [SerializeField]
    Transform SecondArmPivot;

    private void Update () {
        
        TimeSpan time = DateTime.Now.TimeOfDay;

        Debug.Log(DateTime.Now.Hour);

        hoursArmPivot.localRotation = Quaternion.Euler(0f, 0f, hoursToDegrees * (float)time.TotalHours);

        MinuteArmPivot.localRotation =
			Quaternion.Euler(0f, 0f, minutesToDegrees * (float) time.TotalMinutes);

		SecondArmPivot.localRotation =
			Quaternion.Euler(0f, 0f, secondsToDegrees * (float)time.TotalSeconds);
    }

    // Start is called before the first frame update
    void Start()
    {
    
    








        
    }
}
