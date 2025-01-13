using UnityEngine;

public class CubeManipulations : MonoBehaviour
{
    public void Rotate()
    {
        transform.Rotate(new Vector3(0, 45, 0));
    }

    public void Scale()
    {
        transform.localScale += new Vector3(0.1f, 0.1f, 0.1f);
    }

    public void Adelante()
    {
        transform.Translate(Vector3.forward);
    }

    public void Atras()
    {
        transform.Translate(Vector3.back);
    }
}