using UnityEngine;

namespace OOP
{
    public class ScopeTest : MonoBehaviour //Works
    {
        private int lifepoints;

        private void Start()
        {
            lifepoints = 100;
        }

        private void Update()
        {
            lifepoints--;
            if (lifepoints <= 0)
                Debug.Log("Death");
        }
    }

    //public class ScopeTest : MonoBehaviour //Doesnt work
    //{
    //    private void Start()
    //    {
    //        int lifepoints = 100;
    //    }

    //    private void Update()
    //    {
    //        lifepoints--; //lifepoints is not defined
    //        if (lifepoints <= 0)
    //            Debug.Log("Death");
    //    }
    //}
}