using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum RoomType { Initial, Normal, Boss, FinalBoss, Shop, Rest }
public class Room : MonoBehaviour {

    [SerializeField] RoomType type;
    public int exitCount = 1;

}
