using UnityEngine.SceneManagement;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        if( other.gameObject.tag =="Finish")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }   
    }
}
