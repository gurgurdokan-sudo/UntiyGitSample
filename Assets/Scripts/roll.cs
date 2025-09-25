using UnityEngine;

public class roll : MonoBehaviour
{
   public float rollX;
    public float rollY;
    public float rollZ;

    void Update()
    {
        transform.Rotate(rollX, rollY, rollZ);
       
    }

}
