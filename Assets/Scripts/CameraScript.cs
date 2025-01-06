using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class CameraScript : MonoBehaviour
{

    public int cameraTemp;
    //ButtonScript ButtonScript;

    [SerializeField][Range(0f, 4f)] float lerpTime;
    [SerializeField][Range(0f, 4f)] float quaternionTime;
    [SerializeField] Vector3[] myPositions;
    [SerializeField] Quaternion[] myRotations;
    
    public int posIndex = 0;
    public int rotIndex = 0;

    float step;
    Vector3 start, end;
    
    

    // Start is called before the first frame update
    void Start()
    {
        step = Time.deltaTime;
        posIndex = 0;
        rotIndex = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, myPositions[posIndex], 0.01f);
        transform.rotation = Quaternion.Slerp(transform.rotation, myRotations[rotIndex], 0.01f);
    }

    public void SetIndex( int index)
    {
        posIndex = index;
        print("setting index to " + index);
        
    }

    public void SetRotIndex( int index)
    {
        rotIndex = index;
    }

}
