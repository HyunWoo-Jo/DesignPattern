using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConcreteMediator : Mediator
{
    PopColleagueB pop;
    PushColleagueA push;

    void Push() {
        push.Execute();
    }

    void Pop() {
        pop.Execute();
    }
}
