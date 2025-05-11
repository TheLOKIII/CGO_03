using UnityEngine;
using System.Collections.Generic;
using System.Collections;


public enum GameState
{
    MainMenu,
    IsGame,
    Paused,
    GameOver,
}


public enum DayOfWeek
{
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,

}
public class Lesson03 : MonoBehaviour
{
    public GameObject pointA;
    public GameObject pointB;

    private void Update()
    {
        //Tính khoảng cách từ PointA  và Point B
        float Distance = (pointA.transform.position - pointB.transform.position).magnitude;
        Debug.Log("Khoảng cách giữ 2 điểm A và B: " + Distance);

    }
}