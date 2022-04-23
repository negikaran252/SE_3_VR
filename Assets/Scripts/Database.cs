using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName="New DB", menuName="Database")]
public class Database : ScriptableObject
{
    public int[] scores = new int[10];
    public int cur = 0;
    public int prev = 0;
}
