using UnityEngine;
using System.Collections.Generic;

public class Checkpoint : MonoBehaviour {

    public List<GameObject> Barrier;
    public List<int> answerCheck = new List<int>();
    public int answerCheckCounter;
 

    void Start()
    {
        
        answerCheckCounter = 0;
        answerCheck.Add(1);
        answerCheck.Add(1);
        answerCheck.Add(2);
    }

      void Update () {
            if (Counting.Count == answerCheck[answerCheckCounter])
            {
                Destroy(Barrier[answerCheckCounter]);
                Counting.Count = 0;
                answerCheckCounter++;
            }
        
	}
}
