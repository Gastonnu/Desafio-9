using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlarmDetector : MonoBehaviour
{

    [SerializeField] private GameObject alarmPoint;
    private float alarmRange = 3.2f; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastAlarm();
    }

    private void RaycastAlarm()
    {
        RaycastHit hit;

        if (Physics.Raycast(alarmPoint.transform.position, alarmPoint.transform.TransformDirection(Vector3.left), out hit, alarmRange))
        {
            Debug.Log("Se activó la alarma");
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawRay(alarmPoint.transform.position, alarmPoint.transform.TransformDirection(Vector3.left) * alarmRange);
    }

}
