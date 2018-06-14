using System.Reflection;
using UnityEngine;

public class Dammy2 : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        Debug.Log(string.Format("{0} {1} {2}", this.GetType().Name, MethodBase.GetCurrentMethod().Name, this.GetType().FullName));
    }

    // Update is called once per frame
    void Update()
    {

    }
}
