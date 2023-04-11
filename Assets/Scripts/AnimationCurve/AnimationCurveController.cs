using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationCurveController : MonoBehaviour
{
    [SerializeField][Range(0, 10)] private float speed = 1f;
    private Vector3 startPoint;
    private Vector3 endPoint;
    [SerializeField] private float currentTime;
    [SerializeField] private AnimationCurve curve;

    // void Awake() 
    //Wykonuje si� przed Start.

    // void OnValidate()

    // void OnEnable()

    public void Start()
    {
        startPoint = transform.position;
        Debug.Log($"Transform position {transform.position}"); //Dzięki $ mogę dodać do tekstu jakąś wartość w {}.

        endPoint = Vector3.Scale(startPoint, new Vector3(0, 0, -1));
        Debug.Log($"End position {endPoint}");
    }

    public void Update()
    {
        currentTime += Time.deltaTime * speed;
        //To samo jak niżej.
        // currentTime = currentTime + Time.deltaTime * speed

        transform.position = Vector3.LerpUnclamped(startPoint, endPoint, curve.Evaluate(currentTime));
        // LerpUnclamped - krzywa może wyjść poza 1.
    }
}
