using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCameraPosition : MonoBehaviour
{
    public List<DataPosition> tarjetPositions;
    public GameObject mainCamera;

    Vector3 position;
    Quaternion rotation;




    public void ChangeToPosition(int numPos)
    {
        if (numPos > tarjetPositions.Count || numPos < 0)
            return;
        position = tarjetPositions[numPos].transform.position;
        rotation = tarjetPositions[numPos].transform.rotation;
        mainCamera.transform.position = position;
        mainCamera.transform.rotation = rotation;
    }

    [System.Serializable]
    public class DataPosition
    {
        public Transform transform;
    }

}
