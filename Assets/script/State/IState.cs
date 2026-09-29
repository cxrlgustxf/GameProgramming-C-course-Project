using UnityEngine;

public interface IState
{
    
    void EnterState(GameObject cxt) { }

    void ExitState(GameObject cxt) { }

    void UpdateState(GameObject cxt) { }



}
