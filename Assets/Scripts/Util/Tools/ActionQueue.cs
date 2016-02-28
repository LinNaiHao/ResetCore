﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class ActionQueue
{

    //队列中是否有行为
    private bool isLoading = false;
    //行动队列
    private Queue<Action> m_queue = new Queue<Action>();

    public ActionQueue()
    {
        isLoading = false;
    }

    public void AddAction(Action<Action> actionCB)
    {
        if (isLoading)
        {
            //队列非空，则加入队列
            this.m_queue.Enqueue(()=>
            {
                this.WaitAndDo(actionCB, this.m_queue);
            });
        }
        else
        {
            //现在正在进行调用isLoading为true
            isLoading = true;
            //队列为空，直接调用，但是下一个行为在运行时需要加入队列
            this.WaitAndDo(actionCB, this.m_queue);
        }
    }

    private void WaitAndDo(Action<Action> actionCB, Queue<Action> q)
    {
        Action callBack = () =>
        {
            if (q.Count != 0)
            {
                //出队列得到Action并且调用
                q.Dequeue().Invoke();
            }
            else
            {
                //表示队列为空，下次可以直接进行调用
                isLoading = false;
            }
        };
        //在行为调用完成之后进行回调
        actionCB(callBack);
    }


}
