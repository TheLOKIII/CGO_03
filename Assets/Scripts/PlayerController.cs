using UnityEngine;
using System;
using System.Collections.Generic;
using System.Collections;



public class PlayerController : MonoBehaviour
{
    public enum TargetEnum
    {
        TopLeft,
        TopRight,
        BottomLeft,
        BottomRight,
    }
    [SerializeField] public float speed; //Dùng để thay đổi tốc độ

    public Transform topLeftTarget;
    public Transform topRightTarget;
    public Transform bottomLeftTarget;
    public Transform bottomRightTarget;

    private Transform currentTarget;
    private TargetEnum nextTarget = TargetEnum.TopLeft; //Trạng thái đầu tiên;
    public Vector3[] point;
    public GameObject player;
    private void Start()
    {
        Debug.Log(speed);
        currentTarget = topLeftTarget;

    }

    private void Update()
    {
        Vector3 targetPostion = currentTarget.position;
        Vector3 moveDirection = targetPostion - transform.position;

        float distance = moveDirection.magnitude;

        if (distance > 0.1f) //Khi chưa tới thì vẫn di chuyển đến focus
        {
            transform.position = Vector3.MoveTowards(transform.position, currentTarget.position, speed * Time.deltaTime);
        }

        else
        {
            //chuyển Target
            SetNextTarget(nextTarget);
        }

        Vector3 direction = currentTarget.position - transform.position;
        Quaternion targetRotation = Quaternion.LookRotation(direction, Vector3.up);
        transform.rotation = targetRotation;
    }
    private void SetNextTarget(TargetEnum target)
    {
        switch (target)
        {
            case TargetEnum.TopLeft:
                currentTarget = topLeftTarget;
                nextTarget = TargetEnum.TopRight;
                break;
            case TargetEnum.TopRight:
                currentTarget = topRightTarget;
                nextTarget = TargetEnum.BottomLeft;
                break;
            case TargetEnum.BottomLeft:
                currentTarget = bottomLeftTarget;
                nextTarget = TargetEnum.BottomRight;
                break;
            case TargetEnum.BottomRight:
                currentTarget = bottomRightTarget;
                nextTarget = TargetEnum.TopLeft;
                break;
        }
    }
}
