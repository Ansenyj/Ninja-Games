using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : System.IComparable<Score>
{
    public string name;
    public float score;
    public Score(string n, float s) { name = n; score = s; }
    public int CompareTo(Score other)
    {
        if (other == null)
            return 0;
        int value = (int)(other.score - this.score);
        return value;
    }
    public override string ToString()//debug用
    {
        return name + " : " + score.ToString();
    }
}
