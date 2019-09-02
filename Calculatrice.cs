using UnityEngine;

public class Calculatrice : MonoBehaviour
{
    public int A, B;
    int C;
    void Start()
    {
        float C;
        C = A + B;
        Debug.Log("the result is ="+ C + " This is Jam3");
        C = A - B;
        Debug.Log("the result is =" + C + " This is TAR7");
        C = A * B;
        Debug.Log("the result is =" + C + " This is DHarb");
        C = A / B;
        Debug.Log("the result is =" + C + " This is 9ISMA");
        C = A % B;
        Debug.Log("the result is =" + C + " This is Be9i el9ISMA");







    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
