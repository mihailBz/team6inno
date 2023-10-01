using UnityEngine;
[RequireComponent(typeof(SphereCollider))]
public class acceleration : MonoBehaviour
{
    //This script is responsible for what happens when the pullable objects reach the core
    //by default, the game objects are simply turned off
    //as this is much more performant than destroying the objects
    void OnTriggerStay (Collider other) {
        if(other.GetComponent<SingularityPullable>()){
            other.gameObject.SetActive(false);
        }
        moneyTracker.money -= 10000;
        moneyTracker.companyThree += 1;
        moneyTracker.stockvalue += 10000;
        moneyTracker.UpdateText();
        
    }

    void Awake(){
        if(GetComponent<SphereCollider>()){
            GetComponent<SphereCollider>().isTrigger = true;
        }
    }
}