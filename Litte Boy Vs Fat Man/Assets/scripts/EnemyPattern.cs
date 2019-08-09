using UnityEngine;

public class EnemyPattern : MonoBehaviour
{
    public int patternNo;
    public int GetPatternNo()
    {
        return patternNo;
    }

    public void SetPatternNo (int num)
    {
        patternNo = num;
    }

    public Vector3 initPos;
    public Vector3 increment;


    public Vector3 GetInitPos()
    {
        return initPos;
    }

    public void SetInitPos(Vector3 pos)
    {
        initPos = pos;
    }

    public Vector3 GetIncrement()
    {
        return increment;
    }

    public void SetIncrement(Vector3 pos)
    {
        increment = pos;
    }
}
